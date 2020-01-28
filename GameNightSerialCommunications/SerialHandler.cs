using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace GameNightSerialCommunications
{
    class SerialHandler
    {
        public List<SerialPort> openPorts = new List<SerialPort>();
        public List<SerialPort> busyPorts = new List<SerialPort>();

        public bool PortOpen(SerialPort serialPort)
        {

            return serialPort.IsOpen;
        }

        public void OpenPort(SerialPort serialPort)
        {
            if (!serialPort.IsOpen)
            {
                serialPort.Open();
                openPorts.Add(serialPort);
            }
        }

        public void ClosePort(SerialPort  serialPort)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                openPorts.Remove(serialPort);
            }
        }

        internal void SendToAll(string text)
        {
            openPorts.ForEach(serialPort =>
            {
                if (serialPort.IsOpen)
                {
                    if (!isPortBusy(serialPort))
                    {
                        setPortAvailable(serialPort);
                        serialPort.WriteLine(text);
                        setPortAvailable(serialPort);
                    }

                }
            });
        }

        public void CloseAllPorts()
        {
            var localPorts = openPorts.ToArray();
            foreach (var port in localPorts)
            {
                ClosePort(port);
            };
        }

        public void SendFault(SerialPort serialPort)
        {
            if(isPortBusy(serialPort))
            {
                return;
            }
            setPortBusy(serialPort);
            serialPort.WriteLine("FOUT");
            serialPort.WriteLine("L:255");
            serialPort.WriteLine("S:300");
            Thread.Sleep(300);
            serialPort.WriteLine("L:0");
            Thread.Sleep(300);
            serialPort.WriteLine("L:255");
            serialPort.WriteLine("S:300");
            Thread.Sleep(300);
            serialPort.WriteLine("L:0");
            Thread.Sleep(300);
            serialPort.WriteLine("L:255");
            serialPort.WriteLine("S:300");
            Thread.Sleep(300);
            serialPort.WriteLine("L:0");
            Thread.Sleep(300);
            serialPort.WriteLine("");
            setPortAvailable(serialPort);
        }

        internal void SendGood(SerialPort serialPort)
        {
            if (isPortBusy(serialPort))
            {
                return;
            }
            setPortBusy(serialPort);
            serialPort.WriteLine("GOED");
            serialPort.WriteLine("S:100");
            Thread.Sleep(200);
            serialPort.WriteLine("S:50");
            Thread.Sleep(100);
            serialPort.WriteLine("S:50");
            Thread.Sleep(100);
            serialPort.WriteLine("S:100");
            serialPort.WriteLine("L:1");
            Thread.Sleep(100);
            serialPort.WriteLine("L:2");
            Thread.Sleep(100);
            serialPort.WriteLine("L:4");
            Thread.Sleep(100);
            serialPort.WriteLine("L:8");
            Thread.Sleep(100);
            serialPort.WriteLine("L:16");
            Thread.Sleep(100);
            serialPort.WriteLine("L:32");
            Thread.Sleep(100);
            serialPort.WriteLine("L:64");
            Thread.Sleep(100);
            serialPort.WriteLine("L:128");
            Thread.Sleep(100);
            serialPort.WriteLine("L:0");
            serialPort.WriteLine("");
            setPortAvailable(serialPort);
        }

        bool isPortBusy(SerialPort serialPort)
        {
            if (busyPorts.Contains(serialPort))
            {
                return true;
            }
            return false;
        }

        void setPortBusy(SerialPort serialPort)
        {
            if (!busyPorts.Contains(serialPort))
            {
                busyPorts.Add(serialPort);
            }
        }

        void setPortAvailable(SerialPort serialPort)
        {
            if (busyPorts.Contains(serialPort))
            {
                busyPorts.Remove(serialPort);
            }
        }

        internal void sendMessageToTeam(SerialPort serialPort, string message)
        {
            if (serialPort.IsOpen)
            {
                if (!isPortBusy(serialPort))
                {
                    setPortAvailable(serialPort);
                    serialPort.WriteLine(message);
                    setPortAvailable(serialPort);
                }
            }
        }
    }
}
