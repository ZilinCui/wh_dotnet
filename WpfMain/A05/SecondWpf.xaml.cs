using System.Windows.Controls;

namespace WpfMain.A05{
    public partial class SecondWpf : Page{
        public SecondWpf() {
            InitializeComponent();
            
            //（3）
            Loaded += delegate
            {
                var d = new D();
                d.MyMethod(2);
                TextBlock1.Text += d.Result;
                var e = new E();
                e.MyMethod(2);
                TextBlock1.Text += e.Result;
            };
        }
        
        public class D
        {
            public string Result { get; protected set; } = "";
            public virtual void MyMethod(int num)
            {
                num += 10;
                Result += $"{num}\n";
            }
        }

        //（2）
        public class E : D
        {
            public override void MyMethod(int num)
            {
                num += 50;
                Result += $"{num}\n";
            }
        }
    }
}