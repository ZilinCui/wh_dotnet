using System.Windows.Controls;

namespace WpfMain.A03
{
    public partial class FourthWpf : Page
    {
        public FourthWpf()
        {
            InitializeComponent();
            Loaded+=delegate {App.ExecConsoleApp("ConsoleExample.A03.FourthConsole");};
        }
    }
}