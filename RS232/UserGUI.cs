using RS232;
using System.Reflection;
using static RS232.ComPortParameters;

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
            terminatorCBox.SelectedIndex = 0;
        }

        private void OpenCloseComButton_Click(object sender, EventArgs e)
        {

            if (_comPort.IsOpened())
            {
                OpenCloseComButton.Text = "Open";
                OpenCloseComButton.BackColor = Color.Green;

                _comPort.ClosePort();
                terminalRichTextBox.AppendText("COM Port closed!\n");
            }
            else
            {
                OpenCloseComButton.Text = "Close";
                OpenCloseComButton.BackColor = Color.Red;

                // Set port parametrs and then open it.
                _comPortParameters.SetPortName(comPortCBox);
                _comPortParameters.SetBoudRate(baudRateCBox);
                _comPortParameters.SetDataBits(dataBitsCBox);
                _comPortParameters.SetStopBits(stopBitsCBox);
                _comPortParameters.SetHandShake(flowControlCBox);
                _comPortParameters.SetParity(parityCBox);
                _comPortParameters.SetTerminator(terminatorCBox);

                // Todo add Terminator and timeout!!

                _comPort.OpenPort(_comPortParameters);

                terminalRichTextBox.AppendText(_comPortParameters.ParametersInfo);
            }
        }

        private void refreshComsButton_Click(object sender, EventArgs e)
        {
            _comPort.FetchAvailablePorts(comPortCBox);
        }

        private void terminalSendButton_Click(object sender, EventArgs e)
        {
            if (_comPort.IsOpened())
            {
                string dataToSend = sendCommandTextBox.Text;

                switch (_comPortParameters.GetTerminator())
                {
                    case Terminator.None:
                        // Nothing here.
                        _comPort.SendData(dataToSend);
                        terminalRichTextBox.AppendText("Sent data: " + dataToSend + "\n");
                        break;
                    case Terminator.CR:
                        _comPort.SendData(dataToSend + "\r");
                        terminalRichTextBox.AppendText("Sent data: " + dataToSend + "<CR>\n");
                        break;
                    case Terminator.LF:
                        _comPort.SendData(dataToSend + "\n");
                        terminalRichTextBox.AppendText("Sent data: " + dataToSend + "<LF>\n");
                        break;
                    case Terminator.CRLF:
                        _comPort.SendData(dataToSend + "\r\n");
                        terminalRichTextBox.AppendText("Sent data: " + dataToSend + "<CRLF>\n");
                        break;
                    case Terminator.Own:
                        string ownTerminator = ownTerminatorTextBox.Text;
                        _comPort.SendData(dataToSend + ownTerminator);
                        terminalRichTextBox.AppendText("Sent data: " + dataToSend + ownTerminator + "\n");
                        break;
                    default:
                        _comPort.SendData(dataToSend);
                        terminalRichTextBox.AppendText("Sent data: " + dataToSend + "\n");
                        break;
                }

            }
            else
            {
                terminalRichTextBox.AppendText("COM Port not opened!\n");
            }
        }

        private void terminatorCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (terminatorCBox.SelectedIndex == (int)ComPortParameters.Terminator.Own)
            {
                ownTerminatorTextBox.Visible = true;
            }
            else
            {
                ownTerminatorTextBox.Visible = false;
            }
        }
    }
}