using System;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameNightSerialCommunications
{
    public partial class MainForm : Form
    {
        SerialHandler sc = new SerialHandler();

        public MainForm()
        {
            InitializeComponent();

            var ports = SerialPort.GetPortNames();
            cboTeam1.DataSource = ports;
            var ports2 = SerialPort.GetPortNames();
            cboTeam2.DataSource = ports2;
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
            setDataReceived("TEAM1-" + serialTeam1.ReadLine());
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
            }
            else
            {
                sc.ClosePort(serialTeam1);
                btnSerial1Open.Text = "Open";
            }
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
            }
            else
            {
                sc.ClosePort(serialTeam2);
                btnSerial2Open.Text = "Open";
            }
        }

        private void serialTeam2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string line = serialTeam2.ReadLine();
            setDataReceived("TEAM2-" + line);
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
    }
}
