namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.checkBox1_BTNIN = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3_180degree = new System.Windows.Forms.RadioButton();
            this.checkBox2_BTNOUT = new System.Windows.Forms.CheckBox();
            this.radioButton2_90degree = new System.Windows.Forms.RadioButton();
            this.btn_resetuncheckbox = new System.Windows.Forms.Button();
            this.radioButton1_0degree = new System.Windows.Forms.RadioButton();
            this.activatebtn_inOut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox3__display = new System.Windows.Forms.TextBox();
            this.groupBox3_display = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.radionbtn5secs = new System.Windows.Forms.RadioButton();
            this.textBox_listotalofstudents = new System.Windows.Forms.TextBox();
            this.label_totalofstudents = new System.Windows.Forms.Label();
            this.label_degree = new System.Windows.Forms.Label();
            this.textBox2_displaycountdown = new System.Windows.Forms.TextBox();
            this.btnreset_superlate = new System.Windows.Forms.Button();
            this.btnstart_superlate = new System.Windows.Forms.Button();
            this.radionbtn15secs = new System.Windows.Forms.RadioButton();
            this.radionbtn10secs = new System.Windows.Forms.RadioButton();
            this.groupBox2_superlate = new System.Windows.Forms.GroupBox();
            this.button_resetall = new System.Windows.Forms.Button();
            this.button_Connect = new System.Windows.Forms.Button();
            this.combobox_portlist = new System.Windows.Forms.ComboBox();
            this.groupBox4_late = new System.Windows.Forms.GroupBox();
            this.groupBox6_totalofstudents = new System.Windows.Forms.GroupBox();
            this.grpbox1com_ports = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3_display.SuspendLayout();
            this.groupBox2_superlate.SuspendLayout();
            this.groupBox4_late.SuspendLayout();
            this.groupBox6_totalofstudents.SuspendLayout();
            this.grpbox1com_ports.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1_BTNIN
            // 
            this.checkBox1_BTNIN.AutoSize = true;
            this.checkBox1_BTNIN.Location = new System.Drawing.Point(226, 41);
            this.checkBox1_BTNIN.Name = "checkBox1_BTNIN";
            this.checkBox1_BTNIN.Size = new System.Drawing.Size(64, 17);
            this.checkBox1_BTNIN.TabIndex = 2;
            this.checkBox1_BTNIN.Text = "BTN IN";
            this.checkBox1_BTNIN.UseVisualStyleBackColor = true;
            this.checkBox1_BTNIN.CheckedChanged += new System.EventHandler(this.checkBox1_BTNIN_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.groupBox1.Controls.Add(this.radioButton3_180degree);
            this.groupBox1.Controls.Add(this.checkBox2_BTNOUT);
            this.groupBox1.Controls.Add(this.radioButton2_90degree);
            this.groupBox1.Controls.Add(this.btn_resetuncheckbox);
            this.groupBox1.Controls.Add(this.radioButton1_0degree);
            this.groupBox1.Controls.Add(this.checkBox1_BTNIN);
            this.groupBox1.Controls.Add(this.activatebtn_inOut);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 125);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DOOR:";
            // 
            // radioButton3_180degree
            // 
            this.radioButton3_180degree.AutoSize = true;
            this.radioButton3_180degree.Location = new System.Drawing.Point(45, 85);
            this.radioButton3_180degree.Name = "radioButton3_180degree";
            this.radioButton3_180degree.Size = new System.Drawing.Size(96, 17);
            this.radioButton3_180degree.TabIndex = 5;
            this.radioButton3_180degree.TabStop = true;
            this.radioButton3_180degree.Text = "180° Degree";
            this.radioButton3_180degree.UseVisualStyleBackColor = true;
            this.radioButton3_180degree.CheckedChanged += new System.EventHandler(this.radioButton3_180degree_CheckedChanged);
            // 
            // checkBox2_BTNOUT
            // 
            this.checkBox2_BTNOUT.AutoSize = true;
            this.checkBox2_BTNOUT.Location = new System.Drawing.Point(226, 72);
            this.checkBox2_BTNOUT.Name = "checkBox2_BTNOUT";
            this.checkBox2_BTNOUT.Size = new System.Drawing.Size(75, 17);
            this.checkBox2_BTNOUT.TabIndex = 4;
            this.checkBox2_BTNOUT.Text = "BTN OUT";
            this.checkBox2_BTNOUT.UseVisualStyleBackColor = true;
            this.checkBox2_BTNOUT.CheckedChanged += new System.EventHandler(this.checkBox2_BTNOUT_CheckedChanged);
            // 
            // radioButton2_90degree
            // 
            this.radioButton2_90degree.AutoSize = true;
            this.radioButton2_90degree.Location = new System.Drawing.Point(46, 54);
            this.radioButton2_90degree.Name = "radioButton2_90degree";
            this.radioButton2_90degree.Size = new System.Drawing.Size(89, 17);
            this.radioButton2_90degree.TabIndex = 4;
            this.radioButton2_90degree.TabStop = true;
            this.radioButton2_90degree.Text = "90° Degree";
            this.radioButton2_90degree.UseVisualStyleBackColor = true;
            this.radioButton2_90degree.CheckedChanged += new System.EventHandler(this.radioButton2_90degree_CheckedChanged);
            // 
            // btn_resetuncheckbox
            // 
            this.btn_resetuncheckbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(161)))), ((int)(((byte)(33)))));
            this.btn_resetuncheckbox.Location = new System.Drawing.Point(365, 68);
            this.btn_resetuncheckbox.Name = "btn_resetuncheckbox";
            this.btn_resetuncheckbox.Size = new System.Drawing.Size(141, 30);
            this.btn_resetuncheckbox.TabIndex = 1;
            this.btn_resetuncheckbox.Text = "RESET ALL";
            this.btn_resetuncheckbox.UseVisualStyleBackColor = false;
            this.btn_resetuncheckbox.Click += new System.EventHandler(this.btn_resetuncheckbox_Click);
            // 
            // radioButton1_0degree
            // 
            this.radioButton1_0degree.AutoSize = true;
            this.radioButton1_0degree.Location = new System.Drawing.Point(48, 25);
            this.radioButton1_0degree.Name = "radioButton1_0degree";
            this.radioButton1_0degree.Size = new System.Drawing.Size(82, 17);
            this.radioButton1_0degree.TabIndex = 3;
            this.radioButton1_0degree.TabStop = true;
            this.radioButton1_0degree.Text = "0° Degree";
            this.radioButton1_0degree.UseVisualStyleBackColor = true;
            this.radioButton1_0degree.CheckedChanged += new System.EventHandler(this.radioButton1_0degree_CheckedChanged);
            // 
            // activatebtn_inOut
            // 
            this.activatebtn_inOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(161)))), ((int)(((byte)(33)))));
            this.activatebtn_inOut.Location = new System.Drawing.Point(363, 25);
            this.activatebtn_inOut.Name = "activatebtn_inOut";
            this.activatebtn_inOut.Size = new System.Drawing.Size(139, 30);
            this.activatebtn_inOut.TabIndex = 0;
            this.activatebtn_inOut.Text = "ACTIVATE";
            this.activatebtn_inOut.UseVisualStyleBackColor = false;
            this.activatebtn_inOut.Click += new System.EventHandler(this.activatebtn_inOut_Click);
            // 
            // textBox3__display
            // 
            this.textBox3__display.BackColor = System.Drawing.Color.White;
            this.textBox3__display.Font = new System.Drawing.Font("Impact", 15F);
            this.textBox3__display.Location = new System.Drawing.Point(20, 20);
            this.textBox3__display.Multiline = true;
            this.textBox3__display.Name = "textBox3__display";
            this.textBox3__display.Size = new System.Drawing.Size(456, 141);
            this.textBox3__display.TabIndex = 10;
            this.textBox3__display.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3_display
            // 
            this.groupBox3_display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.groupBox3_display.Controls.Add(this.textBox3__display);
            this.groupBox3_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3_display.Location = new System.Drawing.Point(333, 12);
            this.groupBox3_display.Name = "groupBox3_display";
            this.groupBox3_display.Size = new System.Drawing.Size(500, 177);
            this.groupBox3_display.TabIndex = 12;
            this.groupBox3_display.TabStop = false;
            this.groupBox3_display.Text = "DISPLAY:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 148);
            this.textBox1.TabIndex = 0;
            // 
            // button_plus
            // 
            this.button_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(161)))), ((int)(((byte)(33)))));
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_plus.Location = new System.Drawing.Point(122, 300);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(75, 34);
            this.button_plus.TabIndex = 13;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = false;
            // 
            // button_minus
            // 
            this.button_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(161)))), ((int)(((byte)(33)))));
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button_minus.Location = new System.Drawing.Point(21, 301);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(75, 34);
            this.button_minus.TabIndex = 10;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = false;
            // 
            // radionbtn5secs
            // 
            this.radionbtn5secs.AutoSize = true;
            this.radionbtn5secs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radionbtn5secs.Location = new System.Drawing.Point(9, 27);
            this.radionbtn5secs.Name = "radionbtn5secs";
            this.radionbtn5secs.Size = new System.Drawing.Size(83, 17);
            this.radionbtn5secs.TabIndex = 0;
            this.radionbtn5secs.TabStop = true;
            this.radionbtn5secs.Text = "5 seconds";
            this.radionbtn5secs.UseVisualStyleBackColor = true;
            // 
            // textBox_listotalofstudents
            // 
            this.textBox_listotalofstudents.BackColor = System.Drawing.Color.White;
            this.textBox_listotalofstudents.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_listotalofstudents.Location = new System.Drawing.Point(21, 25);
            this.textBox_listotalofstudents.Multiline = true;
            this.textBox_listotalofstudents.Name = "textBox_listotalofstudents";
            this.textBox_listotalofstudents.Size = new System.Drawing.Size(183, 238);
            this.textBox_listotalofstudents.TabIndex = 12;
            // 
            // label_totalofstudents
            // 
            this.label_totalofstudents.AutoSize = true;
            this.label_totalofstudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_totalofstudents.Location = new System.Drawing.Point(11, 274);
            this.label_totalofstudents.Name = "label_totalofstudents";
            this.label_totalofstudents.Size = new System.Drawing.Size(107, 13);
            this.label_totalofstudents.TabIndex = 0;
            this.label_totalofstudents.Text = "Total of Students:";
            // 
            // label_degree
            // 
            this.label_degree.AutoSize = true;
            this.label_degree.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_degree.Location = new System.Drawing.Point(131, 109);
            this.label_degree.Name = "label_degree";
            this.label_degree.Size = new System.Drawing.Size(77, 13);
            this.label_degree.TabIndex = 9;
            this.label_degree.Text = "Centimeters:";
            // 
            // textBox2_displaycountdown
            // 
            this.textBox2_displaycountdown.BackColor = System.Drawing.Color.White;
            this.textBox2_displaycountdown.Font = new System.Drawing.Font("Impact", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_displaycountdown.Location = new System.Drawing.Point(143, 29);
            this.textBox2_displaycountdown.Multiline = true;
            this.textBox2_displaycountdown.Name = "textBox2_displaycountdown";
            this.textBox2_displaycountdown.Size = new System.Drawing.Size(137, 66);
            this.textBox2_displaycountdown.TabIndex = 8;
            // 
            // btnreset_superlate
            // 
            this.btnreset_superlate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(161)))), ((int)(((byte)(33)))));
            this.btnreset_superlate.Location = new System.Drawing.Point(150, 141);
            this.btnreset_superlate.Name = "btnreset_superlate";
            this.btnreset_superlate.Size = new System.Drawing.Size(92, 39);
            this.btnreset_superlate.TabIndex = 6;
            this.btnreset_superlate.Text = "RESET";
            this.btnreset_superlate.UseVisualStyleBackColor = false;
            this.btnreset_superlate.Click += new System.EventHandler(this.btnreset_superlate_Click);
            // 
            // btnstart_superlate
            // 
            this.btnstart_superlate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(161)))), ((int)(((byte)(33)))));
            this.btnstart_superlate.Location = new System.Drawing.Point(44, 140);
            this.btnstart_superlate.Name = "btnstart_superlate";
            this.btnstart_superlate.Size = new System.Drawing.Size(92, 39);
            this.btnstart_superlate.TabIndex = 3;
            this.btnstart_superlate.Text = "START";
            this.btnstart_superlate.UseVisualStyleBackColor = false;
            this.btnstart_superlate.Click += new System.EventHandler(this.btnstart_superlate_Click);
            // 
            // radionbtn15secs
            // 
            this.radionbtn15secs.AutoSize = true;
            this.radionbtn15secs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radionbtn15secs.Location = new System.Drawing.Point(9, 87);
            this.radionbtn15secs.Name = "radionbtn15secs";
            this.radionbtn15secs.Size = new System.Drawing.Size(92, 17);
            this.radionbtn15secs.TabIndex = 2;
            this.radionbtn15secs.TabStop = true;
            this.radionbtn15secs.Text = "15 Seconds";
            this.radionbtn15secs.UseVisualStyleBackColor = true;
            // 
            // radionbtn10secs
            // 
            this.radionbtn10secs.AutoSize = true;
            this.radionbtn10secs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radionbtn10secs.Location = new System.Drawing.Point(9, 56);
            this.radionbtn10secs.Name = "radionbtn10secs";
            this.radionbtn10secs.Size = new System.Drawing.Size(90, 17);
            this.radionbtn10secs.TabIndex = 1;
            this.radionbtn10secs.TabStop = true;
            this.radionbtn10secs.Text = "10 seconds";
            this.radionbtn10secs.UseVisualStyleBackColor = true;
            // 
            // groupBox2_superlate
            // 
            this.groupBox2_superlate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.groupBox2_superlate.Controls.Add(this.label_degree);
            this.groupBox2_superlate.Controls.Add(this.textBox2_displaycountdown);
            this.groupBox2_superlate.Controls.Add(this.btnreset_superlate);
            this.groupBox2_superlate.Controls.Add(this.btnstart_superlate);
            this.groupBox2_superlate.Controls.Add(this.radionbtn15secs);
            this.groupBox2_superlate.Controls.Add(this.radionbtn10secs);
            this.groupBox2_superlate.Controls.Add(this.radionbtn5secs);
            this.groupBox2_superlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2_superlate.Location = new System.Drawing.Point(13, 350);
            this.groupBox2_superlate.Name = "groupBox2_superlate";
            this.groupBox2_superlate.Size = new System.Drawing.Size(290, 201);
            this.groupBox2_superlate.TabIndex = 9;
            this.groupBox2_superlate.TabStop = false;
            this.groupBox2_superlate.Text = "SUPER LATE:";
            // 
            // button_resetall
            // 
            this.button_resetall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(161)))), ((int)(((byte)(33)))));
            this.button_resetall.Location = new System.Drawing.Point(151, 113);
            this.button_resetall.Name = "button_resetall";
            this.button_resetall.Size = new System.Drawing.Size(116, 34);
            this.button_resetall.TabIndex = 6;
            this.button_resetall.Text = "RESET";
            this.button_resetall.UseVisualStyleBackColor = false;
            this.button_resetall.Click += new System.EventHandler(this.button_resetall_Click);
            // 
            // button_Connect
            // 
            this.button_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(161)))), ((int)(((byte)(33)))));
            this.button_Connect.Location = new System.Drawing.Point(20, 111);
            this.button_Connect.Name = "button_Connect";
            this.button_Connect.Size = new System.Drawing.Size(116, 38);
            this.button_Connect.TabIndex = 1;
            this.button_Connect.Text = "Connect";
            this.button_Connect.UseVisualStyleBackColor = false;
            this.button_Connect.Click += new System.EventHandler(this.button_Connect_Click);
            // 
            // combobox_portlist
            // 
            this.combobox_portlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_portlist.FormattingEnabled = true;
            this.combobox_portlist.Location = new System.Drawing.Point(42, 53);
            this.combobox_portlist.Name = "combobox_portlist";
            this.combobox_portlist.Size = new System.Drawing.Size(211, 21);
            this.combobox_portlist.TabIndex = 0;
            // 
            // groupBox4_late
            // 
            this.groupBox4_late.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.groupBox4_late.Controls.Add(this.textBox1);
            this.groupBox4_late.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4_late.Location = new System.Drawing.Point(332, 350);
            this.groupBox4_late.Name = "groupBox4_late";
            this.groupBox4_late.Size = new System.Drawing.Size(258, 201);
            this.groupBox4_late.TabIndex = 11;
            this.groupBox4_late.TabStop = false;
            this.groupBox4_late.Text = "NOTES:";
            // 
            // groupBox6_totalofstudents
            // 
            this.groupBox6_totalofstudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.groupBox6_totalofstudents.Controls.Add(this.button_plus);
            this.groupBox6_totalofstudents.Controls.Add(this.button_minus);
            this.groupBox6_totalofstudents.Controls.Add(this.textBox_listotalofstudents);
            this.groupBox6_totalofstudents.Controls.Add(this.label_totalofstudents);
            this.groupBox6_totalofstudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6_totalofstudents.Location = new System.Drawing.Point(612, 207);
            this.groupBox6_totalofstudents.Name = "groupBox6_totalofstudents";
            this.groupBox6_totalofstudents.Size = new System.Drawing.Size(221, 344);
            this.groupBox6_totalofstudents.TabIndex = 10;
            this.groupBox6_totalofstudents.TabStop = false;
            this.groupBox6_totalofstudents.Text = "TIME IN AND OUT:";
            // 
            // grpbox1com_ports
            // 
            this.grpbox1com_ports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(244)))), ((int)(((byte)(228)))));
            this.grpbox1com_ports.Controls.Add(this.button_resetall);
            this.grpbox1com_ports.Controls.Add(this.button_Connect);
            this.grpbox1com_ports.Controls.Add(this.combobox_portlist);
            this.grpbox1com_ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox1com_ports.Location = new System.Drawing.Point(12, 12);
            this.grpbox1com_ports.Name = "grpbox1com_ports";
            this.grpbox1com_ports.Size = new System.Drawing.Size(291, 177);
            this.grpbox1com_ports.TabIndex = 8;
            this.grpbox1com_ports.TabStop = false;
            this.grpbox1com_ports.Text = "COM PORTS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3_display);
            this.Controls.Add(this.groupBox2_superlate);
            this.Controls.Add(this.groupBox4_late);
            this.Controls.Add(this.groupBox6_totalofstudents);
            this.Controls.Add(this.grpbox1com_ports);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3_display.ResumeLayout(false);
            this.groupBox3_display.PerformLayout();
            this.groupBox2_superlate.ResumeLayout(false);
            this.groupBox2_superlate.PerformLayout();
            this.groupBox4_late.ResumeLayout(false);
            this.groupBox4_late.PerformLayout();
            this.groupBox6_totalofstudents.ResumeLayout(false);
            this.groupBox6_totalofstudents.PerformLayout();
            this.grpbox1com_ports.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1_BTNIN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3_180degree;
        private System.Windows.Forms.CheckBox checkBox2_BTNOUT;
        private System.Windows.Forms.RadioButton radioButton2_90degree;
        private System.Windows.Forms.Button btn_resetuncheckbox;
        private System.Windows.Forms.RadioButton radioButton1_0degree;
        private System.Windows.Forms.Button activatebtn_inOut;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox3__display;
        private System.Windows.Forms.GroupBox groupBox3_display;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.RadioButton radionbtn5secs;
        private System.Windows.Forms.TextBox textBox_listotalofstudents;
        private System.Windows.Forms.Label label_totalofstudents;
        private System.Windows.Forms.Label label_degree;
        private System.Windows.Forms.TextBox textBox2_displaycountdown;
        private System.Windows.Forms.Button btnreset_superlate;
        private System.Windows.Forms.Button btnstart_superlate;
        private System.Windows.Forms.RadioButton radionbtn15secs;
        private System.Windows.Forms.RadioButton radionbtn10secs;
        private System.Windows.Forms.GroupBox groupBox2_superlate;
        private System.Windows.Forms.Button button_resetall;
        private System.Windows.Forms.Button button_Connect;
        private System.Windows.Forms.ComboBox combobox_portlist;
        private System.Windows.Forms.GroupBox groupBox4_late;
        private System.Windows.Forms.GroupBox groupBox6_totalofstudents;
        private System.Windows.Forms.GroupBox grpbox1com_ports;
    }
}

