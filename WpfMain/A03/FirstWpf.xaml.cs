using System.Windows.Controls;

namespace WpfMain.A03{
    public partial class FirstWpf : Page{
        public FirstWpf() {
            InitializeComponent();
            Loaded += delegate { App.ExecConsoleApp("ConsoleExample.A03.FirstConsole"); };
        }
    }
}