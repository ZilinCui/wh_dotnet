using System.Windows.Controls;

namespace WpfMain.A04{
    /// <summary>
    /// PageA0402.xaml 的交互逻辑
    /// </summary>
    public partial class SecondWpf : Page{
        public SecondWpf() {
            InitializeComponent();

            //（6）
            Loaded += delegate {
                listBox1.Items.Add(string.Format(
                    "{0,-10}{1,-10}{2,-20}{3,5}",
                    "课程名", "开设学期", "书名", "定价"));
                var course1 = new CourseInfo {
                    CourseName = "数据结构",
                    CourseSemester = CourseTime.秋季,
                    BookName = "《数据结构》",
                    Price = 40
                };
                listBox1.Items.Add(course1.Print());
                var course2 = new CourseInfo("操作系统", "《操作系统》", CourseTime.秋季, 45);
                listBox1.Items.Add(course2.Print());
                var course3 = new CourseInfo("软件工程", "《软件工程》", CourseTime.春季, 38);
                listBox1.Items.Add(course3.Print());
            };
        }
    }

    //（1）
    enum CourseTime{
        春季,
        秋季
    }

    //（2）
    class CourseInfo{
        public string CourseName { get; set; }


        public CourseTime CourseSemester;


        public string BookName { get; set; }


        public double Price { get; set; }

        public static int Counter = 0;

        public CourseInfo() {
            Counter++;
            CourseName = BookName = "<null>";
            CourseSemester = CourseTime.春季;
            Price = 0;
        }

        public CourseInfo(string couseName, string bookName, CourseTime courseSemester, int price) {
            Counter++;
            CourseName = couseName;
            BookName = bookName;
            CourseSemester = courseSemester;
            Price = price;
        }

        public string Print() {
            return $"{CourseName,-10}{CourseSemester,-10}{BookName,-10}{Price,10}";
        }
    }
}