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
        private bool _sentPing = false;

        /// <summary>
        /// Fetches and populates the ComboBox with the available serial ports.
        /// </summary>
        /// <param name="comboBox">The ComboBox control to populate with the available serial ports.</param>
        public void FetchAvailablePorts(ComboBox comboBox)
        {
            if (comboBox.SelectedItem == null)
            {
                String[] ports = SerialPort.GetPortNames();
                comboBox.Items.AddRange(ports);
            }
        }

        /// <summary>
        /// Opens the serial port with the specified parameters.
        /// </summary>
        /// <param name="comPortParameters">The COM port parameters.</param>
        /// <param name="userGUI">The UserGUI instance.</param>
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
                return;
            }
        }

        /// <summary>
        /// Checks if the serial port is open.
        /// </summary>
        /// <returns>True if the serial port is open, otherwise false.</returns>
        public bool IsOpened()
        {
            return _serialPort.IsOpen;
        }

        /// <summary>
        /// Closes the serial port.
        /// </summary>
        public void ClosePort()
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.Close();
            }
        }

        /// <summary>
        /// Reads and returns the received data from the serial port.
        /// </summary>
        /// <returns>The received data as a string.</returns>
        public string ReceiveData()
        {
            try
            {
                if (_serialPort.IsOpen)
                {
                    string message = _serialPort.ReadExisting();

                    // check if ping
                    if (message.Equals("PING"))
                    {
                        SendData("PONG");
                        return "PING" + Environment.NewLine;
                    }
                    else if (message.Equals("PONG") && _sentPing)
                    {
                        _stopWatch.Stop();
                        _sentPing = false;
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

        /// <summary>
        /// Sends data through the serial port.
        /// </summary>
        /// <param name="data">The data to send.</param>
        public void SendData(string data)
        {
            if (_serialPort.IsOpen && data != null)
            {
                if (data == "PING")
                {
                    _sentPing = true;
                    _stopWatch.Restart();
                }
                _serialPort.Write(data);
            }
        }
    }
}
