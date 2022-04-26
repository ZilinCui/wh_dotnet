using System.Windows;

namespace WpfMain{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application{
        public static void ExecConsoleApp(string arg) {
            //获取ExampleWpfApp.exe文件的完整路径
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            //得到ExampleConsoleApp.exe的完整路径
            path = path.Replace(@"WpfMain\bin\Debug\WpfMain.exe",
                @"ConsoleExample\bin\Debug\ConsoleExample.exe");
            System.Diagnostics.Process.Start(path, arg);
        }
    }
}