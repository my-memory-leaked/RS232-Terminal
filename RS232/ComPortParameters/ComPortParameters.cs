using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS232
{
    /// <summary>
    /// Represents the parameters for configuring a COM port.
    /// </summary>
    internal class ComPortParameters
    {
        private string _portName;
        private int _baudRate;
        private int _dataBits;
        private StopBits _stopBits;
        private Handshake _handShake;
        private Parity _parity;

        /// <summary>
        /// Defines the terminator options for the COM port.
        /// </summary>
        public enum Terminator { None, CR, LF, CRLF, Own };

        private Terminator _terminator;

        /// <summary>
        /// Sets the port name from the ComboBox.
        /// </summary>
        /// <param name="portNameCBox">The ComboBox containing the port names.</param>
        public void SetPortName(ComboBox portNameCBox)
        {
            _portName = portNameCBox.Text;
        }

        /// <summary>
        /// Returns the port name.
        /// </summary>
        /// <returns>The port name.</returns>
        public string GetPortName() { return _portName; }

        /// <summary>
        /// Sets the baud rate from the ComboBox.
        /// </summary>
        /// <param name="baudRateCBox">The ComboBox containing the baud rate options.</param>
        public void SetBaudRate(ComboBox baudRateCBox)
        {
            try
            {
                string baudRateStr = baudRateCBox.Text;

                // I need to truncate the bits/s to get an int value.
                int baudRateStrLen = baudRateStr.Length;
                baudRateStr = baudRateStr.Substring(0, baudRateStrLen - 7);

                _baudRate = Int32.Parse(baudRateStr);
            }
            catch { }
        }

        /// <summary>
        /// Returns the baud rate.
        /// </summary>
        /// <returns>The baud rate.</returns>
        public int GetBaudRate() { return _baudRate; }

        /// <summary>
        /// Sets the data bits from the ComboBox.
        /// </summary>
        /// <param name="dataBitsCBox">The ComboBox containing the data bits options.</param>
        public void SetDataBits(ComboBox dataBitsCBox)
        {
            try
            {
                string dataBitsStr = dataBitsCBox.Text;

                // I need to truncate the bits to get int value.
                int dataBitsStrLen = dataBitsStr.Length;
                dataBitsStr = dataBitsStr.Substring(0, dataBitsStrLen - 5);

                _dataBits = Int32.Parse(dataBitsStr);
            }
            catch { }
        }

        /// <summary>
        /// Returns the data bits.
        /// </summary>
        /// <returns>The data bits.</returns>
        public int GetDataBits() { return _dataBits; }

        /// <summary>
        /// Sets the stop bits from the ComboBox.
        /// </summary>
        /// <param name="stopBitsCBox">The ComboBox containing the stop bits options.</param>
        public void SetStopBits(ComboBox stopBitsCBox)
        {
            try
            {
                string stopBitsStr = stopBitsCBox.Text;

                // I need to truncate the bit or bits to get int value.
                int stopBitsStrLen = stopBitsStr.Length;
                stopBitsStr = stopBitsStr.Substring(0, stopBitsStrLen - 4);
                int stopBits = Int32.Parse(stopBitsStr);

                switch (stopBits)
                {
                    case 1:
                        _stopBits = StopBits.One;
                        break;
                    case 2:
                        _stopBits = StopBits.Two;
                        break;
                    default:
                        _stopBits = StopBits.One;
                        break;
                }
            }
            catch { }
        }

        /// <summary>
        /// Returns the stop bits.
        /// </summary>
        /// <returns>The stop bits.</returns>
        public StopBits GetStopBits() { return _stopBits; }

        /// <summary>
        /// Sets the handshake from the ComboBox.
        /// </summary>
        /// <param name="flowControlCBox">The ComboBox containing the flow control options.</param>
        public void SetHandShake(ComboBox flowControlCBox)
        {
            int flowControl = flowControlCBox.SelectedIndex;
            switch (flowControl)
            {
                case 0:
                    _handShake = Handshake.None;
                    break;
                case 1:
                    _handShake = Handshake.XOnXOff;
                    break;
                case 2:
                    _handShake = Handshake.RequestToSend;
                    break;
                default:
                    _handShake = Handshake.None;
                    break;
            }
        }

        /// <summary>
        /// Returns the handshake.
        /// </summary>
        /// <returns>The handshake.</returns>
        public Handshake GetHandshake() { return _handShake; }

        /// <summary>
        /// Sets the parity from the ComboBox.
        /// </summary>
        /// <param name="parityCBox">The ComboBox containing the parity options.</param>
        public void SetParity(ComboBox parityCBox)
        {
            int parity = parityCBox.SelectedIndex;
            switch (parity)
            {
                case 0:
                    _parity = Parity.None;
                    break;
                case 1:
                    _parity = Parity.Odd;
                    break;
                case 2:
                    _parity = Parity.Even;
                    break;
                default:
                    _parity = Parity.None;
                    break;
            }
        }

        /// <summary>
        /// Returns the parity.
        /// </summary>
        /// <returns>The parity.</returns>
        public Parity GetParity() { return _parity; }

        /// <summary>
        /// Sets the terminator from the ComboBox.
        /// </summary>
        /// <param name="terminatorCBox">The ComboBox containing the terminator options.</param>
        public void SetTerminator(ComboBox terminatorCBox)
        {
            int terminator = terminatorCBox.SelectedIndex;
            switch (terminator)
            {
                case 0:
                    _terminator = Terminator.None;
                    break;
                case 1:
                    _terminator = Terminator.CR;
                    break;
                case 2:
                    _terminator = Terminator.LF;
                    break;
                case 3:
                    _terminator = Terminator.CRLF;
                    break;
                case 4:
                    _terminator = Terminator.Own;
                    break;
                default:
                    _terminator = Terminator.None;
                    break;
            }
        }

        /// <summary>
        /// Returns the terminator.
        /// </summary>
        /// <returns>The terminator.</returns>
        public Terminator GetTerminator() { return _terminator; }

        /// <summary>
        /// Returns information about the parameters.
        /// </summary>
        public string ParametersInfo
        {
            get
            {
                string info;
                info = "Opened port: " + _portName + Environment.NewLine;
                info += "Baud rate: " + Convert.ToString(_baudRate) + Environment.NewLine;
                info += "Data bits: " + Convert.ToString(_dataBits) + Environment.NewLine;
                info += "Stop bits: " + Convert.ToString(_stopBits) + Environment.NewLine;
                info += "Flow Control: " + Convert.ToString(_handShake) + Environment.NewLine;
                info += "Parity: " + Convert.ToString(_parity) + Environment.NewLine;
                info += "Terminator: <" + Convert.ToString(_terminator) + ">" + Environment.NewLine;
                return info;
            }
        }
    }
}
