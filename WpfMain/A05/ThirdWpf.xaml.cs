using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace WpfMain.A05{
    public partial class ThirdWpf : Page{
        public ThirdWpf() {
            InitializeComponent();
            
            SortedList<int, string> list = new SortedList<int, string>
            {
                { 10, "str10" },
                { 2, "str2" },
                { 13, "str13" },
                { 24, "str24" },
                { 15, "str15" }
            };
            string s = "Key\t Value\n";
            s += new string('-', 20) + "\n";
            var result = list.Reverse();
            foreach (var v in result)
            {
                s += $"{v.Key}\t{v.Value}\n";
            }
            TextBlock1.Text = s;
        }
    }
}