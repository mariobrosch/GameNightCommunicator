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
            this.btnSendAll = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.serialTeam1 = new System.IO.Ports.SerialPort(this.components);
            this.btnFault1 = new System.Windows.Forms.Button();
            this.btnGood1 = new System.Windows.Forms.Button();
            this.cboTeam1 = new System.Windows.Forms.ComboBox();
            this.cboTeam2 = new System.Windows.Forms.ComboBox();
            this.serialTeam2 = new System.IO.Ports.SerialPort(this.components);
            this.btnSerial1Open = new System.Windows.Forms.Button();
            this.btnSerial2Open = new System.Windows.Forms.Button();
            this.txtLastAnswerTeam1 = new System.Windows.Forms.TextBox();
            this.lblLastAnswerTeam1 = new System.Windows.Forms.Label();
            this.pnlTeam1 = new System.Windows.Forms.Panel();
            this.lblComPort1 = new System.Windows.Forms.Label();
            this.pnlTeam2 = new System.Windows.Forms.Panel();
            this.lblComPort2 = new System.Windows.Forms.Label();
            this.txtLastAnswerTeam2 = new System.Windows.Forms.TextBox();
            this.lblLastAnswerTeam2 = new System.Windows.Forms.Label();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.btnGood2 = new System.Windows.Forms.Button();
            this.btnFault2 = new System.Windows.Forms.Button();
            this.btnGoodAll = new System.Windows.Forms.Button();
            this.btnFaultAll = new System.Windows.Forms.Button();
            this.txtTimeSinceSet1 = new System.Windows.Forms.TextBox();
            this.txtTimeSinceSet2 = new System.Windows.Forms.TextBox();
            this.lblTimeSinceSet1 = new System.Windows.Forms.Label();
            this.lblTimeSinceSet2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnSendScores = new System.Windows.Forms.Button();
            this.pnlTeam1.SuspendLayout();
            this.pnlTeam2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSendAll
            // 
            this.btnSendAll.Location = new System.Drawing.Point(376, 12);
            this.btnSendAll.Name = "btnSendAll";
            this.btnSendAll.Size = new System.Drawing.Size(112, 23);
            this.btnSendAll.TabIndex = 1;
            this.btnSendAll.Text = "Naar alle teams";
            this.btnSendAll.UseVisualStyleBackColor = true;
            this.btnSendAll.Click += new System.EventHandler(this.btnSendAll_Click);
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
            // btnFault1
            // 
            this.btnFault1.Location = new System.Drawing.Point(494, 41);
            this.btnFault1.Name = "btnFault1";
            this.btnFault1.Size = new System.Drawing.Size(112, 23);
            this.btnFault1.TabIndex = 3;
            this.btnFault1.Text = "Fout signaal";
            this.btnFault1.UseVisualStyleBackColor = true;
            this.btnFault1.Click += new System.EventHandler(this.btnFault1_Click);
            // 
            // btnGood1
            // 
            this.btnGood1.Location = new System.Drawing.Point(494, 70);
            this.btnGood1.Name = "btnGood1";
            this.btnGood1.Size = new System.Drawing.Size(111, 23);
            this.btnGood1.TabIndex = 4;
            this.btnGood1.Text = "Goed signaal";
            this.btnGood1.UseVisualStyleBackColor = true;
            this.btnGood1.Click += new System.EventHandler(this.btnGood1_Click);
            // 
            // cboTeam1
            // 
            this.cboTeam1.FormattingEnabled = true;
            this.cboTeam1.Location = new System.Drawing.Point(85, 236);
            this.cboTeam1.Name = "cboTeam1";
            this.cboTeam1.Size = new System.Drawing.Size(121, 21);
            this.cboTeam1.TabIndex = 5;
            // 
            // cboTeam2
            // 
            this.cboTeam2.FormattingEnabled = true;
            this.cboTeam2.Location = new System.Drawing.Point(96, 236);
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
            this.btnSerial1Open.Location = new System.Drawing.Point(212, 234);
            this.btnSerial1Open.Name = "btnSerial1Open";
            this.btnSerial1Open.Size = new System.Drawing.Size(48, 23);
            this.btnSerial1Open.TabIndex = 7;
            this.btnSerial1Open.Text = "Open";
            this.btnSerial1Open.UseVisualStyleBackColor = true;
            this.btnSerial1Open.Click += new System.EventHandler(this.btnSerial1Open_Click);
            // 
            // btnSerial2Open
            // 
            this.btnSerial2Open.Location = new System.Drawing.Point(223, 234);
            this.btnSerial2Open.Name = "btnSerial2Open";
            this.btnSerial2Open.Size = new System.Drawing.Size(48, 23);
            this.btnSerial2Open.TabIndex = 8;
            this.btnSerial2Open.Text = "Open";
            this.btnSerial2Open.UseVisualStyleBackColor = true;
            this.btnSerial2Open.Click += new System.EventHandler(this.btnSerial2Open_Click);
            // 
            // txtLastAnswerTeam1
            // 
            this.txtLastAnswerTeam1.Location = new System.Drawing.Point(16, 25);
            this.txtLastAnswerTeam1.Name = "txtLastAnswerTeam1";
            this.txtLastAnswerTeam1.Size = new System.Drawing.Size(285, 20);
            this.txtLastAnswerTeam1.TabIndex = 10;
            // 
            // lblLastAnswerTeam1
            // 
            this.lblLastAnswerTeam1.AutoSize = true;
            this.lblLastAnswerTeam1.Location = new System.Drawing.Point(13, 9);
            this.lblLastAnswerTeam1.Name = "lblLastAnswerTeam1";
            this.lblLastAnswerTeam1.Size = new System.Drawing.Size(124, 13);
            this.lblLastAnswerTeam1.TabIndex = 12;
            this.lblLastAnswerTeam1.Text = "Laatste antwoord team 1";
            // 
            // pnlTeam1
            // 
            this.pnlTeam1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTeam1.Controls.Add(this.lblTimeSinceSet1);
            this.pnlTeam1.Controls.Add(this.txtTimeSinceSet1);
            this.pnlTeam1.Controls.Add(this.lblComPort1);
            this.pnlTeam1.Controls.Add(this.txtLastAnswerTeam1);
            this.pnlTeam1.Controls.Add(this.lblLastAnswerTeam1);
            this.pnlTeam1.Controls.Add(this.cboTeam1);
            this.pnlTeam1.Controls.Add(this.btnSerial1Open);
            this.pnlTeam1.Location = new System.Drawing.Point(12, 170);
            this.pnlTeam1.Name = "pnlTeam1";
            this.pnlTeam1.Size = new System.Drawing.Size(343, 268);
            this.pnlTeam1.TabIndex = 13;
            // 
            // lblComPort1
            // 
            this.lblComPort1.AutoSize = true;
            this.lblComPort1.Location = new System.Drawing.Point(3, 239);
            this.lblComPort1.Name = "lblComPort1";
            this.lblComPort1.Size = new System.Drawing.Size(78, 13);
            this.lblComPort1.TabIndex = 14;
            this.lblComPort1.Text = "Verbind team 1";
            // 
            // pnlTeam2
            // 
            this.pnlTeam2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTeam2.Controls.Add(this.lblTimeSinceSet2);
            this.pnlTeam2.Controls.Add(this.txtTimeSinceSet2);
            this.pnlTeam2.Controls.Add(this.lblComPort2);
            this.pnlTeam2.Controls.Add(this.txtLastAnswerTeam2);
            this.pnlTeam2.Controls.Add(this.lblLastAnswerTeam2);
            this.pnlTeam2.Controls.Add(this.cboTeam2);
            this.pnlTeam2.Controls.Add(this.btnSerial2Open);
            this.pnlTeam2.Location = new System.Drawing.Point(381, 170);
            this.pnlTeam2.Name = "pnlTeam2";
            this.pnlTeam2.Size = new System.Drawing.Size(343, 268);
            this.pnlTeam2.TabIndex = 14;
            // 
            // lblComPort2
            // 
            this.lblComPort2.AutoSize = true;
            this.lblComPort2.Location = new System.Drawing.Point(12, 239);
            this.lblComPort2.Name = "lblComPort2";
            this.lblComPort2.Size = new System.Drawing.Size(78, 13);
            this.lblComPort2.TabIndex = 13;
            this.lblComPort2.Text = "Verbind team 2";
            // 
            // txtLastAnswerTeam2
            // 
            this.txtLastAnswerTeam2.Location = new System.Drawing.Point(16, 25);
            this.txtLastAnswerTeam2.Name = "txtLastAnswerTeam2";
            this.txtLastAnswerTeam2.Size = new System.Drawing.Size(285, 20);
            this.txtLastAnswerTeam2.TabIndex = 10;
            // 
            // lblLastAnswerTeam2
            // 
            this.lblLastAnswerTeam2.AutoSize = true;
            this.lblLastAnswerTeam2.Location = new System.Drawing.Point(13, 9);
            this.lblLastAnswerTeam2.Name = "lblLastAnswerTeam2";
            this.lblLastAnswerTeam2.Size = new System.Drawing.Size(124, 13);
            this.lblLastAnswerTeam2.TabIndex = 12;
            this.lblLastAnswerTeam2.Text = "Laatste antwoord team 2";
            // 
            // btnSend2
            // 
            this.btnSend2.Location = new System.Drawing.Point(612, 12);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(112, 23);
            this.btnSend2.TabIndex = 15;
            this.btnSend2.Text = "Naar team 2";
            this.btnSend2.UseVisualStyleBackColor = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // btnSend1
            // 
            this.btnSend1.Location = new System.Drawing.Point(494, 12);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(112, 23);
            this.btnSend1.TabIndex = 16;
            this.btnSend1.Text = "Naar team 1";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            // 
            // btnGood2
            // 
            this.btnGood2.Location = new System.Drawing.Point(612, 70);
            this.btnGood2.Name = "btnGood2";
            this.btnGood2.Size = new System.Drawing.Size(112, 23);
            this.btnGood2.TabIndex = 16;
            this.btnGood2.Text = "Goed signaal";
            this.btnGood2.UseVisualStyleBackColor = true;
            this.btnGood2.Click += new System.EventHandler(this.btnGood2_Click);
            // 
            // btnFault2
            // 
            this.btnFault2.Location = new System.Drawing.Point(612, 41);
            this.btnFault2.Name = "btnFault2";
            this.btnFault2.Size = new System.Drawing.Size(112, 23);
            this.btnFault2.TabIndex = 15;
            this.btnFault2.Text = "Fout signaal";
            this.btnFault2.UseVisualStyleBackColor = true;
            this.btnFault2.Click += new System.EventHandler(this.btnFault2_Click);
            // 
            // btnGoodAll
            // 
            this.btnGoodAll.Location = new System.Drawing.Point(376, 70);
            this.btnGoodAll.Name = "btnGoodAll";
            this.btnGoodAll.Size = new System.Drawing.Size(111, 23);
            this.btnGoodAll.TabIndex = 18;
            this.btnGoodAll.Text = "Goed signaal";
            this.btnGoodAll.UseVisualStyleBackColor = true;
            this.btnGoodAll.Click += new System.EventHandler(this.btnGoodAll_Click);
            // 
            // btnFaultAll
            // 
            this.btnFaultAll.Location = new System.Drawing.Point(376, 41);
            this.btnFaultAll.Name = "btnFaultAll";
            this.btnFaultAll.Size = new System.Drawing.Size(112, 23);
            this.btnFaultAll.TabIndex = 17;
            this.btnFaultAll.Text = "Fout signaal";
            this.btnFaultAll.UseVisualStyleBackColor = true;
            this.btnFaultAll.Click += new System.EventHandler(this.btnFaultAll_Click);
            // 
            // txtTimeSinceSet1
            // 
            this.txtTimeSinceSet1.Location = new System.Drawing.Point(16, 75);
            this.txtTimeSinceSet1.Name = "txtTimeSinceSet1";
            this.txtTimeSinceSet1.Size = new System.Drawing.Size(285, 20);
            this.txtTimeSinceSet1.TabIndex = 15;
            // 
            // txtTimeSinceSet2
            // 
            this.txtTimeSinceSet2.Location = new System.Drawing.Point(16, 75);
            this.txtTimeSinceSet2.Name = "txtTimeSinceSet2";
            this.txtTimeSinceSet2.Size = new System.Drawing.Size(285, 20);
            this.txtTimeSinceSet2.TabIndex = 16;
            // 
            // lblTimeSinceSet1
            // 
            this.lblTimeSinceSet1.AutoSize = true;
            this.lblTimeSinceSet1.Location = new System.Drawing.Point(16, 56);
            this.lblTimeSinceSet1.Name = "lblTimeSinceSet1";
            this.lblTimeSinceSet1.Size = new System.Drawing.Size(195, 13);
            this.lblTimeSinceSet1.TabIndex = 16;
            this.lblTimeSinceSet1.Text = "Tijd sinds start knop en eerste antwoord";
            // 
            // lblTimeSinceSet2
            // 
            this.lblTimeSinceSet2.AutoSize = true;
            this.lblTimeSinceSet2.Location = new System.Drawing.Point(13, 56);
            this.lblTimeSinceSet2.Name = "lblTimeSinceSet2";
            this.lblTimeSinceSet2.Size = new System.Drawing.Size(195, 13);
            this.lblTimeSinceSet2.TabIndex = 17;
            this.lblTimeSinceSet2.Text = "Tijd sinds start knop en eerste antwoord";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(12, 99);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(75, 23);
            this.btnStartTimer.TabIndex = 20;
            this.btnStartTimer.Text = "Start timer";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnSendScores
            // 
            this.btnSendScores.Location = new System.Drawing.Point(99, 99);
            this.btnSendScores.Name = "btnSendScores";
            this.btnSendScores.Size = new System.Drawing.Size(89, 23);
            this.btnSendScores.TabIndex = 21;
            this.btnSendScores.Text = "Verstuur scores";
            this.btnSendScores.UseVisualStyleBackColor = true;
            this.btnSendScores.Click += new System.EventHandler(this.btnSendScores_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSendAll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.btnSendScores);
            this.Controls.Add(this.btnStartTimer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGoodAll);
            this.Controls.Add(this.btnFaultAll);
            this.Controls.Add(this.btnGood2);
            this.Controls.Add(this.btnSend1);
            this.Controls.Add(this.btnSend2);
            this.Controls.Add(this.btnFault2);
            this.Controls.Add(this.pnlTeam2);
            this.Controls.Add(this.pnlTeam1);
            this.Controls.Add(this.btnGood1);
            this.Controls.Add(this.txtCommand);
            this.Controls.Add(this.btnSendAll);
            this.Controls.Add(this.btnFault1);
            this.Name = "MainForm";
            this.Text = "Family Game Night Communicator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.pnlTeam1.ResumeLayout(false);
            this.pnlTeam1.PerformLayout();
            this.pnlTeam2.ResumeLayout(false);
            this.pnlTeam2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendAll;
        private System.Windows.Forms.TextBox txtCommand;
        private System.IO.Ports.SerialPort serialTeam1;
        private System.Windows.Forms.Button btnFault1;
        private System.Windows.Forms.Button btnGood1;
        private System.Windows.Forms.ComboBox cboTeam1;
        private System.Windows.Forms.ComboBox cboTeam2;
        private System.IO.Ports.SerialPort serialTeam2;
        private System.Windows.Forms.Button btnSerial1Open;
        private System.Windows.Forms.Button btnSerial2Open;
        private System.Windows.Forms.TextBox txtLastAnswerTeam1;
        private System.Windows.Forms.Label lblLastAnswerTeam1;
        private System.Windows.Forms.Panel pnlTeam1;
        private System.Windows.Forms.Label lblComPort1;
        private System.Windows.Forms.Panel pnlTeam2;
        private System.Windows.Forms.Label lblComPort2;
        private System.Windows.Forms.TextBox txtLastAnswerTeam2;
        private System.Windows.Forms.Label lblLastAnswerTeam2;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Button btnGood2;
        private System.Windows.Forms.Button btnFault2;
        private System.Windows.Forms.Button btnGoodAll;
        private System.Windows.Forms.Button btnFaultAll;
        private System.Windows.Forms.Label lblTimeSinceSet1;
        private System.Windows.Forms.TextBox txtTimeSinceSet1;
        private System.Windows.Forms.Label lblTimeSinceSet2;
        private System.Windows.Forms.TextBox txtTimeSinceSet2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnSendScores;
    }
}

