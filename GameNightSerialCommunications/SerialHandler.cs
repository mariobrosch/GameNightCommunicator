using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;

namespace GameNightSerialCommunications
{
    class SerialHandler
    {
        public List<SerialPort> openPorts = new List<SerialPort>();


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
                    serialPort.WriteLine(text);

                }
            });
        }

        public void CloseAllPorts()
        {
            openPorts.ForEach(serialPort =>
            {
                ClosePort(serialPort);
            });
        }

        public void SendFault(SerialPort serialPort)
        {
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
        }

        internal void SendGood(SerialPort serialPort)
        {
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

        }
    }
}
