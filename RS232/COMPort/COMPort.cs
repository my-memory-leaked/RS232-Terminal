using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Runtime.InteropServices;

namespace RS232.COMPort
{
    public class COMPort
    {
       
        public static void FetchAvailablePorts(ComboBox comboBox)
        {
            if(comboBox.SelectedItem == null)
            {
                String[] ports = SerialPort.GetPortNames();
                comboBox.Items.AddRange(ports);
            }
        }

    }
}
