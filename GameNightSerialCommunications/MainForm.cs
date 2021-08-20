using GameNightSerialCommunications.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNightSerialCommunications
{
    public partial class MainForm : Form
    {
        readonly SerialHandler sc = new SerialHandler();
        DateTime setDate;
        readonly string sessionFileLocation = Path.Combine(Directory.GetCurrentDirectory(), "currentSession.gns");
        readonly string defaultSaveLocation = Path.Combine(Directory.GetCurrentDirectory(), "savedSessions");
        internal Session session;
        int currentQuestion = 1;

        public MainForm()
        {
            InitializeComponent();
            var ports = SerialPort.GetPortNames();
            cboTeam1.DataSource = ports;
            var ports2 = SerialPort.GetPortNames();
            cboTeam2.DataSource = ports2;
            setDate = DateTime.Now;
            lblQuestion.Text = currentQuestion.ToString();


            if (File.Exists(sessionFileLocation))
            {
                // Does the previous session contains valid data?
                try
                {
                    var prevSession = SessionHandler.FromXml<Session>(File.ReadAllText(sessionFileLocation));
                    if (prevSession.team1.scores.Count > 0 || prevSession.team2.scores.Count > 0)
                    {
                        if (MessageBox.Show("Vorige sessie hervatten?", "Hervatten?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            reloadSession(prevSession);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    // Error, so previous session was faulty, no worries :)
                }
            }
            if (session == null)
            {
                session = new Session
                {
                    team1 = new Team()
                    {
                        scores = new List<Score>()
                    },
                    team2 = new Team()
                    {
                        scores = new List<Score>()
                    }
                };
            }
        }

        private void SetLoading(bool displayLoader)
        {
            if (displayLoader)
            {
                Invoke((MethodInvoker)delegate
                {
                    pbLoader.BringToFront();
                    pbLoader.Visible = true;

                    Cursor = Cursors.WaitCursor;
                });
            }
            else
            {
                Invoke((MethodInvoker)delegate
                {
                    pbLoader.Visible = false;
                    Cursor = Cursors.Default;
                    pbLoader.SendToBack();
                });
            }
        }

        private void btnSendAll_Click(object sender, EventArgs e)
        {
            sc.SendToAll(txtCommand.Text);
            txtCommand.Text = "";
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            sc.CloseAllPorts();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, SerialDataReceivedEventArgs>(serialPort1_DataReceived), new object[] { sender, e });
                return;
            }

            if (!String.IsNullOrEmpty(txtTimeSinceSet1.Text))
            {
                sc.sendMessageToTeam(serialTeam1, txtLastAnswerTeam1.Text.Split(':')[1].Substring(0, 1));
                return;
            }
            TimeSpan span = DateTime.Now - setDate;
            int ms = (int)span.TotalMilliseconds;
            txtTimeSinceSet1.Text = ms.ToString();
            double seconds = Convert.ToDouble(ms) / 1000;
            txtTimeSinceSet1.Text = seconds.ToString() + " s.";
            if (String.IsNullOrEmpty(txtTimeSinceSet2.Text))
            {
                chkFastest1.Checked = true;
                sc.sendMessageToTeam(serialTeam1, "L:255");
                sc.sendMessageToTeam(serialTeam1, "S:200");
            }
            setDataReceived("TEAM1-" + serialTeam1.ReadLine());
        }

        private void serialTeam2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<object, SerialDataReceivedEventArgs>(serialTeam2_DataReceived), new object[] { sender, e });
                return;
            }
            if (!String.IsNullOrEmpty(txtTimeSinceSet2.Text))
            {
                sc.sendMessageToTeam(serialTeam2, txtLastAnswerTeam2.Text.Split(':')[1].Substring(0, 1));
                return;
            }
            TimeSpan span = DateTime.Now - setDate;
            int ms = (int)span.TotalMilliseconds;
            txtTimeSinceSet2ms.Text = ms.ToString();
            double seconds = Convert.ToDouble(ms) / 1000;
            txtTimeSinceSet2.Text = seconds.ToString() + " s.";
            if (String.IsNullOrEmpty(txtTimeSinceSet1.Text))
            {
                chkFastest2.Checked = true;
                sc.sendMessageToTeam(serialTeam2, "L:255");
                sc.sendMessageToTeam(serialTeam2, "S:200");
            }
            setDataReceived("TEAM2-" + serialTeam2.ReadLine());
        }

        private void setDataReceived(string dataReceived)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(setDataReceived), new object[] { dataReceived });
                return;
            }
            var team = dataReceived.Split('-');
            if (team[0] == "TEAM1")
            {
                txtLastAnswerTeam1.Text = team[1];

            }
            if (team[0] == "TEAM2")
            {
                txtLastAnswerTeam2.Text = team[1];
            }
        }

        private void btnFault1_Click(object sender, EventArgs e)
        {
            Task.Run(() => sc.SendFault(serialTeam1));
        }

        private void btnGood1_Click(object sender, EventArgs e)
        {
            Task.Run(() => sc.SendGood(serialTeam1));
        }

        private void btnSerial1Open_Click(object sender, EventArgs e)
        {
            if (!serialTeam1.IsOpen)
            {
                serialTeam1.PortName = cboTeam1.Text;
                if (serialTeam1.PortName == serialTeam2.PortName)
                {
                    MessageBox.Show("Kies een andere port, deze is al in gebruik");
                    return;
                }
                sc.OpenPort(serialTeam1);
                btnSerial1Open.Text = "Close";
                session.team1.comPortUsed = serialTeam1.PortName;
            }
            else
            {
                sc.ClosePort(serialTeam1);
                btnSerial1Open.Text = "Open";
                session.team1.comPortUsed = "";
            }
            saveSession();
        }

        private void btnSerial2Open_Click(object sender, EventArgs e)
        {
            if (!serialTeam2.IsOpen)
            {
                serialTeam2.PortName = cboTeam2.Text;
                if (serialTeam1.PortName == serialTeam2.PortName)
                {
                    MessageBox.Show("Kies een andere port, deze is al in gebruik");
                    return;
                }
                sc.OpenPort(serialTeam2);
                btnSerial2Open.Text = "Close";
                session.team2.comPortUsed = serialTeam2.PortName;
            }
            else
            {
                sc.ClosePort(serialTeam2);
                btnSerial2Open.Text = "Open";
                session.team2.comPortUsed = "";
            }
            saveSession();
        }



        private void btnFaultAll_Click(object sender, EventArgs e)
        {
            Task.Run(() => sc.SendFault(serialTeam1));
            Task.Run(() => sc.SendFault(serialTeam2));
        }

        private void btnGoodAll_Click(object sender, EventArgs e)
        {
            Task.Run(() => sc.SendGood(serialTeam1));
            Task.Run(() => sc.SendGood(serialTeam2));
        }

        private void btnFault2_Click(object sender, EventArgs e)
        {
            Task.Run(() => sc.SendFault(serialTeam2));
        }

        private void btnGood2_Click(object sender, EventArgs e)
        {
            Task.Run(() => sc.SendGood(serialTeam2));
        }

        private void btnSendScores_Click(object sender, EventArgs e)
        {
            sc.sendMessageToTeam(serialTeam1, numScore1.Value.ToString());
            sc.sendMessageToTeam(serialTeam2, numScore2.Value.ToString());
        }

        private void btnSend1_Click(object sender, EventArgs e)
        {
            sc.sendMessageToTeam(serialTeam1, txtCommand.Text);
        }

        private void btnSend2_Click(object sender, EventArgs e)
        {
            sc.sendMessageToTeam(serialTeam2, txtCommand.Text);
        }

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
            writeScoringRecords();
            resetAnswerFields();
            setDate = DateTime.Now;
        }

        void writeScoringRecords()
        {
            numScore1.Value += numScoreLastQuestion1.Value;
            numScore2.Value += numScoreLastQuestion2.Value;
            addScore(1, (int)numScoreLastQuestion1.Value, chkFastest1.Checked);
            addScore(2, (int)numScoreLastQuestion2.Value, chkFastest2.Checked);
        }

        void resetAnswerFields()
        {
            sc.SendToAll("");
            txtLastAnswerTeam1.Text = "";
            txtLastAnswerTeam2.Text = "";
            txtTimeSinceSet1.Text = "";
            txtTimeSinceSet2.Text = "";
            txtTimeSinceSet1ms.Text = "";
            txtTimeSinceSet2ms.Text = "";
            numScoreLastQuestion1.Value = 0;
            numScoreLastQuestion2.Value = 0;
            sc.SendToAll("L:0");
            chkFastest1.Checked = false;
            chkFastest2.Checked = false;
            currentQuestion += 1;
            lblQuestion.Text = currentQuestion.ToString();
            sc.SendToAll("S:300");
        }

        private void btnSaveSession_Click(object sender, EventArgs e)
        {
            if (!File.Exists(sessionFileLocation))
            {
                MessageBox.Show("Geen sessie gevonden, start eerst het spel voordat je een sessie kunt opslaan");
                return;
            }
            if (!Directory.Exists(defaultSaveLocation))
            {
                Directory.CreateDirectory(defaultSaveLocation);
            }
            if (sfdSaveSession.ShowDialog() == DialogResult.Yes)
            {
                // The data was already saved in a file, so we only have to copy it
                File.Copy(sessionFileLocation, sfdSaveSession.FileName, true);
            }
        }

        private void btnSessionLoad_Click(object sender, EventArgs e)
        {
            ofdSessionLoad.InitialDirectory = defaultSaveLocation;
            if (!Directory.Exists(defaultSaveLocation))
            {
                Directory.CreateDirectory(defaultSaveLocation);
            }
            if (ofdSessionLoad.ShowDialog() == DialogResult.Yes)
            {
                var prevSession = SessionHandler.FromXml<Session>(File.ReadAllText(ofdSessionLoad.FileName));
                reloadSession(prevSession);
            }
        }

        private void reloadSession(Session prevSession)
        {
            session = SessionHandler.ReloadSession(session, prevSession);
            currentQuestion = SessionHandler.GetLatestQuestion(session) + 1;
            lblQuestion.Text = currentQuestion.ToString();
            numScore1.Value = SessionHandler.GetScoreForTeam(1, session);
            numScore2.Value = SessionHandler.GetScoreForTeam(2, session);
            txtTeamName1.Text = session.team1.teamName;
            txtTeamName2.Text = session.team2.teamName;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var button = (sender as Button);
            int score = Convert.ToInt32(button.Text.Replace("+", ""));
            int team = Convert.ToInt32(button.Parent.Name.Replace("pnlTeam", ""));

            if (team == 1)
            {
                numScoreLastQuestion1.Value += score;
            }
            else
            {
                numScoreLastQuestion2.Value += score;
            }
        }

        private void saveTeamName(int team, string text)
        {
            if (team == 1)
            {
                session.team1.teamName = text;
            }
            if (team == 2)
            {
                session.team2.teamName = text;
            }
            saveSession();
        }

        private void txtTeamName_TextChanged(object sender, EventArgs e)
        {
            var textbox = (sender as TextBox);
            string teamName = textbox.Text;
            int team = Convert.ToInt32(textbox.Name.Replace("txtTeamName", ""));
            saveTeamName(team, teamName);
            saveSession();
        }

        private void addScore(int team, int points, bool fastest)
        {
            Score score = new Score
            {
                points = points,
                question = currentQuestion,
                fastest = (fastest ? 1 : 0)
            };
            if (team == 1)
            {
                score.miliseconds = String.IsNullOrEmpty(txtTimeSinceSet1ms.Text) ? 0 : Convert.ToInt32(txtTimeSinceSet1ms.Text);
                SessionHandler.AddScore(session, score, 1);
            }

            if (team == 2)
            {
                score.miliseconds = String.IsNullOrEmpty(txtTimeSinceSet2ms.Text) ? 0 : Convert.ToInt32(txtTimeSinceSet2ms.Text);
                SessionHandler.AddScore(session, score, 2);
            }
            saveSession();
        }
        private void saveSession()
        {
            var xmlData = session.ToXml();
            File.WriteAllText(sessionFileLocation, xmlData);
        }

        private void btnToSqlServer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data wegschrijven naar online database? Alle data wordt overschreven. Doorgaan?", "Overschrijven data?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Thread threadInput = new Thread(DisplayData);
                    threadInput.Start();
                }
                #pragma warning disable CA1031 // Do not catch general exception types
                catch (Exception ex)
                #pragma warning restore CA1031 // Do not catch general exception types
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void DisplayData()
        {
            SetLoading(true);
            SqlHandler.writeSessionToDb(session);
            SetLoading(false);
        }

        private void btnResetScoreForThisQuestion1_Click(object sender, EventArgs e)
        {
            numScoreLastQuestion1.Value = 0;
        }

        private void btnResetScoreForThisQuestion2_Click(object sender, EventArgs e)
        {
            numScoreLastQuestion2.Value = 0;
        }

        private void btnSub11_Click(object sender, EventArgs e)
        {
            numScoreLastQuestion1.Value -= 1;
        }

        private void btnSub21_Click(object sender, EventArgs e)
        {
            numScoreLastQuestion2.Value -= 1;
        }
    }
}
