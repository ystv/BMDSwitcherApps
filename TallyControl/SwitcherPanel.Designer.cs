namespace SwitcherPanelCSharp
{
    partial class TallyControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSwitcherName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.btnTallyConnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLampLabels = new System.Windows.Forms.Panel();
            this.lblLamp4 = new System.Windows.Forms.Label();
            this.lblLamp3 = new System.Windows.Forms.Label();
            this.lblLamp2 = new System.Windows.Forms.Label();
            this.lblLamp1 = new System.Windows.Forms.Label();
            this.pnlChannelDropDowns = new System.Windows.Forms.Panel();
            this.cmbTallyChannel4 = new System.Windows.Forms.ComboBox();
            this.cmbTallyChannel3 = new System.Windows.Forms.ComboBox();
            this.cmbTallyChannel2 = new System.Windows.Forms.ComboBox();
            this.cmbTallyChannel1 = new System.Windows.Forms.ComboBox();
            this.btnLampTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.serialTally = new System.IO.Ports.SerialPort(this.components);
            this.lblMessageHeader = new System.Windows.Forms.Label();
            this.pnlMessages = new System.Windows.Forms.Panel();
            this.lblMessageData = new System.Windows.Forms.Label();
            this.lblLamp8 = new System.Windows.Forms.Label();
            this.lblLamp7 = new System.Windows.Forms.Label();
            this.lblLamp6 = new System.Windows.Forms.Label();
            this.lblLamp5 = new System.Windows.Forms.Label();
            this.cmbTallyChannel8 = new System.Windows.Forms.ComboBox();
            this.cmbTallyChannel7 = new System.Windows.Forms.ComboBox();
            this.cmbTallyChannel6 = new System.Windows.Forms.ComboBox();
            this.cmbTallyChannel5 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.pnlLampLabels.SuspendLayout();
            this.pnlChannelDropDowns.SuspendLayout();
            this.pnlMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Switcher IP address:";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(122, 12);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(140, 20);
            this.textBoxIP.TabIndex = 1;
            this.textBoxIP.Text = "192.168.10.240";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(268, 10);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Switcher Name:";
            // 
            // textBoxSwitcherName
            // 
            this.textBoxSwitcherName.Location = new System.Drawing.Point(122, 38);
            this.textBoxSwitcherName.Name = "textBoxSwitcherName";
            this.textBoxSwitcherName.ReadOnly = true;
            this.textBoxSwitcherName.Size = new System.Drawing.Size(221, 20);
            this.textBoxSwitcherName.TabIndex = 4;
            this.textBoxSwitcherName.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tally Port:";
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(122, 78);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(140, 21);
            this.cmbPort.TabIndex = 3;
            // 
            // btnTallyConnect
            // 
            this.btnTallyConnect.Location = new System.Drawing.Point(268, 76);
            this.btnTallyConnect.Name = "btnTallyConnect";
            this.btnTallyConnect.Size = new System.Drawing.Size(75, 23);
            this.btnTallyConnect.TabIndex = 4;
            this.btnTallyConnect.Text = "Connect";
            this.btnTallyConnect.UseVisualStyleBackColor = true;
            this.btnTallyConnect.Click += new System.EventHandler(this.btnTallyConnect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlLampLabels);
            this.panel1.Controls.Add(this.pnlChannelDropDowns);
            this.panel1.Controls.Add(this.btnLampTest);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(15, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 141);
            this.panel1.TabIndex = 8;
            // 
            // pnlLampLabels
            // 
            this.pnlLampLabels.Controls.Add(this.lblLamp8);
            this.pnlLampLabels.Controls.Add(this.lblLamp7);
            this.pnlLampLabels.Controls.Add(this.lblLamp6);
            this.pnlLampLabels.Controls.Add(this.lblLamp5);
            this.pnlLampLabels.Controls.Add(this.lblLamp4);
            this.pnlLampLabels.Controls.Add(this.lblLamp3);
            this.pnlLampLabels.Controls.Add(this.lblLamp2);
            this.pnlLampLabels.Controls.Add(this.lblLamp1);
            this.pnlLampLabels.Location = new System.Drawing.Point(105, 7);
            this.pnlLampLabels.Name = "pnlLampLabels";
            this.pnlLampLabels.Size = new System.Drawing.Size(393, 37);
            this.pnlLampLabels.TabIndex = 11;
            // 
            // lblLamp4
            // 
            this.lblLamp4.AutoSize = true;
            this.lblLamp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamp4.Location = new System.Drawing.Point(164, 4);
            this.lblLamp4.Name = "lblLamp4";
            this.lblLamp4.Size = new System.Drawing.Size(20, 24);
            this.lblLamp4.TabIndex = 7;
            this.lblLamp4.Text = "4";
            // 
            // lblLamp3
            // 
            this.lblLamp3.AutoSize = true;
            this.lblLamp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamp3.Location = new System.Drawing.Point(116, 4);
            this.lblLamp3.Name = "lblLamp3";
            this.lblLamp3.Size = new System.Drawing.Size(20, 24);
            this.lblLamp3.TabIndex = 6;
            this.lblLamp3.Text = "3";
            // 
            // lblLamp2
            // 
            this.lblLamp2.AutoSize = true;
            this.lblLamp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamp2.Location = new System.Drawing.Point(66, 4);
            this.lblLamp2.Name = "lblLamp2";
            this.lblLamp2.Size = new System.Drawing.Size(20, 24);
            this.lblLamp2.TabIndex = 5;
            this.lblLamp2.Text = "2";
            // 
            // lblLamp1
            // 
            this.lblLamp1.AutoSize = true;
            this.lblLamp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamp1.Location = new System.Drawing.Point(16, 4);
            this.lblLamp1.Name = "lblLamp1";
            this.lblLamp1.Size = new System.Drawing.Size(20, 24);
            this.lblLamp1.TabIndex = 4;
            this.lblLamp1.Text = "1";
            // 
            // pnlChannelDropDowns
            // 
            this.pnlChannelDropDowns.Controls.Add(this.cmbTallyChannel8);
            this.pnlChannelDropDowns.Controls.Add(this.cmbTallyChannel7);
            this.pnlChannelDropDowns.Controls.Add(this.cmbTallyChannel6);
            this.pnlChannelDropDowns.Controls.Add(this.cmbTallyChannel5);
            this.pnlChannelDropDowns.Controls.Add(this.cmbTallyChannel4);
            this.pnlChannelDropDowns.Controls.Add(this.cmbTallyChannel3);
            this.pnlChannelDropDowns.Controls.Add(this.cmbTallyChannel2);
            this.pnlChannelDropDowns.Controls.Add(this.cmbTallyChannel1);
            this.pnlChannelDropDowns.Location = new System.Drawing.Point(107, 46);
            this.pnlChannelDropDowns.Name = "pnlChannelDropDowns";
            this.pnlChannelDropDowns.Size = new System.Drawing.Size(390, 32);
            this.pnlChannelDropDowns.TabIndex = 10;
            // 
            // cmbTallyChannel4
            // 
            this.cmbTallyChannel4.FormattingEnabled = true;
            this.cmbTallyChannel4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbTallyChannel4.Location = new System.Drawing.Point(155, 6);
            this.cmbTallyChannel4.Name = "cmbTallyChannel4";
            this.cmbTallyChannel4.Size = new System.Drawing.Size(32, 21);
            this.cmbTallyChannel4.TabIndex = 8;
            // 
            // cmbTallyChannel3
            // 
            this.cmbTallyChannel3.FormattingEnabled = true;
            this.cmbTallyChannel3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbTallyChannel3.Location = new System.Drawing.Point(106, 6);
            this.cmbTallyChannel3.Name = "cmbTallyChannel3";
            this.cmbTallyChannel3.Size = new System.Drawing.Size(32, 21);
            this.cmbTallyChannel3.TabIndex = 7;
            // 
            // cmbTallyChannel2
            // 
            this.cmbTallyChannel2.FormattingEnabled = true;
            this.cmbTallyChannel2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbTallyChannel2.Location = new System.Drawing.Point(56, 6);
            this.cmbTallyChannel2.Name = "cmbTallyChannel2";
            this.cmbTallyChannel2.Size = new System.Drawing.Size(32, 21);
            this.cmbTallyChannel2.TabIndex = 6;
            // 
            // cmbTallyChannel1
            // 
            this.cmbTallyChannel1.FormattingEnabled = true;
            this.cmbTallyChannel1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbTallyChannel1.Location = new System.Drawing.Point(6, 6);
            this.cmbTallyChannel1.Name = "cmbTallyChannel1";
            this.cmbTallyChannel1.Size = new System.Drawing.Size(32, 21);
            this.cmbTallyChannel1.TabIndex = 5;
            // 
            // btnLampTest
            // 
            this.btnLampTest.Location = new System.Drawing.Point(215, 101);
            this.btnLampTest.Name = "btnLampTest";
            this.btnLampTest.Size = new System.Drawing.Size(75, 23);
            this.btnLampTest.TabIndex = 13;
            this.btnLampTest.Text = "Lamp Test";
            this.btnLampTest.UseVisualStyleBackColor = true;
            this.btnLampTest.Click += new System.EventHandler(this.btnLampTest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Assigned Channel:";
            // 
            // lblMessageHeader
            // 
            this.lblMessageHeader.AutoSize = true;
            this.lblMessageHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageHeader.Location = new System.Drawing.Point(3, 5);
            this.lblMessageHeader.Name = "lblMessageHeader";
            this.lblMessageHeader.Size = new System.Drawing.Size(74, 13);
            this.lblMessageHeader.TabIndex = 9;
            this.lblMessageHeader.Text = "MESSAGES";
            // 
            // pnlMessages
            // 
            this.pnlMessages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessages.Controls.Add(this.lblMessageData);
            this.pnlMessages.Controls.Add(this.lblMessageHeader);
            this.pnlMessages.Location = new System.Drawing.Point(352, 10);
            this.pnlMessages.Name = "pnlMessages";
            this.pnlMessages.Size = new System.Drawing.Size(164, 89);
            this.pnlMessages.TabIndex = 10;
            // 
            // lblMessageData
            // 
            this.lblMessageData.AutoSize = true;
            this.lblMessageData.Location = new System.Drawing.Point(3, 21);
            this.lblMessageData.MaximumSize = new System.Drawing.Size(150, 60);
            this.lblMessageData.MinimumSize = new System.Drawing.Size(150, 60);
            this.lblMessageData.Name = "lblMessageData";
            this.lblMessageData.Size = new System.Drawing.Size(150, 60);
            this.lblMessageData.TabIndex = 10;
            this.lblMessageData.Text = "Hi!";
            // 
            // lblLamp8
            // 
            this.lblLamp8.AutoSize = true;
            this.lblLamp8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamp8.Location = new System.Drawing.Point(358, 4);
            this.lblLamp8.Name = "lblLamp8";
            this.lblLamp8.Size = new System.Drawing.Size(20, 24);
            this.lblLamp8.TabIndex = 11;
            this.lblLamp8.Text = "8";
            // 
            // lblLamp7
            // 
            this.lblLamp7.AutoSize = true;
            this.lblLamp7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamp7.Location = new System.Drawing.Point(310, 4);
            this.lblLamp7.Name = "lblLamp7";
            this.lblLamp7.Size = new System.Drawing.Size(20, 24);
            this.lblLamp7.TabIndex = 10;
            this.lblLamp7.Text = "7";
            // 
            // lblLamp6
            // 
            this.lblLamp6.AutoSize = true;
            this.lblLamp6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamp6.Location = new System.Drawing.Point(260, 4);
            this.lblLamp6.Name = "lblLamp6";
            this.lblLamp6.Size = new System.Drawing.Size(20, 24);
            this.lblLamp6.TabIndex = 9;
            this.lblLamp6.Text = "6";
            // 
            // lblLamp5
            // 
            this.lblLamp5.AutoSize = true;
            this.lblLamp5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamp5.Location = new System.Drawing.Point(212, 4);
            this.lblLamp5.Name = "lblLamp5";
            this.lblLamp5.Size = new System.Drawing.Size(20, 24);
            this.lblLamp5.TabIndex = 8;
            this.lblLamp5.Text = "5";
            // 
            // cmbTallyChannel8
            // 
            this.cmbTallyChannel8.FormattingEnabled = true;
            this.cmbTallyChannel8.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbTallyChannel8.Location = new System.Drawing.Point(353, 5);
            this.cmbTallyChannel8.Name = "cmbTallyChannel8";
            this.cmbTallyChannel8.Size = new System.Drawing.Size(32, 21);
            this.cmbTallyChannel8.TabIndex = 12;
            // 
            // cmbTallyChannel7
            // 
            this.cmbTallyChannel7.FormattingEnabled = true;
            this.cmbTallyChannel7.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbTallyChannel7.Location = new System.Drawing.Point(304, 5);
            this.cmbTallyChannel7.Name = "cmbTallyChannel7";
            this.cmbTallyChannel7.Size = new System.Drawing.Size(32, 21);
            this.cmbTallyChannel7.TabIndex = 11;
            // 
            // cmbTallyChannel6
            // 
            this.cmbTallyChannel6.FormattingEnabled = true;
            this.cmbTallyChannel6.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbTallyChannel6.Location = new System.Drawing.Point(254, 5);
            this.cmbTallyChannel6.Name = "cmbTallyChannel6";
            this.cmbTallyChannel6.Size = new System.Drawing.Size(32, 21);
            this.cmbTallyChannel6.TabIndex = 10;
            // 
            // cmbTallyChannel5
            // 
            this.cmbTallyChannel5.FormattingEnabled = true;
            this.cmbTallyChannel5.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbTallyChannel5.Location = new System.Drawing.Point(204, 5);
            this.cmbTallyChannel5.Name = "cmbTallyChannel5";
            this.cmbTallyChannel5.Size = new System.Drawing.Size(32, 21);
            this.cmbTallyChannel5.TabIndex = 9;
            // 
            // TallyControl
            // 
            this.AcceptButton = this.buttonConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 258);
            this.Controls.Add(this.pnlMessages);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTallyConnect);
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSwitcherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label1);
            this.Name = "TallyControl";
            this.Text = "Tally Control";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlLampLabels.ResumeLayout(false);
            this.pnlLampLabels.PerformLayout();
            this.pnlChannelDropDowns.ResumeLayout(false);
            this.pnlMessages.ResumeLayout(false);
            this.pnlMessages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSwitcherName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button btnTallyConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLampTest;
        private System.Windows.Forms.Label label4;
        private System.IO.Ports.SerialPort serialTally;
        private System.Windows.Forms.Panel pnlChannelDropDowns;
        private System.Windows.Forms.ComboBox cmbTallyChannel4;
        private System.Windows.Forms.ComboBox cmbTallyChannel3;
        private System.Windows.Forms.ComboBox cmbTallyChannel2;
        private System.Windows.Forms.ComboBox cmbTallyChannel1;
        private System.Windows.Forms.Panel pnlLampLabels;
        private System.Windows.Forms.Label lblLamp4;
        private System.Windows.Forms.Label lblLamp3;
        private System.Windows.Forms.Label lblLamp2;
        private System.Windows.Forms.Label lblLamp1;
        private System.Windows.Forms.Label lblMessageHeader;
        private System.Windows.Forms.Panel pnlMessages;
        private System.Windows.Forms.Label lblMessageData;
        private System.Windows.Forms.Label lblLamp8;
        private System.Windows.Forms.Label lblLamp7;
        private System.Windows.Forms.Label lblLamp6;
        private System.Windows.Forms.Label lblLamp5;
        private System.Windows.Forms.ComboBox cmbTallyChannel8;
        private System.Windows.Forms.ComboBox cmbTallyChannel7;
        private System.Windows.Forms.ComboBox cmbTallyChannel6;
        private System.Windows.Forms.ComboBox cmbTallyChannel5;
    }
}

