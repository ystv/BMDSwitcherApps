namespace SwitcherPanelCSharp
{
    partial class GraphicsControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSwitcherName = new System.Windows.Forms.TextBox();
            this.serialTally = new System.IO.Ports.SerialPort();
            this.btnFade = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFadeTime = new System.Windows.Forms.TextBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
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
            // btnFade
            // 
            this.btnFade.Enabled = false;
            this.btnFade.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFade.Location = new System.Drawing.Point(23, 93);
            this.btnFade.Name = "btnFade";
            this.btnFade.Size = new System.Drawing.Size(315, 134);
            this.btnFade.TabIndex = 5;
            this.btnFade.Text = "Fade In";
            this.btnFade.UseVisualStyleBackColor = true;
            this.btnFade.TextChanged += new System.EventHandler(this.textFadeTime_Validate);
            this.btnFade.Click += new System.EventHandler(this.btnFade_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 236);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(360, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsStatus
            // 
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(88, 17);
            this.tsStatus.Text = "Not Connected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Transition Time (seconds):";
            // 
            // txtFadeTime
            // 
            this.txtFadeTime.Location = new System.Drawing.Point(161, 70);
            this.txtFadeTime.Name = "txtFadeTime";
            this.txtFadeTime.Size = new System.Drawing.Size(100, 20);
            this.txtFadeTime.TabIndex = 8;
            this.txtFadeTime.TextChanged += new System.EventHandler(this.textFadeTime_Validate);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(268, 68);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 23);
            this.btnSet.TabIndex = 9;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // GraphicsControl
            // 
            this.AcceptButton = this.buttonConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 258);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.txtFadeTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnFade);
            this.Controls.Add(this.textBoxSwitcherName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.label1);
            this.Name = "GraphicsControl";
            this.Text = "Graphics Control";
            this.TopMost = true;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSwitcherName;
        private System.IO.Ports.SerialPort serialTally;
        private System.Windows.Forms.Button btnFade;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFadeTime;
        private System.Windows.Forms.Button btnSet;
    }
}

