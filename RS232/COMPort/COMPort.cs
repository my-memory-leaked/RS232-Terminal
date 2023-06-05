using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace RS232
{
    internal class COMPort
    {
        private static SerialPort _serialPort = new SerialPort();
        public string ReceivedData;
        private Stopwatch _stopWatch = new Stopwatch();


        public void FetchAvailablePorts(ComboBox comboBox)
        {
            if(comboBox.SelectedItem == null)
            {
                String[] ports = SerialPort.GetPortNames();
                comboBox.Items.AddRange(ports);
            }
        }

        public void OpenPort(ComPortParameters comPortParameters, UserGUI userGUI)
        {
            _serialPort.PortName = comPortParameters.GetPortName();
            _serialPort.BaudRate = comPortParameters.GetBaudRate();
            _serialPort.DataBits = comPortParameters.GetDataBits();
            _serialPort.StopBits = comPortParameters.GetStopBits();
            _serialPort.Handshake = comPortParameters.GetHandshake();
            _serialPort.Parity = comPortParameters.GetParity();
            _serialPort.DataReceived += userGUI._serialPort_DataReceived;

            try
            {
                _serialPort.Open();
            }
            catch
            {
                _serialPort.Close();
                return ;
            }
        }

        public bool IsOpened()
        {
            return _serialPort.IsOpen;
        }

        public void ClosePort()
        {
            if(_serialPort.IsOpen) 
            { 
                _serialPort.Close();
            }
        }

        public string ReceiveData()
        {
            try
            {
                if(_serialPort.IsOpen )
                {
                    string message = _serialPort.ReadExisting();

                    // check if ping
                    if (message.Equals("PING"))
                    {
                        SendData("PONG");
                        return "PING" + Environment.NewLine;
                    }
                    else if (message.Equals("PONG"))
                    {
                        _stopWatch.Stop();
                        return $"PONG {_stopWatch.Elapsed.TotalMilliseconds}ms\n";
                    }


                    return message + Environment.NewLine;
                }
            }
            catch (TimeoutException)
            {

            }
            return string.Empty;
        }


        public void SendData(string data)
        {
            if(_serialPort.IsOpen && data != null)
            { 
                if(data == "PING")
                {
                    _stopWatch.Restart();
                }
                _serialPort.Write(data);
            }
        }



    }
}
