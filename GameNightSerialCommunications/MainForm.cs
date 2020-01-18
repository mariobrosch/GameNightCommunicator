using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace GameNightSerialCommunications
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var ports = SerialPort.GetPortNames();
            cboTeam1.DataSource = ports;
            cboTeam2.DataSource = ports;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            serialTeam1.WriteLine(txtCommand.Text);
            txtCommand.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialTeam1.IsOpen)
            {
                serialTeam1.Close();
            }
            if (serialTeam2.IsOpen)
            {
                serialTeam2.Close();
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialTeam1.ReadLine();
            setDataReceived("TEAM1-"+line);
        }

        private void setDataReceived(string dataReceived)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(setDataReceived), new object[] { dataReceived });
                return;
            }
            txtDataReceived.AppendText(dataReceived + Environment.NewLine);
        }

        private void btnFault_Click(object sender, EventArgs e)
        {
            serialTeam1.WriteLine("FOUT");
            serialTeam1.WriteLine("L:255");
            serialTeam1.WriteLine("S:300");
            Thread.Sleep(300);
            serialTeam1.WriteLine("L:0");
            Thread.Sleep(300);
            serialTeam1.WriteLine("L:255");
            serialTeam1.WriteLine("S:300");
            Thread.Sleep(300);
            serialTeam1.WriteLine("L:0");
            Thread.Sleep(300);
            serialTeam1.WriteLine("L:255");
            serialTeam1.WriteLine("S:300");
            Thread.Sleep(300);
            serialTeam1.WriteLine("L:0");
            Thread.Sleep(300);
            serialTeam1.WriteLine("");
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            serialTeam1.WriteLine("GOED");
            serialTeam1.WriteLine("S:100");
            Thread.Sleep(200);
            serialTeam1.WriteLine("S:50");
            Thread.Sleep(100);
            serialTeam1.WriteLine("S:50");
            Thread.Sleep(100);
            serialTeam1.WriteLine("S:100");
            serialTeam1.WriteLine("L:1");
            Thread.Sleep(100); 
            serialTeam1.WriteLine("L:2");
            Thread.Sleep(100); 
            serialTeam1.WriteLine("L:4");
            Thread.Sleep(100); 
            serialTeam1.WriteLine("L:8");
            Thread.Sleep(100); 
            serialTeam1.WriteLine("L:16");
            Thread.Sleep(100); 
            serialTeam1.WriteLine("L:32");
            Thread.Sleep(100); 
            serialTeam1.WriteLine("L:64");
            Thread.Sleep(100);
            serialTeam1.WriteLine("L:128");
            Thread.Sleep(100);
            serialTeam1.WriteLine("L:0");
            serialTeam1.WriteLine("");
        }

        private void btnSerial1Open_Click(object sender, EventArgs e)
        {
            if (!serialTeam1.IsOpen)
            {
                serialTeam1.Open();
            }
        }

        private void btnSerial2Open_Click(object sender, EventArgs e)
        {
            if (!serialTeam2.IsOpen)
            {
                serialTeam2.Open();
            }
        }

        private void serialTeam2_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialTeam1.ReadLine();
            setDataReceived("TEAM2-"+line);
        }
    }
}
