﻿namespace SwitcherPanelCSharp
{
    partial class SwitcherPanel
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
            this.btnLampTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTallyChannel4 = new System.Windows.Forms.ComboBox();
            this.cmbTallyChannel3 = new System.Windows.Forms.ComboBox();
            this.cmbTallyChannel2 = new System.Windows.Forms.ComboBox();
            this.cmbTallyChannel1 = new System.Windows.Forms.ComboBox();
            this.lblLamp4 = new System.Windows.Forms.Label();
            this.lblLamp3 = new System.Windows.Forms.Label();
            this.lblLamp2 = new System.Windows.Forms.Label();
            this.lblLamp1 = new System.Windows.Forms.Label();
            this.serialTally = new System.IO.Ports.SerialPort(this.components);
            this.panel1.SuspendLayout();
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
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(122, 78);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(140, 21);
            this.cmbPort.TabIndex = 6;
            // 
            // btnTallyConnect
            // 
            this.btnTallyConnect.Location = new System.Drawing.Point(268, 76);
            this.btnTallyConnect.Name = "btnTallyConnect";
            this.btnTallyConnect.Size = new System.Drawing.Size(75, 23);
            this.btnTallyConnect.TabIndex = 7;
            this.btnTallyConnect.Text = "Connect";
            this.btnTallyConnect.UseVisualStyleBackColor = true;
            this.btnTallyConnect.Click += new System.EventHandler(this.btnTallyConnect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLampTest);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbTallyChannel4);
            this.panel1.Controls.Add(this.cmbTallyChannel3);
            this.panel1.Controls.Add(this.cmbTallyChannel2);
            this.panel1.Controls.Add(this.cmbTallyChannel1);
            this.panel1.Controls.Add(this.lblLamp4);
            this.panel1.Controls.Add(this.lblLamp3);
            this.panel1.Controls.Add(this.lblLamp2);
            this.panel1.Controls.Add(this.lblLamp1);
            this.panel1.Location = new System.Drawing.Point(15, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 141);
            this.panel1.TabIndex = 8;
            // 
            // btnLampTest
            // 
            this.btnLampTest.Location = new System.Drawing.Point(215, 101);
            this.btnLampTest.Name = "btnLampTest";
            this.btnLampTest.Size = new System.Drawing.Size(75, 23);
            this.btnLampTest.TabIndex = 9;
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
            this.cmbTallyChannel4.Location = new System.Drawing.Point(264, 54);
            this.cmbTallyChannel4.Name = "cmbTallyChannel4";
            this.cmbTallyChannel4.Size = new System.Drawing.Size(32, 21);
            this.cmbTallyChannel4.TabIndex = 7;
            this.cmbTallyChannel4.SelectedIndexChanged += new System.EventHandler(this.cmbTallyChannel4_SelectedIndexChanged);
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
            this.cmbTallyChannel3.Location = new System.Drawing.Point(215, 54);
            this.cmbTallyChannel3.Name = "cmbTallyChannel3";
            this.cmbTallyChannel3.Size = new System.Drawing.Size(32, 21);
            this.cmbTallyChannel3.TabIndex = 6;
            this.cmbTallyChannel3.SelectedIndexChanged += new System.EventHandler(this.cmbTallyChannel3_SelectedIndexChanged);
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
            this.cmbTallyChannel2.Location = new System.Drawing.Point(165, 54);
            this.cmbTallyChannel2.Name = "cmbTallyChannel2";
            this.cmbTallyChannel2.Size = new System.Drawing.Size(32, 21);
            this.cmbTallyChannel2.TabIndex = 5;
            this.cmbTallyChannel2.SelectedIndexChanged += new System.EventHandler(this.cmbTallyChannel2_SelectedIndexChanged);
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
            this.cmbTallyChannel1.Location = new System.Drawing.Point(115, 54);
            this.cmbTallyChannel1.Name = "cmbTallyChannel1";
            this.cmbTallyChannel1.Size = new System.Drawing.Size(32, 21);
            this.cmbTallyChannel1.TabIndex = 4;
            this.cmbTallyChannel1.SelectedIndexChanged += new System.EventHandler(this.cmbTallyChannel1_SelectedIndexChanged);
            // 
            // lblLamp4
            // 
            this.lblLamp4.AutoSize = true;
            this.lblLamp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamp4.Location = new System.Drawing.Point(269, 19);
            this.lblLamp4.Name = "lblLamp4";
            this.lblLamp4.Size = new System.Drawing.Size(20, 24);
            this.lblLamp4.TabIndex = 3;
            this.lblLamp4.Text = "4";
            // 
            // lblLamp3
            // 
            this.lblLamp3.AutoSize = true;
            this.lblLamp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamp3.Location = new System.Drawing.Point(221, 19);
            this.lblLamp3.Name = "lblLamp3";
            this.lblLamp3.Size = new System.Drawing.Size(20, 24);
            this.lblLamp3.TabIndex = 2;
            this.lblLamp3.Text = "3";
            // 
            // lblLamp2
            // 
            this.lblLamp2.AutoSize = true;
            this.lblLamp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamp2.Location = new System.Drawing.Point(171, 19);
            this.lblLamp2.Name = "lblLamp2";
            this.lblLamp2.Size = new System.Drawing.Size(20, 24);
            this.lblLamp2.TabIndex = 1;
            this.lblLamp2.Text = "2";
            // 
            // lblLamp1
            // 
            this.lblLamp1.AutoSize = true;
            this.lblLamp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLamp1.Location = new System.Drawing.Point(121, 19);
            this.lblLamp1.Name = "lblLamp1";
            this.lblLamp1.Size = new System.Drawing.Size(20, 24);
            this.lblLamp1.TabIndex = 0;
            this.lblLamp1.Text = "1";
            this.lblLamp1.Click += new System.EventHandler(this.lblLamp1_Click);
            // 
            // SwitcherPanel
            // 
            this.AcceptButton = this.buttonConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 258);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTallyConnect);
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSwitcherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label1);
            this.Name = "SwitcherPanel";
            this.Text = "Switcher Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label lblLamp1;
        private System.Windows.Forms.Button btnLampTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTallyChannel4;
        private System.Windows.Forms.ComboBox cmbTallyChannel3;
        private System.Windows.Forms.ComboBox cmbTallyChannel2;
        private System.Windows.Forms.ComboBox cmbTallyChannel1;
        private System.Windows.Forms.Label lblLamp4;
        private System.Windows.Forms.Label lblLamp3;
        private System.Windows.Forms.Label lblLamp2;
        private System.IO.Ports.SerialPort serialTally;
    }
}
