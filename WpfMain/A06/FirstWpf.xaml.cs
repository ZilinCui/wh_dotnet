using System;
using System.IO;
using System.Windows.Controls;

namespace WpfMain.A06{
    public partial class FirstWpf : Page{
        public FirstWpf() {
            InitializeComponent();
            Loaded += delegate {
                //获取FuLuAWpfApp.exe文件的完整路径
                string file = System.Reflection.Assembly.GetExecutingAssembly().Location;
                //得到目录位置
                string path = System.IO.Path.GetDirectoryName(file) + @"\A0601";
                TextBlock1.Text = $"目录位置：{path}";
                try {
                    if (!Directory.Exists(path)) {
                        Directory.CreateDirectory(path);
                        TextBlock1.Text += "\n创建该目录成功。";
                    }
                    else {
                        TextBlock1.Text += "\n该目录已存在。";
                    }
                }
                catch (Exception e) {
                    TextBlock1.Text += $"\n创建该目录失败: {e.Message}";
                }
            };
        }
    }
}