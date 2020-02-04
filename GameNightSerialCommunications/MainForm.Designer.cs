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
            this.txtTimeSinceSet1ms = new System.Windows.Forms.TextBox();
            this.txtTeamName1 = new System.Windows.Forms.TextBox();
            this.lblTeamName1 = new System.Windows.Forms.Label();
            this.btnAdd12 = new System.Windows.Forms.Button();
            this.btnAdd14 = new System.Windows.Forms.Button();
            this.btnAdd13 = new System.Windows.Forms.Button();
            this.chkFastest1 = new System.Windows.Forms.CheckBox();
            this.lblScore1 = new System.Windows.Forms.Label();
            this.btnAdd15 = new System.Windows.Forms.Button();
            this.numScore1 = new System.Windows.Forms.NumericUpDown();
            this.btnAdd11 = new System.Windows.Forms.Button();
            this.lblTimeSinceSet1 = new System.Windows.Forms.Label();
            this.txtTimeSinceSet1 = new System.Windows.Forms.TextBox();
            this.lblComPort1 = new System.Windows.Forms.Label();
            this.pnlTeam2 = new System.Windows.Forms.Panel();
            this.txtTimeSinceSet2ms = new System.Windows.Forms.TextBox();
            this.txtTeamName2 = new System.Windows.Forms.TextBox();
            this.lblTeamName2 = new System.Windows.Forms.Label();
            this.btnAdd22 = new System.Windows.Forms.Button();
            this.btnAdd23 = new System.Windows.Forms.Button();
            this.btnAdd24 = new System.Windows.Forms.Button();
            this.chkFastest2 = new System.Windows.Forms.CheckBox();
            this.lblScore2 = new System.Windows.Forms.Label();
            this.btnAdd25 = new System.Windows.Forms.Button();
            this.lblTimeSinceSet2 = new System.Windows.Forms.Label();
            this.numScore2 = new System.Windows.Forms.NumericUpDown();
            this.btnAdd21 = new System.Windows.Forms.Button();
            this.txtTimeSinceSet2 = new System.Windows.Forms.TextBox();
            this.lblComPort2 = new System.Windows.Forms.Label();
            this.txtLastAnswerTeam2 = new System.Windows.Forms.TextBox();
            this.lblLastAnswerTeam2 = new System.Windows.Forms.Label();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.btnGood2 = new System.Windows.Forms.Button();
            this.btnFault2 = new System.Windows.Forms.Button();
            this.btnGoodAll = new System.Windows.Forms.Button();
            this.btnFaultAll = new System.Windows.Forms.Button();
            this.btnStartTimer = new System.Windows.Forms.Button();
            this.btnSendScores = new System.Windows.Forms.Button();
            this.btnSaveSession = new System.Windows.Forms.Button();
            this.sfdSaveSession = new System.Windows.Forms.SaveFileDialog();
            this.btnSessionLoad = new System.Windows.Forms.Button();
            this.ofdSessionLoad = new System.Windows.Forms.OpenFileDialog();
            this.lblStatusLabel = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblQuestionLabel = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.chkFastest = new System.Windows.Forms.CheckBox();
            this.btnToSqlServer = new System.Windows.Forms.Button();
            this.pbLoader = new System.Windows.Forms.PictureBox();
            this.pnlTeam1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScore1)).BeginInit();
            this.pnlTeam2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScore2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoader)).BeginInit();
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
            this.cboTeam1.Location = new System.Drawing.Point(116, 236);
            this.cboTeam1.Name = "cboTeam1";
            this.cboTeam1.Size = new System.Drawing.Size(121, 21);
            this.cboTeam1.TabIndex = 5;
            // 
            // cboTeam2
            // 
            this.cboTeam2.FormattingEnabled = true;
            this.cboTeam2.Location = new System.Drawing.Point(111, 236);
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
            this.btnSerial1Open.Location = new System.Drawing.Point(243, 235);
            this.btnSerial1Open.Name = "btnSerial1Open";
            this.btnSerial1Open.Size = new System.Drawing.Size(48, 23);
            this.btnSerial1Open.TabIndex = 7;
            this.btnSerial1Open.Text = "Open";
            this.btnSerial1Open.UseVisualStyleBackColor = true;
            this.btnSerial1Open.Click += new System.EventHandler(this.btnSerial1Open_Click);
            // 
            // btnSerial2Open
            // 
            this.btnSerial2Open.Location = new System.Drawing.Point(238, 235);
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
            this.pnlTeam1.Controls.Add(this.txtTimeSinceSet1ms);
            this.pnlTeam1.Controls.Add(this.txtTeamName1);
            this.pnlTeam1.Controls.Add(this.lblTeamName1);
            this.pnlTeam1.Controls.Add(this.btnAdd12);
            this.pnlTeam1.Controls.Add(this.btnAdd14);
            this.pnlTeam1.Controls.Add(this.btnAdd13);
            this.pnlTeam1.Controls.Add(this.chkFastest1);
            this.pnlTeam1.Controls.Add(this.lblScore1);
            this.pnlTeam1.Controls.Add(this.btnAdd15);
            this.pnlTeam1.Controls.Add(this.numScore1);
            this.pnlTeam1.Controls.Add(this.btnAdd11);
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
            // txtTimeSinceSet1ms
            // 
            this.txtTimeSinceSet1ms.Location = new System.Drawing.Point(326, 75);
            this.txtTimeSinceSet1ms.Name = "txtTimeSinceSet1ms";
            this.txtTimeSinceSet1ms.Size = new System.Drawing.Size(10, 20);
            this.txtTimeSinceSet1ms.TabIndex = 26;
            this.txtTimeSinceSet1ms.Visible = false;
            // 
            // txtTeamName1
            // 
            this.txtTeamName1.Location = new System.Drawing.Point(116, 210);
            this.txtTeamName1.MaxLength = 8;
            this.txtTeamName1.Name = "txtTeamName1";
            this.txtTeamName1.Size = new System.Drawing.Size(121, 20);
            this.txtTeamName1.TabIndex = 25;
            this.txtTeamName1.TextChanged += new System.EventHandler(this.txtTeamName_TextChanged);
            // 
            // lblTeamName1
            // 
            this.lblTeamName1.AutoSize = true;
            this.lblTeamName1.Location = new System.Drawing.Point(13, 213);
            this.lblTeamName1.Name = "lblTeamName1";
            this.lblTeamName1.Size = new System.Drawing.Size(97, 13);
            this.lblTeamName1.TabIndex = 24;
            this.lblTeamName1.Text = "Teamnaam (max 8)";
            // 
            // btnAdd12
            // 
            this.btnAdd12.Location = new System.Drawing.Point(79, 145);
            this.btnAdd12.Name = "btnAdd12";
            this.btnAdd12.Size = new System.Drawing.Size(57, 23);
            this.btnAdd12.TabIndex = 23;
            this.btnAdd12.Text = "+2";
            this.btnAdd12.UseVisualStyleBackColor = true;
            this.btnAdd12.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd14
            // 
            this.btnAdd14.Location = new System.Drawing.Point(205, 145);
            this.btnAdd14.Name = "btnAdd14";
            this.btnAdd14.Size = new System.Drawing.Size(57, 23);
            this.btnAdd14.TabIndex = 22;
            this.btnAdd14.Text = "+4";
            this.btnAdd14.UseVisualStyleBackColor = true;
            this.btnAdd14.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd13
            // 
            this.btnAdd13.Location = new System.Drawing.Point(142, 145);
            this.btnAdd13.Name = "btnAdd13";
            this.btnAdd13.Size = new System.Drawing.Size(57, 23);
            this.btnAdd13.TabIndex = 21;
            this.btnAdd13.Text = "+3";
            this.btnAdd13.UseVisualStyleBackColor = true;
            this.btnAdd13.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkFastest1
            // 
            this.chkFastest1.AutoSize = true;
            this.chkFastest1.Location = new System.Drawing.Point(307, 78);
            this.chkFastest1.Name = "chkFastest1";
            this.chkFastest1.Size = new System.Drawing.Size(15, 14);
            this.chkFastest1.TabIndex = 20;
            this.chkFastest1.UseVisualStyleBackColor = true;
            // 
            // lblScore1
            // 
            this.lblScore1.AutoSize = true;
            this.lblScore1.Location = new System.Drawing.Point(13, 103);
            this.lblScore1.Name = "lblScore1";
            this.lblScore1.Size = new System.Drawing.Size(35, 13);
            this.lblScore1.TabIndex = 19;
            this.lblScore1.Text = "Score";
            // 
            // btnAdd15
            // 
            this.btnAdd15.Location = new System.Drawing.Point(268, 145);
            this.btnAdd15.Name = "btnAdd15";
            this.btnAdd15.Size = new System.Drawing.Size(57, 23);
            this.btnAdd15.TabIndex = 18;
            this.btnAdd15.Text = "+5";
            this.btnAdd15.UseVisualStyleBackColor = true;
            this.btnAdd15.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // numScore1
            // 
            this.numScore1.Location = new System.Drawing.Point(16, 119);
            this.numScore1.Name = "numScore1";
            this.numScore1.ReadOnly = true;
            this.numScore1.Size = new System.Drawing.Size(120, 20);
            this.numScore1.TabIndex = 18;
            // 
            // btnAdd11
            // 
            this.btnAdd11.Location = new System.Drawing.Point(16, 145);
            this.btnAdd11.Name = "btnAdd11";
            this.btnAdd11.Size = new System.Drawing.Size(57, 23);
            this.btnAdd11.TabIndex = 17;
            this.btnAdd11.Text = "+1";
            this.btnAdd11.UseVisualStyleBackColor = true;
            this.btnAdd11.Click += new System.EventHandler(this.btnAdd_Click);
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
            // txtTimeSinceSet1
            // 
            this.txtTimeSinceSet1.Location = new System.Drawing.Point(16, 75);
            this.txtTimeSinceSet1.Name = "txtTimeSinceSet1";
            this.txtTimeSinceSet1.Size = new System.Drawing.Size(285, 20);
            this.txtTimeSinceSet1.TabIndex = 15;
            // 
            // lblComPort1
            // 
            this.lblComPort1.AutoSize = true;
            this.lblComPort1.Location = new System.Drawing.Point(13, 239);
            this.lblComPort1.Name = "lblComPort1";
            this.lblComPort1.Size = new System.Drawing.Size(78, 13);
            this.lblComPort1.TabIndex = 14;
            this.lblComPort1.Text = "Verbind team 1";
            // 
            // pnlTeam2
            // 
            this.pnlTeam2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTeam2.Controls.Add(this.txtTimeSinceSet2ms);
            this.pnlTeam2.Controls.Add(this.txtTeamName2);
            this.pnlTeam2.Controls.Add(this.lblTeamName2);
            this.pnlTeam2.Controls.Add(this.btnAdd22);
            this.pnlTeam2.Controls.Add(this.btnAdd23);
            this.pnlTeam2.Controls.Add(this.btnAdd24);
            this.pnlTeam2.Controls.Add(this.chkFastest2);
            this.pnlTeam2.Controls.Add(this.lblScore2);
            this.pnlTeam2.Controls.Add(this.btnAdd25);
            this.pnlTeam2.Controls.Add(this.lblTimeSinceSet2);
            this.pnlTeam2.Controls.Add(this.numScore2);
            this.pnlTeam2.Controls.Add(this.btnAdd21);
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
            // txtTimeSinceSet2ms
            // 
            this.txtTimeSinceSet2ms.Location = new System.Drawing.Point(326, 75);
            this.txtTimeSinceSet2ms.Name = "txtTimeSinceSet2ms";
            this.txtTimeSinceSet2ms.Size = new System.Drawing.Size(10, 20);
            this.txtTimeSinceSet2ms.TabIndex = 27;
            this.txtTimeSinceSet2ms.Visible = false;
            // 
            // txtTeamName2
            // 
            this.txtTeamName2.Location = new System.Drawing.Point(111, 209);
            this.txtTeamName2.MaxLength = 8;
            this.txtTeamName2.Name = "txtTeamName2";
            this.txtTeamName2.Size = new System.Drawing.Size(121, 20);
            this.txtTeamName2.TabIndex = 27;
            this.txtTeamName2.TextChanged += new System.EventHandler(this.txtTeamName_TextChanged);
            // 
            // lblTeamName2
            // 
            this.lblTeamName2.AutoSize = true;
            this.lblTeamName2.Location = new System.Drawing.Point(13, 213);
            this.lblTeamName2.Name = "lblTeamName2";
            this.lblTeamName2.Size = new System.Drawing.Size(97, 13);
            this.lblTeamName2.TabIndex = 26;
            this.lblTeamName2.Text = "Teamnaam (max 8)";
            // 
            // btnAdd22
            // 
            this.btnAdd22.Location = new System.Drawing.Point(79, 145);
            this.btnAdd22.Name = "btnAdd22";
            this.btnAdd22.Size = new System.Drawing.Size(57, 23);
            this.btnAdd22.TabIndex = 24;
            this.btnAdd22.Text = "+2";
            this.btnAdd22.UseVisualStyleBackColor = true;
            this.btnAdd22.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd23
            // 
            this.btnAdd23.Location = new System.Drawing.Point(142, 145);
            this.btnAdd23.Name = "btnAdd23";
            this.btnAdd23.Size = new System.Drawing.Size(57, 23);
            this.btnAdd23.TabIndex = 23;
            this.btnAdd23.Text = "+3";
            this.btnAdd23.UseVisualStyleBackColor = true;
            this.btnAdd23.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd24
            // 
            this.btnAdd24.Location = new System.Drawing.Point(205, 145);
            this.btnAdd24.Name = "btnAdd24";
            this.btnAdd24.Size = new System.Drawing.Size(57, 23);
            this.btnAdd24.TabIndex = 22;
            this.btnAdd24.Text = "+4";
            this.btnAdd24.UseVisualStyleBackColor = true;
            this.btnAdd24.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkFastest2
            // 
            this.chkFastest2.AutoSize = true;
            this.chkFastest2.Location = new System.Drawing.Point(305, 78);
            this.chkFastest2.Name = "chkFastest2";
            this.chkFastest2.Size = new System.Drawing.Size(15, 14);
            this.chkFastest2.TabIndex = 21;
            this.chkFastest2.UseVisualStyleBackColor = true;
            // 
            // lblScore2
            // 
            this.lblScore2.AutoSize = true;
            this.lblScore2.Location = new System.Drawing.Point(13, 103);
            this.lblScore2.Name = "lblScore2";
            this.lblScore2.Size = new System.Drawing.Size(35, 13);
            this.lblScore2.TabIndex = 20;
            this.lblScore2.Text = "Score";
            // 
            // btnAdd25
            // 
            this.btnAdd25.Location = new System.Drawing.Point(268, 145);
            this.btnAdd25.Name = "btnAdd25";
            this.btnAdd25.Size = new System.Drawing.Size(57, 23);
            this.btnAdd25.TabIndex = 21;
            this.btnAdd25.Text = "+5";
            this.btnAdd25.UseVisualStyleBackColor = true;
            this.btnAdd25.Click += new System.EventHandler(this.btnAdd_Click);
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
            // numScore2
            // 
            this.numScore2.Location = new System.Drawing.Point(16, 119);
            this.numScore2.Name = "numScore2";
            this.numScore2.ReadOnly = true;
            this.numScore2.Size = new System.Drawing.Size(120, 20);
            this.numScore2.TabIndex = 20;
            // 
            // btnAdd21
            // 
            this.btnAdd21.Location = new System.Drawing.Point(16, 145);
            this.btnAdd21.Name = "btnAdd21";
            this.btnAdd21.Size = new System.Drawing.Size(57, 23);
            this.btnAdd21.TabIndex = 19;
            this.btnAdd21.Text = "+1";
            this.btnAdd21.UseVisualStyleBackColor = true;
            this.btnAdd21.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTimeSinceSet2
            // 
            this.txtTimeSinceSet2.Location = new System.Drawing.Point(16, 75);
            this.txtTimeSinceSet2.Name = "txtTimeSinceSet2";
            this.txtTimeSinceSet2.Size = new System.Drawing.Size(285, 20);
            this.txtTimeSinceSet2.TabIndex = 16;
            // 
            // lblComPort2
            // 
            this.lblComPort2.AutoSize = true;
            this.lblComPort2.Location = new System.Drawing.Point(13, 239);
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
            // btnStartTimer
            // 
            this.btnStartTimer.Location = new System.Drawing.Point(12, 141);
            this.btnStartTimer.Name = "btnStartTimer";
            this.btnStartTimer.Size = new System.Drawing.Size(93, 23);
            this.btnStartTimer.TabIndex = 20;
            this.btnStartTimer.Text = "Volgende vraag";
            this.btnStartTimer.UseVisualStyleBackColor = true;
            this.btnStartTimer.Click += new System.EventHandler(this.btnStartTimer_Click);
            // 
            // btnSendScores
            // 
            this.btnSendScores.Location = new System.Drawing.Point(376, 99);
            this.btnSendScores.Name = "btnSendScores";
            this.btnSendScores.Size = new System.Drawing.Size(111, 23);
            this.btnSendScores.TabIndex = 21;
            this.btnSendScores.Text = "Verstuur scores";
            this.btnSendScores.UseVisualStyleBackColor = true;
            this.btnSendScores.Click += new System.EventHandler(this.btnSendScores_Click);
            // 
            // btnSaveSession
            // 
            this.btnSaveSession.Location = new System.Drawing.Point(612, 141);
            this.btnSaveSession.Name = "btnSaveSession";
            this.btnSaveSession.Size = new System.Drawing.Size(112, 23);
            this.btnSaveSession.TabIndex = 22;
            this.btnSaveSession.Text = "Sessie opslaan";
            this.btnSaveSession.UseVisualStyleBackColor = true;
            this.btnSaveSession.Click += new System.EventHandler(this.btnSaveSession_Click);
            // 
            // sfdSaveSession
            // 
            this.sfdSaveSession.DefaultExt = "gns";
            this.sfdSaveSession.Filter = "Game Night Session|*.gns";
            // 
            // btnSessionLoad
            // 
            this.btnSessionLoad.Location = new System.Drawing.Point(494, 141);
            this.btnSessionLoad.Name = "btnSessionLoad";
            this.btnSessionLoad.Size = new System.Drawing.Size(112, 23);
            this.btnSessionLoad.TabIndex = 23;
            this.btnSessionLoad.Text = "Sessie laden";
            this.btnSessionLoad.UseVisualStyleBackColor = true;
            this.btnSessionLoad.Click += new System.EventHandler(this.btnSessionLoad_Click);
            // 
            // ofdSessionLoad
            // 
            this.ofdSessionLoad.Filter = "Game Night Session|*.gns";
            // 
            // lblStatusLabel
            // 
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Location = new System.Drawing.Point(13, 451);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Size = new System.Drawing.Size(40, 13);
            this.lblStatusLabel.TabIndex = 24;
            this.lblStatusLabel.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(59, 451);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(10, 13);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "-";
            // 
            // lblQuestionLabel
            // 
            this.lblQuestionLabel.AutoSize = true;
            this.lblQuestionLabel.Location = new System.Drawing.Point(642, 451);
            this.lblQuestionLabel.Name = "lblQuestionLabel";
            this.lblQuestionLabel.Size = new System.Drawing.Size(41, 13);
            this.lblQuestionLabel.TabIndex = 26;
            this.lblQuestionLabel.Text = "Vraag: ";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(689, 451);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(10, 13);
            this.lblQuestion.TabIndex = 27;
            this.lblQuestion.Text = "-";
            // 
            // chkFastest
            // 
            this.chkFastest.AutoSize = true;
            this.chkFastest.Location = new System.Drawing.Point(111, 145);
            this.chkFastest.Name = "chkFastest";
            this.chkFastest.Size = new System.Drawing.Size(92, 17);
            this.chkFastest.TabIndex = 28;
            this.chkFastest.Text = "Report fastest";
            this.chkFastest.UseVisualStyleBackColor = true;
            // 
            // btnToSqlServer
            // 
            this.btnToSqlServer.Location = new System.Drawing.Point(376, 141);
            this.btnToSqlServer.Name = "btnToSqlServer";
            this.btnToSqlServer.Size = new System.Drawing.Size(111, 23);
            this.btnToSqlServer.TabIndex = 29;
            this.btnToSqlServer.Text = "Write to online db";
            this.btnToSqlServer.UseVisualStyleBackColor = true;
            this.btnToSqlServer.Click += new System.EventHandler(this.btnToSqlServer_Click);
            // 
            // pbLoader
            // 
            this.pbLoader.BackgroundImage = global::GameNightSerialCommunications.Properties.Resources.Spinner;
            this.pbLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbLoader.InitialImage = null;
            this.pbLoader.Location = new System.Drawing.Point(1, -1);
            this.pbLoader.Name = "pbLoader";
            this.pbLoader.Size = new System.Drawing.Size(737, 478);
            this.pbLoader.TabIndex = 30;
            this.pbLoader.TabStop = false;
            this.pbLoader.Visible = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnSendAll;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 476);
            this.Controls.Add(this.btnToSqlServer);
            this.Controls.Add(this.chkFastest);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblQuestionLabel);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusLabel);
            this.Controls.Add(this.btnSessionLoad);
            this.Controls.Add(this.btnSaveSession);
            this.Controls.Add(this.btnSendScores);
            this.Controls.Add(this.btnStartTimer);
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
            this.Controls.Add(this.pbLoader);
            this.Name = "MainForm";
            this.Text = "Family Game Night Communicator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.pnlTeam1.ResumeLayout(false);
            this.pnlTeam1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScore1)).EndInit();
            this.pnlTeam2.ResumeLayout(false);
            this.pnlTeam2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numScore2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoader)).EndInit();
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
        private System.Windows.Forms.Button btnStartTimer;
        private System.Windows.Forms.Button btnSendScores;
        private System.Windows.Forms.Button btnAdd15;
        private System.Windows.Forms.NumericUpDown numScore1;
        private System.Windows.Forms.Button btnAdd11;
        private System.Windows.Forms.Button btnAdd25;
        private System.Windows.Forms.NumericUpDown numScore2;
        private System.Windows.Forms.Button btnAdd21;
        private System.Windows.Forms.Label lblScore1;
        private System.Windows.Forms.Label lblScore2;
        private System.Windows.Forms.CheckBox chkFastest1;
        private System.Windows.Forms.CheckBox chkFastest2;
        private System.Windows.Forms.Button btnSaveSession;
        private System.Windows.Forms.SaveFileDialog sfdSaveSession;
        private System.Windows.Forms.Button btnSessionLoad;
        private System.Windows.Forms.OpenFileDialog ofdSessionLoad;
        private System.Windows.Forms.Button btnAdd12;
        private System.Windows.Forms.Button btnAdd14;
        private System.Windows.Forms.Button btnAdd13;
        private System.Windows.Forms.Button btnAdd22;
        private System.Windows.Forms.Button btnAdd23;
        private System.Windows.Forms.Button btnAdd24;
        private System.Windows.Forms.TextBox txtTeamName1;
        private System.Windows.Forms.Label lblTeamName1;
        private System.Windows.Forms.TextBox txtTeamName2;
        private System.Windows.Forms.Label lblTeamName2;
        private System.Windows.Forms.TextBox txtTimeSinceSet1ms;
        private System.Windows.Forms.TextBox txtTimeSinceSet2ms;
        private System.Windows.Forms.Label lblStatusLabel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblQuestionLabel;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.CheckBox chkFastest;
        private System.Windows.Forms.Button btnToSqlServer;
        private System.Windows.Forms.PictureBox pbLoader;
    }
}

