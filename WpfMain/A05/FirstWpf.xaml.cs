using System.Windows.Controls;

namespace WpfMain.A05{
    public partial class FirstWpf : Page{
        public FirstWpf() {
            InitializeComponent();

            InitializeComponent();

            //（4）
            Loaded += delegate {
                B b = new C();
                TextBlock1.Text = b.Result;
            };
        }

        public class A{
            public string Result { get; protected set; } = "";

            public A() {
                Result += "A\n";
            }
        }

        //（2）
        public class B : A{
            public B() {
                Result += "B\n";
            }
        }

        //（3）
        public class C : B{
            public C() {
                Result += "C\n";
            }
        }
    }
}