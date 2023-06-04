using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RS232
{
    internal class ComPortParameters
    {
        private string _portName;
        private int _baudRate;
        private int _dataBits;
        private StopBits _stopBits;

        public ComPortParameters()
        { 
        }

        public void SetPortName(ComboBox portNameCBox)
        {
            _portName = portNameCBox.Text;
        }
        public string GetPortName() { return _portName; }


        public void SetBoudRate(ComboBox baudRateCBox)
        {
            try
            {
                string baudRateStr = baudRateCBox.Text;

                // I need to truncat the bits/s to get int value.
                int baudRateStrLen = baudRateStr.Length;
                baudRateStr = baudRateStr.Substring(0, baudRateStrLen - 7);

                _baudRate = Int32.Parse(baudRateStr);
            }
            catch { }
        }
        public int GetBaudRate() { return _baudRate; }


        public void SetDataBits(ComboBox dataBitsCBox)
        {
            try
            {
                string dataBitsStr = dataBitsCBox.Text;

                // I need to truncat the bits to get int value.
                int dataBitsStrLen = dataBitsStr.Length;
                dataBitsStr = dataBitsStr.Substring(0, dataBitsStrLen - 5);

                _dataBits = Int32.Parse(dataBitsStr);
            }
            catch { }
        }
        public int GetDataBits() { return _dataBits; }


        public void SetStopBits(ComboBox stopBitsCBox)
        {
            try
            {
                string stopBitsStr = stopBitsCBox.Text;

                // I need to truncat the bit or bits to get int value.
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

        public StopBits GetStopBits() { return _stopBits; }
    }
}
