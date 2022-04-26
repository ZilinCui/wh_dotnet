using System.Windows.Controls;

namespace WpfMain.A03
{
    public partial class ThirdWpf : Page
    {
        public ThirdWpf()
        {
            InitializeComponent();
            Loaded+=delegate {App.ExecConsoleApp("ConsoleExample.A03.ThirdConsole");};
        }
    }
}