using System.Windows;
using System.Windows.Controls;

namespace WpfMain.A03{
    public partial class FifthWpf : Page{
        public FifthWpf() {
            InitializeComponent();
        }

        void RadioButton_Checked(object sender, RoutedEventArgs e) {
            if (result != null) {
                result.Content = "";
            }

            if (label != null)
                switch ((e.Source as RadioButton).Content.ToString()) {
                    case "加法":
                        label.Content = "+";
                        break;
                    case "减法":
                        label.Content = "-";
                        break;
                    case "乘法":
                        label.Content = "*";
                        break;
                    case "除法":
                        label.Content = "/";
                        break;
                    case "取模":
                        label.Content = "%";
                        break;
                }
        }

        void Caculate_Click(object sender, RoutedEventArgs e) {
            if (!double.TryParse(textBox1.Text, out double n1) || !double.TryParse(textBox2.Text, out double n2)) {
                result.Content = "?";
                return;
            }

            string format = "{0:0.####}";
            switch (label.Content.ToString()) {
                case "+":
                    result.Content = string.Format(format, n1 + n2);
                    break;
                case "-":
                    result.Content = string.Format(format, n1 - n2);
                    break;
                case "*":
                    result.Content = string.Format(format, n1 * n2);
                    break;
                case "/":
                    if (n2 == 0) result.Content = "?";
                    else result.Content = string.Format(format, n1 / n2);
                    break;
                case "%":
                    if (n2 == 0) result.Content = "?";
                    else result.Content = string.Format(format, n1 % n2);
                    break;
            }
        }
    }
}