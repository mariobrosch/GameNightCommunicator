namespace GameNightSerialCommunications
{
    partial class MainForm
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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.serialTeam1 = new System.IO.Ports.SerialPort(this.components);
            this.txtDataReceived = new System.Windows.Forms.TextBox();
            this.btnFault = new System.Windows.Forms.Button();
            this.btnGood = new System.Windows.Forms.Button();
            this.cboTeam1 = new System.Windows.Forms.ComboBox();
            this.cboTeam2 = new System.Windows.Forms.ComboBox();
            this.serialTeam2 = new System.IO.Ports.SerialPort(this.components);
            this.btnSerial1Open = new System.Windows.Forms.Button();
            this.btnSerial2Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(376, 12);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Verstuur";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(12, 14);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(358, 20);
            this.txtCommand.TabIndex = 0;
            // 
            // serialTeam1
            // 
            this.serialTeam1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txtDataReceived
            // 
            this.txtDataReceived.Location = new System.Drawing.Point(12, 279);
            this.txtDataReceived.Multiline = true;
            this.txtDataReceived.Name = "txtDataReceived";
            this.txtDataReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDataReceived.Size = new System.Drawing.Size(439, 147);
            this.txtDataReceived.TabIndex = 2;
            // 
            // btnFault
            // 
            this.btnFault.Location = new System.Drawing.Point(12, 40);
            this.btnFault.Name = "btnFault";
            this.btnFault.Size = new System.Drawing.Size(79, 23);
            this.btnFault.TabIndex = 3;
            this.btnFault.Text = "Fout signaal";
            this.btnFault.UseVisualStyleBackColor = true;
            this.btnFault.Click += new System.EventHandler(this.btnFault_Click);
            // 
            // btnGood
            // 
            this.btnGood.Location = new System.Drawing.Point(97, 40);
            this.btnGood.Name = "btnGood";
            this.btnGood.Size = new System.Drawing.Size(87, 23);
            this.btnGood.TabIndex = 4;
            this.btnGood.Text = "Goed signaal";
            this.btnGood.UseVisualStyleBackColor = true;
            this.btnGood.Click += new System.EventHandler(this.btnGood_Click);
            // 
            // cboTeam1
            // 
            this.cboTeam1.FormattingEnabled = true;
            this.cboTeam1.Location = new System.Drawing.Point(613, 12);
            this.cboTeam1.Name = "cboTeam1";
            this.cboTeam1.Size = new System.Drawing.Size(121, 21);
            this.cboTeam1.TabIndex = 5;
            // 
            // cboTeam2
            // 
            this.cboTeam2.FormattingEnabled = true;
            this.cboTeam2.Location = new System.Drawing.Point(613, 42);
            this.cboTeam2.Name = "cboTeam2";
            this.cboTeam2.Size = new System.Drawing.Size(121, 21);
            this.cboTeam2.TabIndex = 6;
            // 
            // serialTeam2
            // 
            this.serialTeam2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialTeam2_DataReceived);
            // 
            // btnSerial1Open
            // 
            this.btnSerial1Open.Location = new System.Drawing.Point(740, 10);
            this.btnSerial1Open.Name = "btnSerial1Open";
            this.btnSerial1Open.Size = new System.Drawing.Size(48, 23);
            this.btnSerial1Open.TabIndex = 7;
            this.btnSerial1Open.Text = "Open";
            this.btnSerial1Open.UseVisualStyleBackColor = true;
            this.btnSerial1Open.Click += new System.EventHandler(this.btnSerial1Open_Click);
            // 
            // btnSerial2Open
            // 
            this.btnSerial2Open.Location = new System.Drawing.Point(740, 41);
            this.btnSerial2Open.Name = "btnSerial2Open";
            this.btnSerial2Open.Size = new System.Drawing.Size(48, 23);
            this.btnSerial2Open.TabIndex = 8;
            this.btnSerial2Open.Text = "Open";
            this.btnSerial2Open.UseVisualStyleBackColor = true;
            this.btnSerial2Open.Click += new System.EventHandler(this.btnSerial2Open_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSerial2Open);
            this.Controls.Add(this.btnSerial1Open);
            this.Controls.Add(this.cboTeam2);
            this.Controls.Add(this.cboTeam1);
            this.Controls.Add(this.btnGood);
            this.Controls.Add(this.btnFault);
            this.Controls.Add(this.txtDataReceived);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnSend);
            this.Name = "MainForm";
            this.Text = "Family Game Night Communicator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtCommand;
        private System.IO.Ports.SerialPort serialTeam1;
        private System.Windows.Forms.TextBox txtDataReceived;
        private System.Windows.Forms.Button btnFault;
        private System.Windows.Forms.Button btnGood;
        private System.Windows.Forms.ComboBox cboTeam1;
        private System.Windows.Forms.ComboBox cboTeam2;
        private System.IO.Ports.SerialPort serialTeam2;
        private System.Windows.Forms.Button btnSerial1Open;
        private System.Windows.Forms.Button btnSerial2Open;
    }
}

