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

        public COMPort()
        {
        }

        public void FetchAvailablePorts(ComboBox comboBox)
        {
            if(comboBox.SelectedItem == null)
            {
                String[] ports = SerialPort.GetPortNames();
                comboBox.Items.AddRange(ports);
            }
        }

        public void OpenPort(ComPortParameters comPortParameters)
        {
            //_serialPort.PortName = SetPortName(_serialPort.PortName);
            _serialPort.BaudRate = comPortParameters.GetBaudRate();
            //_serialPort.Parity = SetPortParity(_serialPort.Parity);
            _serialPort.DataBits = comPortParameters.GetDataBits();
            _serialPort.StopBits = comPortParameters.GetStopBits();
            //_serialPort.Handshake = SetPortHandshake(_serialPort.Handshake);

            //// Set the read/write timeouts
            //_serialPort.ReadTimeout = 500;
            //_serialPort.WriteTimeout = 500;



            _serialPort.Open();
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

        public string Read()
        {
            try
            {
                string message = _serialPort.ReadLine();
                Console.WriteLine(message);
                return message;
            }
            catch (TimeoutException)
            {

            }
            return string.Empty;
        }

    }
}
