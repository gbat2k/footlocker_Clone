﻿namespace Net_Weave_R.Forms.Dialogs
{
    partial class MultiFloodPanel
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
            this.carbonTheme1 = new CarbonTheme();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.cmdType = new System.Windows.Forms.ComboBox();
            this.carbonGroupBox2 = new CarbonGroupBox();
            this.txtSecs = new CarbonTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMins = new CarbonTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHours = new CarbonTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xTimer = new CarbonCheckBox();
            this.carbonGroupBox1 = new CarbonGroupBox();
            this.xResolveHost = new CarbonCheckBox();
            this.xCommaFix = new CarbonCheckBox();
            this.xTopMost = new CarbonCheckBox();
            this.btnStop = new CarbonButton();
            this.btnStart = new CarbonButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDelay = new CarbonTextBox();
            this.carbonSeperator1 = new CarbonSeperator();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPackets = new CarbonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSockets = new CarbonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPort = new CarbonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new CarbonTextBox();
            this.lstHosts = new NetLib.Forms.xListview();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carbonTheme1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.carbonGroupBox2.SuspendLayout();
            this.carbonGroupBox1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // carbonTheme1
            // 
            this.carbonTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.carbonTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.carbonTheme1.ControlBox = true;
            this.carbonTheme1.Controls.Add(this.panel1);
            this.carbonTheme1.Customization = "wMDA/8DAwP96enr/09PT/0ZGRv+Wlpb/AAAA/////27///8e////AAAAAP9WVlb/";
            this.carbonTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.carbonTheme1.DrawHatch = true;
            this.carbonTheme1.EnableExit = true;
            this.carbonTheme1.EnableMaximize = false;
            this.carbonTheme1.EnableMinimize = true;
            this.carbonTheme1.Font = new System.Drawing.Font("Verdana", 8F);
            this.carbonTheme1.Image = null;
            this.carbonTheme1.Location = new System.Drawing.Point(0, 0);
            this.carbonTheme1.Movable = true;
            this.carbonTheme1.Name = "carbonTheme1";
            this.carbonTheme1.NoRounding = false;
            this.carbonTheme1.Sizable = false;
            this.carbonTheme1.Size = new System.Drawing.Size(572, 318);
            this.carbonTheme1.SmartBounds = true;
            this.carbonTheme1.TabIndex = 0;
            this.carbonTheme1.Text = "Multi-Flood Panel";
            this.carbonTheme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.carbonTheme1.Transparent = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmdType);
            this.panel1.Controls.Add(this.carbonGroupBox2);
            this.panel1.Controls.Add(this.carbonGroupBox1);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtDelay);
            this.panel1.Controls.Add(this.carbonSeperator1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPackets);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSockets);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtHost);
            this.panel1.Controls.Add(this.lstHosts);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 279);
            this.panel1.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(460, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Type";
            // 
            // cmdType
            // 
            this.cmdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdType.FormattingEnabled = true;
            this.cmdType.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "SYN",
            "Slowloris"});
            this.cmdType.Location = new System.Drawing.Point(431, 153);
            this.cmdType.Name = "cmdType";
            this.cmdType.Size = new System.Drawing.Size(105, 21);
            this.cmdType.TabIndex = 39;
            // 
            // carbonGroupBox2
            // 
            this.carbonGroupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.carbonGroupBox2.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.carbonGroupBox2.Controls.Add(this.txtSecs);
            this.carbonGroupBox2.Controls.Add(this.label8);
            this.carbonGroupBox2.Controls.Add(this.txtMins);
            this.carbonGroupBox2.Controls.Add(this.label7);
            this.carbonGroupBox2.Controls.Add(this.txtHours);
            this.carbonGroupBox2.Controls.Add(this.label6);
            this.carbonGroupBox2.Controls.Add(this.xTimer);
            this.carbonGroupBox2.Customization = "09PT/6mpqf+pqan/////Rv///x7AwMD/4ODg/2xsbP8AAAD/qamp/w==";
            this.carbonGroupBox2.Font = new System.Drawing.Font("Verdana", 8F);
            this.carbonGroupBox2.Image = null;
            this.carbonGroupBox2.Location = new System.Drawing.Point(11, 201);
            this.carbonGroupBox2.Movable = true;
            this.carbonGroupBox2.Name = "carbonGroupBox2";
            this.carbonGroupBox2.NoRounding = false;
            this.carbonGroupBox2.Sizable = true;
            this.carbonGroupBox2.Size = new System.Drawing.Size(168, 71);
            this.carbonGroupBox2.SmartBounds = true;
            this.carbonGroupBox2.TabIndex = 38;
            this.carbonGroupBox2.Text = "Timer";
            this.carbonGroupBox2.TransparencyKey = System.Drawing.Color.Empty;
            this.carbonGroupBox2.Transparent = false;
            // 
            // txtSecs
            // 
            this.txtSecs.Customization = "AAAA/+Dg4P+pqan/qamp/////wD///8A";
            this.txtSecs.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtSecs.Image = null;
            this.txtSecs.Location = new System.Drawing.Point(110, 44);
            this.txtSecs.MaxLength = 32767;
            this.txtSecs.Multiline = false;
            this.txtSecs.Name = "txtSecs";
            this.txtSecs.NoRounding = false;
            this.txtSecs.NumbersOnly = true;
            this.txtSecs.ReadOnly = false;
            this.txtSecs.Size = new System.Drawing.Size(39, 24);
            this.txtSecs.TabIndex = 6;
            this.txtSecs.Text = "0";
            this.txtSecs.Transparent = false;
            this.txtSecs.UseSystemPasswordChar = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(112, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Secs";
            // 
            // txtMins
            // 
            this.txtMins.Customization = "AAAA/+Dg4P+pqan/qamp/////wD///8A";
            this.txtMins.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtMins.Image = null;
            this.txtMins.Location = new System.Drawing.Point(65, 44);
            this.txtMins.MaxLength = 32767;
            this.txtMins.Multiline = false;
            this.txtMins.Name = "txtMins";
            this.txtMins.NoRounding = false;
            this.txtMins.NumbersOnly = true;
            this.txtMins.ReadOnly = false;
            this.txtMins.Size = new System.Drawing.Size(39, 24);
            this.txtMins.TabIndex = 4;
            this.txtMins.Text = "0";
            this.txtMins.Transparent = false;
            this.txtMins.UseSystemPasswordChar = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(68, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Mins";
            // 
            // txtHours
            // 
            this.txtHours.Customization = "AAAA/+Dg4P+pqan/qamp/////wD///8A";
            this.txtHours.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtHours.Image = null;
            this.txtHours.Location = new System.Drawing.Point(20, 44);
            this.txtHours.MaxLength = 32767;
            this.txtHours.Multiline = false;
            this.txtHours.Name = "txtHours";
            this.txtHours.NoRounding = false;
            this.txtHours.NumbersOnly = true;
            this.txtHours.ReadOnly = false;
            this.txtHours.Size = new System.Drawing.Size(39, 24);
            this.txtHours.TabIndex = 2;
            this.txtHours.Text = "0";
            this.txtHours.Transparent = false;
            this.txtHours.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Hours";
            // 
            // xTimer
            // 
            this.xTimer.Checked = false;
            this.xTimer.Customization = "wMDA/1VVVf+AgID/QEBA/83Nzf+goKD/Wlpa/35+fv9qamr/AAAA/w==";
            this.xTimer.Font = new System.Drawing.Font("Verdana", 8F);
            this.xTimer.Image = null;
            this.xTimer.Location = new System.Drawing.Point(3, 6);
            this.xTimer.Name = "xTimer";
            this.xTimer.NoRounding = false;
            this.xTimer.Size = new System.Drawing.Size(14, 16);
            this.xTimer.TabIndex = 0;
            this.xTimer.Transparent = false;
            // 
            // carbonGroupBox1
            // 
            this.carbonGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.carbonGroupBox1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.carbonGroupBox1.Controls.Add(this.xResolveHost);
            this.carbonGroupBox1.Controls.Add(this.xCommaFix);
            this.carbonGroupBox1.Controls.Add(this.xTopMost);
            this.carbonGroupBox1.Customization = "09PT/6mpqf+pqan/////Rv///x7AwMD/4ODg/2xsbP8AAAD/qamp/w==";
            this.carbonGroupBox1.Font = new System.Drawing.Font("Verdana", 8F);
            this.carbonGroupBox1.Image = null;
            this.carbonGroupBox1.Location = new System.Drawing.Point(185, 201);
            this.carbonGroupBox1.Movable = true;
            this.carbonGroupBox1.Name = "carbonGroupBox1";
            this.carbonGroupBox1.NoRounding = false;
            this.carbonGroupBox1.Sizable = true;
            this.carbonGroupBox1.Size = new System.Drawing.Size(272, 71);
            this.carbonGroupBox1.SmartBounds = true;
            this.carbonGroupBox1.TabIndex = 37;
            this.carbonGroupBox1.Text = "Options";
            this.carbonGroupBox1.TransparencyKey = System.Drawing.Color.Empty;
            this.carbonGroupBox1.Transparent = false;
            // 
            // xResolveHost
            // 
            this.xResolveHost.Checked = false;
            this.xResolveHost.Customization = "wMDA/1VVVf+AgID/QEBA/83Nzf+goKD/Wlpa/35+fv9qamr/AAAA/w==";
            this.xResolveHost.Font = new System.Drawing.Font("Verdana", 8F);
            this.xResolveHost.Image = null;
            this.xResolveHost.Location = new System.Drawing.Point(43, 50);
            this.xResolveHost.Name = "xResolveHost";
            this.xResolveHost.NoRounding = false;
            this.xResolveHost.Size = new System.Drawing.Size(96, 16);
            this.xResolveHost.TabIndex = 3;
            this.xResolveHost.Text = "Resolve Host";
            this.xResolveHost.Transparent = false;
            // 
            // xCommaFix
            // 
            this.xCommaFix.Checked = false;
            this.xCommaFix.Customization = "wMDA/1VVVf+AgID/QEBA/83Nzf+goKD/Wlpa/35+fv9qamr/AAAA/w==";
            this.xCommaFix.Font = new System.Drawing.Font("Verdana", 8F);
            this.xCommaFix.Image = null;
            this.xCommaFix.Location = new System.Drawing.Point(145, 39);
            this.xCommaFix.Name = "xCommaFix";
            this.xCommaFix.NoRounding = false;
            this.xCommaFix.Size = new System.Drawing.Size(85, 16);
            this.xCommaFix.TabIndex = 2;
            this.xCommaFix.Text = "Comma Fix";
            this.xCommaFix.Transparent = false;
            // 
            // xTopMost
            // 
            this.xTopMost.Checked = false;
            this.xTopMost.Customization = "wMDA/1VVVf+AgID/QEBA/83Nzf+goKD/Wlpa/35+fv9qamr/AAAA/w==";
            this.xTopMost.Font = new System.Drawing.Font("Verdana", 8F);
            this.xTopMost.Image = null;
            this.xTopMost.Location = new System.Drawing.Point(43, 28);
            this.xTopMost.Name = "xTopMost";
            this.xTopMost.NoRounding = false;
            this.xTopMost.Size = new System.Drawing.Size(73, 16);
            this.xTopMost.TabIndex = 0;
            this.xTopMost.Text = "Top Most";
            this.xTopMost.Transparent = false;
            this.xTopMost.CheckedChanged += new CarbonCheckBox.CheckedChangedEventHandler(this.xTopMost_CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.Customization = "gICA/6mpqf/T09P/////AICAgP+pqan/aWlp/9PT0//AwMD/AAAA/6mpqf8=";
            this.btnStop.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnStop.Image = null;
            this.btnStop.Location = new System.Drawing.Point(463, 240);
            this.btnStop.Name = "btnStop";
            this.btnStop.NoRounding = false;
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 36;
            this.btnStop.Text = "Stop";
            this.btnStop.Transparent = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Customization = "gICA/6mpqf/T09P/////AICAgP+pqan/aWlp/9PT0//AwMD/AAAA/6mpqf8=";
            this.btnStart.Font = new System.Drawing.Font("Verdana", 8F);
            this.btnStart.Image = null;
            this.btnStart.Location = new System.Drawing.Point(463, 211);
            this.btnStart.Name = "btnStart";
            this.btnStart.NoRounding = false;
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 35;
            this.btnStart.Text = "Start";
            this.btnStart.Transparent = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(375, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Delay";
            // 
            // txtDelay
            // 
            this.txtDelay.Customization = "AAAA/+Dg4P+pqan/qamp/////wD///8A";
            this.txtDelay.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtDelay.Image = null;
            this.txtDelay.Location = new System.Drawing.Point(364, 151);
            this.txtDelay.MaxLength = 32767;
            this.txtDelay.Multiline = false;
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.NoRounding = false;
            this.txtDelay.NumbersOnly = true;
            this.txtDelay.ReadOnly = false;
            this.txtDelay.Size = new System.Drawing.Size(63, 24);
            this.txtDelay.TabIndex = 33;
            this.txtDelay.Text = "2.0";
            this.txtDelay.Transparent = false;
            this.txtDelay.UseSystemPasswordChar = false;
            // 
            // carbonSeperator1
            // 
            this.carbonSeperator1.Customization = "wMDA/+Dg4P8=";
            this.carbonSeperator1.Font = new System.Drawing.Font("Verdana", 8F);
            this.carbonSeperator1.Image = null;
            this.carbonSeperator1.Location = new System.Drawing.Point(11, 181);
            this.carbonSeperator1.Name = "carbonSeperator1";
            this.carbonSeperator1.NoRounding = false;
            this.carbonSeperator1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.carbonSeperator1.Size = new System.Drawing.Size(527, 14);
            this.carbonSeperator1.TabIndex = 32;
            this.carbonSeperator1.Text = "carbonSeperator1";
            this.carbonSeperator1.Transparent = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(301, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Packets";
            // 
            // txtPackets
            // 
            this.txtPackets.Customization = "AAAA/+Dg4P+pqan/qamp/////wD///8A";
            this.txtPackets.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtPackets.Image = null;
            this.txtPackets.Location = new System.Drawing.Point(295, 151);
            this.txtPackets.MaxLength = 32767;
            this.txtPackets.Multiline = false;
            this.txtPackets.Name = "txtPackets";
            this.txtPackets.NoRounding = false;
            this.txtPackets.NumbersOnly = true;
            this.txtPackets.ReadOnly = false;
            this.txtPackets.Size = new System.Drawing.Size(63, 24);
            this.txtPackets.TabIndex = 30;
            this.txtPackets.Text = "10";
            this.txtPackets.Transparent = false;
            this.txtPackets.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(231, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Sockets";
            // 
            // txtSockets
            // 
            this.txtSockets.Customization = "AAAA/+Dg4P+pqan/qamp/////wD///8A";
            this.txtSockets.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtSockets.Image = null;
            this.txtSockets.Location = new System.Drawing.Point(226, 151);
            this.txtSockets.MaxLength = 32767;
            this.txtSockets.Multiline = false;
            this.txtSockets.Name = "txtSockets";
            this.txtSockets.NoRounding = false;
            this.txtSockets.NumbersOnly = true;
            this.txtSockets.ReadOnly = false;
            this.txtSockets.Size = new System.Drawing.Size(63, 24);
            this.txtSockets.TabIndex = 28;
            this.txtSockets.Text = "100";
            this.txtSockets.Transparent = false;
            this.txtSockets.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(173, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Customization = "AAAA/+Dg4P+pqan/qamp/////wD///8A";
            this.txtPort.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtPort.Image = null;
            this.txtPort.Location = new System.Drawing.Point(157, 151);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Multiline = false;
            this.txtPort.Name = "txtPort";
            this.txtPort.NoRounding = false;
            this.txtPort.NumbersOnly = true;
            this.txtPort.ReadOnly = false;
            this.txtPort.Size = new System.Drawing.Size(63, 24);
            this.txtPort.TabIndex = 26;
            this.txtPort.Text = "80";
            this.txtPort.Transparent = false;
            this.txtPort.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(68, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Customization = "AAAA/+Dg4P+pqan/qamp/////wD///8A";
            this.txtHost.Font = new System.Drawing.Font("Verdana", 8F);
            this.txtHost.Image = null;
            this.txtHost.Location = new System.Drawing.Point(17, 151);
            this.txtHost.MaxLength = 32767;
            this.txtHost.Multiline = false;
            this.txtHost.Name = "txtHost";
            this.txtHost.NoRounding = false;
            this.txtHost.NumbersOnly = false;
            this.txtHost.ReadOnly = false;
            this.txtHost.Size = new System.Drawing.Size(134, 24);
            this.txtHost.TabIndex = 24;
            this.txtHost.Transparent = false;
            this.txtHost.UseSystemPasswordChar = false;
            // 
            // lstHosts
            // 
            this.lstHosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstHosts.ContextMenuStrip = this.menuMain;
            this.lstHosts.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstHosts.FullRowSelect = true;
            this.lstHosts.Location = new System.Drawing.Point(0, 0);
            this.lstHosts.Name = "lstHosts";
            this.lstHosts.Size = new System.Drawing.Size(548, 132);
            this.lstHosts.TabIndex = 0;
            this.lstHosts.UseCompatibleStateImageBehavior = false;
            this.lstHosts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Host";
            this.columnHeader1.Width = 114;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Port";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Sockets";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Packets";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 79;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Delay";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.Width = 89;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(118, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // MultiFloodPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 318);
            this.Controls.Add(this.carbonTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MultiFloodPanel";
            this.Text = "MultiFloodPanel";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.carbonTheme1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.carbonGroupBox2.ResumeLayout(false);
            this.carbonGroupBox2.PerformLayout();
            this.carbonGroupBox1.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CarbonTheme carbonTheme1;
        private System.Windows.Forms.Panel panel1;
        private NetLib.Forms.xListview lstHosts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmdType;
        private CarbonGroupBox carbonGroupBox2;
        private CarbonTextBox txtSecs;
        private System.Windows.Forms.Label label8;
        private CarbonTextBox txtMins;
        private System.Windows.Forms.Label label7;
        private CarbonTextBox txtHours;
        private System.Windows.Forms.Label label6;
        private CarbonCheckBox xTimer;
        private CarbonGroupBox carbonGroupBox1;
        private CarbonCheckBox xResolveHost;
        private CarbonCheckBox xCommaFix;
        private CarbonCheckBox xTopMost;
        private CarbonButton btnStop;
        private CarbonButton btnStart;
        private System.Windows.Forms.Label label5;
        private CarbonTextBox txtDelay;
        private CarbonSeperator carbonSeperator1;
        private System.Windows.Forms.Label label4;
        private CarbonTextBox txtPackets;
        private System.Windows.Forms.Label label3;
        private CarbonTextBox txtSockets;
        private System.Windows.Forms.Label label2;
        private CarbonTextBox txtPort;
        private System.Windows.Forms.Label label1;
        private CarbonTextBox txtHost;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    }
}