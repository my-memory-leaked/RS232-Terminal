using RS232.COMPort;
namespace RS232
{
    public partial class UserGUI : Form
    {
        public UserGUI()
        {
            InitializeComponent();
            COMPort.COMPort.FetchAvailablePorts(comPortCBox);
        }
    }
}