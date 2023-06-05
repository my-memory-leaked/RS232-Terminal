using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace RS232
{
    internal class COMPort
    {
        private static SerialPort _serialPort = new SerialPort();
        public string ReceivedData;
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
                    string message = _serialPort.ReadExisting() + Environment.NewLine;
                    Console.WriteLine(message);
                    return message;
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
                _serialPort.Write(data);
            }
        }

    }
}
