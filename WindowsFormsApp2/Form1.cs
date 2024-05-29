using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port;
        Timer countdownTimer;
        int countdownTime;
        int distance;
        int distanceInCm = 0;
        bool inCountdown = false;
        bool isCountingForNoObject = false;
        int originalCountdownTime;
        bool messagePrinted = false;

        bool isInButtonChecked = false;
        bool isOutButtonChecked = false;

        const int greenLEDPin = 7; // Define the green LED pin
        const int redLEDPin = 8; // Define the red LED pin

        public Form1()
        {
            InitializeComponent();
            getAvailableComPorts();
            foreach (string port in ports)
            {
                combobox_portlist.Items.Add(port);
                if (ports.Length > 0)
                {
                    combobox_portlist.SelectedItem = ports[0];
                }
            }

            countdownTimer = new Timer();
            countdownTimer.Interval = 1000;
            countdownTimer.Tick += timer1_Tick;
        }

        //----------------------------------------------------------------------------------------------------------------------------

        //COM PORTS
        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = combobox_portlist.GetItemText(combobox_portlist.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            port.Open();
            port.Write("#STAR\n");
            button_Connect.Text = "Disconnect";
            MessageBox.Show("Connected to Arduino!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            port.Write("#STOP\n");
            port.Close();
            button_Connect.Text = "Connect";
            MessageBox.Show("Disconnected from Arduino!", "Connection Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Connect_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
            }
            else
            {
                disconnectFromArduino();
            }
        }

        void getAvailableComPorts()
        {
            ports = SerialPort.GetPortNames();
        }

        //----------------------------------------------------------------------------------------------------------------------------

        // SUPERLATE AND LATE

        private string countdownMessage = string.Empty;
        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string message = port.ReadLine();
            string data = port.ReadLine();
            this.Invoke(new Action(() => ProcessReceivedData(data)));
            if (message.Contains("#DISTANCE"))
            {
                string[] parts = message.Split(' ');
                if (parts.Length == 2 && int.TryParse(parts[1], out distance))
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        label_degree.Text = $"Centimeters: {distance} cm";
                        if (inCountdown)
                        {
                            if (isCountingForNoObject && distance <= 5)
                            {
                                isCountingForNoObject = false;
                                countdownTime = originalCountdownTime;
                                port.Write($"#START{countdownTime}\n");
                                textBox2_displaycountdown.Text = $"{countdownTime} seconds remaining.";
                            }
                            else if (!isCountingForNoObject && distance > 5 && !messagePrinted)
                            {
                                isCountingForNoObject = true;
                                countdownTime = 20;
                                port.Write("#START20\n");
                                textBox3__display.Text = "Buzzer activates if not within 5 cm or exceeds limit; stay inside";
                                messagePrinted = true;
                            }
                        }
                        else
                        {
                            messagePrinted = false;
                        }
                    }));
                }
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdownTime--;
            if (countdownTime > 0)
            {
                textBox2_displaycountdown.Text = $"{countdownTime} seconds remaining.";
            }
            else
            {
                countdownTimer.Stop();
                inCountdown = false;
                if (distance <= 5 && !isCountingForNoObject)
                {
                    port.Write("#COMPLETE\n");
                    textBox3__display.Text = "Congrats, well done!";
                    textBox2_displaycountdown.Text = " ";

                }
                else
                {
                    port.Write("#BUZZER\n");
                    textBox3__display.Text = "Buzzer activates after 20 seconds if no people detected within 5 cm!";
                }
            }

        }

        private void btnstart_superlate_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to a COM port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isCountingForNoObject = false;

            if (radionbtn5secs.Checked)
            {
                countdownTime = 5;
                originalCountdownTime = 5;
            }
            else if (radionbtn10secs.Checked)
            {
                countdownTime = 10;
                originalCountdownTime = 10;
            }
            else if (radionbtn15secs.Checked)
            {
                countdownTime = 15;
                originalCountdownTime = 15;
            }

            if (distance <= 5)
            {
                inCountdown = true;
                countdownTimer.Start();
                port.Write($"#START{countdownTime}\n");
                textBox2_displaycountdown.Text = $"{countdownTime} seconds remaining.";
            }
            else
            {
                isCountingForNoObject = true;
                countdownTime = 20;
                countdownTimer.Start();
                port.Write("#START20\n");
                textBox3__display.Text = "Start button pressed accidentally or for testing sound and countdown wait 20 seconds.";
            }
        }

        private void btnreset_superlate_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to a COM port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox2_displaycountdown.Clear();
            textBox3__display.Clear();
            textBox_listotalofstudents.Clear();
            countdownTimer.Stop();
            inCountdown = false;
            port.Write("#RESET\n");
            radionbtn5secs.Checked = false;
            radionbtn10secs.Checked = false;
            radionbtn15secs.Checked = false;



            distance = 0;
            inCountdown = false;
            isCountingForNoObject = false;
            originalCountdownTime = 0;
            messagePrinted = false;
        }



        //----------------------------------------------------------------------------------------------------------------------------

        // 0 DEGREE, 90 DEGREE, 180 DEGREE.

        private int totalStudents = 0;
        private const int maxStudents = 10;
        private DateTime? lastButtonClickTime;
        private const int CHECK_INTERVAL_MS = 100;

        private void ProcessReceivedData(string data)
        {



            Application.DoEvents();

            if (data.StartsWith("TIME IN STUDENT "))
            {
                totalStudents++;
                UpdateTotalStudentsLabel();
                string timeString = DateTime.Now.ToString("HH:mm");
                this.BeginInvoke(new MethodInvoker(delegate { textBox_listotalofstudents.AppendText($"\nTIME IN STUDENT {timeString}" + Environment.NewLine); }));
            }
            else if (data.StartsWith("TIME OUT STUDENT "))
            {
                totalStudents--;
                UpdateTotalStudentsLabel();
                string timeString = DateTime.Now.ToString("HH:mm");
                this.BeginInvoke(new MethodInvoker(delegate { textBox_listotalofstudents.AppendText($"\nTIME OUT STUDENT {timeString}" + Environment.NewLine); }));
            }
            else if (data.StartsWith("TOTAL STUDENTS "))
            {
                string[] parts = data.Split(' ');
                if (parts.Length == 3)
                {
                    if (int.TryParse(parts[2].Split('/')[0], out int currentCount))
                    {
                        totalStudents = currentCount;
                        UpdateTotalStudentsLabel();
                    }
                }
            }
            else if (data == "Maximum students reached." || data == "No students remaining.")
            {
                this.BeginInvoke(new MethodInvoker(delegate { textBox_listotalofstudents.AppendText(data + Environment.NewLine); }));
            }
            else if (data.StartsWith("#DISTANCE"))
            {
                string distanceString = data.Substring("#DISTANCE".Length).Trim();
                int distance;
                if (int.TryParse(distanceString, out distance))
                {
                    UpdateDistanceLabel(distance);
                }
                if (data.StartsWith("BUTTON PRESSED"))
                {
                    if (radioButton3_180degree.Checked && totalStudents > 0)
                    {
                        totalStudents--;
                        UpdateTotalStudentsLabel();
                        this.BeginInvoke(new MethodInvoker(delegate { textBox_listotalofstudents.AppendText("TIME OUT STUDENT " + totalStudents + "/" + maxStudents + Environment.NewLine); }));
                    }
                    else if (radioButton2_90degree.Checked)
                    {

                    }
                }
            }
        }


        private void UpdateTotalStudentsLabel()
        {
            label_totalofstudents.Text = "Total Students: " + totalStudents + "/" + maxStudents;
        }

        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string data = serialPort1.ReadLine();
            this.Invoke(new MethodInvoker(delegate { ProcessReceivedData(data); }));

            if (data.StartsWith("BUTTON PRESSED"))
            {
                if (radioButton3_180degree.Checked && totalStudents > 0)
                {
                    totalStudents--;
                    UpdateTotalStudentsLabel();
                    this.BeginInvoke(new MethodInvoker(delegate { textBox_listotalofstudents.AppendText("TIME OUT STUDENT " + totalStudents + "/" + maxStudents + Environment.NewLine); }));
                }
            }
        }

        private void radioButton1_0degree_CheckedChanged(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to a COM port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButton1_0degree.Checked)
            {
                port.Write("0");
            }
        }

        private void radioButton2_90degree_CheckedChanged(object sender, EventArgs e)
        {
            if (isConnected)
            {
                port.Write("2");
                textBox3__display.Text = "CLOSE DOOR!";
                textBox_listotalofstudents.Text = "";
            }
            else
            {
                MessageBox.Show("Please connect to a COM port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton3_180degree_CheckedChanged(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to a COM port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (radioButton3_180degree.Checked)
            {
                port.Write("1");
            }
        }

        private void UpdateDistanceLabel(int distance)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to a COM port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            label_degree.Text = $"Centimeters: {distance} cm";
        }

        private void InitializeSerialPort()
        {
            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(SerialPort_DataReceived);
            serialPort1.BaudRate = 9600;
            serialPort1.PortName = "COM6";
            serialPort1.Open();
        }


        // BTN IN AND BTN OUT

        private void checkBox1_BTNIN_CheckedChanged(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to a COM port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBox1_BTNIN.Checked = false;
                return;
            }


            if (checkBox1_BTNIN.Checked)
            {
                isInButtonChecked = checkBox1_BTNIN.Checked;
            }

        }

        private void checkBox2_BTNOUT_CheckedChanged(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to a COM port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkBox2_BTNOUT.Checked = false;
                return;
            }
            if (checkBox2_BTNOUT.Checked)
            {
                isOutButtonChecked = checkBox2_BTNOUT.Checked;
            }

        }

        private void activatebtn_inOut_Click(object sender, EventArgs e)
        {

        }






        private void Form1_Load(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to a COM port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string message = "";

            if (isInButtonChecked && isOutButtonChecked)
            {
                message = "Both BTN IN and BTN OUT are activated.";
                SendSerialData("LISTEN_IN");
                SendSerialData("LISTEN_OUT");
            }
            else
            {
                if (isInButtonChecked)
                {
                    message += "BTN IN is activated.";
                    SendSerialData("LISTEN_IN");
                }

                if (isOutButtonChecked)
                {
                    if (isInButtonChecked)
                    {
                        message += "\n";
                    }
                    message += "BTN OUT is activated.";
                    SendSerialData("LISTEN_OUT");
                }
            }

            UpdateDisplay(message);
        }




        private void btn_resetuncheckbox_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to a COM port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            checkBox1_BTNIN.Checked = false;
            checkBox2_BTNOUT.Checked = false;
            radioButton1_0degree.Checked = false;
            radioButton2_90degree.Checked = false;
            radioButton3_180degree.Checked = false;
            textBox3__display.Clear();
            textBox_listotalofstudents.Clear();
            isInButtonChecked = false;
            isOutButtonChecked = false;

            if (isConnected)
            {
                SendSerialData("STOP_LISTEN");
            }
        }
        public void UpdateDisplay(string message)
        {

            if (textBox3__display != null)
            {

                if (textBox3__display.InvokeRequired)
                {
                    textBox3__display.Invoke(new Action<string>(UpdateDisplay), new object[] { message });
                }
                else
                {

                    textBox3__display.Text = message;
                }
            }
        }

        private void SendSerialData(string data)
        {
            if (isConnected)
            {
                port.WriteLine(data);
            }
            else
            {
                MessageBox.Show("Arduino is not connected. Please connect to Arduino first.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //----------------------------------------------------------------------------------------------------------------------------

        private void button_resetall_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                MessageBox.Show("Please connect to a COM port first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            port.Write("#RESET\n");
            textBox2_displaycountdown.Clear();
            textBox3__display.Clear();
            textBox_listotalofstudents.Clear();
            countdownTimer.Stop();
            inCountdown = false;
            isCountingForNoObject = false;
            originalCountdownTime = 0;
            messagePrinted = false;
        }
    }
}