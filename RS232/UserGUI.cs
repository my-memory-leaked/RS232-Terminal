using RS232;
using System.Reflection;

namespace RS232
{
    public partial class UserGUI : Form
    {
        private COMPort _comPort = new COMPort();
        private ComPortParameters _comPortParameters = new ComPortParameters();

        public UserGUI()
        {
            InitializeComponent();
            _comPort.FetchAvailablePorts(comPortCBox);

            // Set defaults values.
            comPortCBox.SelectedIndex = 0;
            baudRateCBox.SelectedIndex = 6;
            dataBitsCBox.SelectedIndex = 0;
            stopBitsCBox.SelectedIndex = 0;
            flowControlCBox.SelectedIndex = 0;
            parityCBox.SelectedIndex = 0;   
        }

        private void OpenCloseComButton_Click(object sender, EventArgs e)
        {

            if (_comPort.IsOpened())
            {
                OpenCloseComButton.Text = "Open";
                OpenCloseComButton.BackColor = Color.Green;

                _comPort.ClosePort();
                return;
            }

            OpenCloseComButton.Text = "Close";
            OpenCloseComButton.BackColor = Color.Red;

            // Set port parametrs and then open it.
            _comPortParameters.SetPortName(comPortCBox);
            _comPortParameters.SetBoudRate(baudRateCBox);
            _comPortParameters.SetDataBits(dataBitsCBox);
            _comPortParameters.SetStopBits(stopBitsCBox);
            _comPortParameters.SetHandShake(flowControlCBox);
            _comPortParameters.SetParity(parityCBox);

            // Todo Terminator and timeout!!

            _comPort.OpenPort(_comPortParameters);
        }

        private void refreshComsButton_Click(object sender, EventArgs e)
        {
            _comPort.FetchAvailablePorts(comPortCBox);
        }
    }
}