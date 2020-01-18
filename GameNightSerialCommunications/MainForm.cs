using System;
using System.Windows.Forms;

namespace GameNightSerialCommunications
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            serialPort1.BaudRate = 9600;
            serialPort1.PortName = "COM5";
            serialPort1.Open();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {


            serialPort1.WriteLine(txtCommand.Text);
            txtCommand.Text = "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialPort1.ReadLine();
            setDataReceived(line);

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
    }
}
