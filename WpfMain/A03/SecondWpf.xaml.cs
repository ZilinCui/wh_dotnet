using System.Windows.Controls;

namespace WpfMain.A03
{
    public partial class SecondWpf : Page
    {
        public SecondWpf()
        {
            InitializeComponent();
            Loaded+=delegate {App.ExecConsoleApp("ConsoleExample.A03.SecondConsole");};
        }
    }
}