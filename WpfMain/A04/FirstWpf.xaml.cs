using System.Windows.Controls;

namespace WpfMain.A04{
    public partial class FirstWpf : Page{
        public FirstWpf() {
            InitializeComponent();
            Loaded+=delegate {App.ExecConsoleApp("ConsoleExample.A04.FirstConsole");};
        }
    }
}