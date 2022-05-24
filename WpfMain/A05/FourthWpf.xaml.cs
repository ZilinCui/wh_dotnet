using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace WpfMain.A05{
    public partial class FourthWpf : Page{
        public FourthWpf() {
            InitializeComponent();

            List<Student> students = new List<Student> {
                new Student {Name = "张三", Gender = '男', Score = 81},
                new Student {Name = "李四", Gender = '男', Score = 83},
                new Student {Name = "李五", Gender = '女', Score = 85},
                new Student {Name = "王六", Gender = '男', Score = 83}
            };
            var q = from t in students orderby t.Score, t.Name where t.Score > 0 group t by t.Gender;
            StringBuilder sb = new StringBuilder();
            foreach (var v in q) {
                foreach (var v1 in v) {
                    sb.AppendLine(v1.ToString());
                }
            }

            TextBlock1.Text = sb.ToString();
        }

        public class Student{
            private static int id = 1;

            public string ID {
                get { return (id++).ToString("d4"); }
            }

            public string Name { get; set; } = "未知";
            public char Gender { get; set; } = '男';
            public int Score { get; set; }

            override public String ToString() {
                return $"{ID}\t{Name}\t{Gender}\t{Score}\t";
            }
        }
    }
}