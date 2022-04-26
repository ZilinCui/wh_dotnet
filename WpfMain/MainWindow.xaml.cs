using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace WpfMain{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow{
        public MainWindow() {
            InitializeComponent();

            frame1.Navigating += delegate { stackPanelLeft.Cursor = frame1.Cursor = Cursors.AppStarting; };
            frame1.ContentRendered += delegate { stackPanelLeft.Cursor = frame1.Cursor = Cursors.Arrow; };
            this.StateChanged += delegate {
                if (WindowState == WindowState.Maximized) {
                    gridTitle.Height = 80;
                    txtTitle.FontSize = 24;
                }
                else {
                    gridTitle.Height = 20;
                    txtTitle.FontSize = 12;
                }
            };
        }

        public string LoginName { get; set; }
        private Button lastButton = null;

        private void SetExpanded(bool isExpanded) {
            foreach (var v in stackPanelLeft.Children) {
                if (v is Expander expander) {
                    expander.IsExpanded = isExpanded;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if (lastButton != null) {
                lastButton.Foreground = Brushes.Blue;
            }

            Button btn = e.Source as Button;
            string content = btn.Content.ToString();
            switch (content) {
                case "默认页":
                    frame1.Source = new Uri("DefaultPage.xaml", UriKind.Relative);
                    return;
                case "全部展开":
                    SetExpanded(true);
                    return;
                case "全部折叠":
                    SetExpanded(false);
                    return;
            }

            stackPanelLeft.Cursor = frame1.Cursor = Cursors.Wait;

            btn.Foreground = Brushes.Red;
            Uri uri = new Uri(btn.Tag.ToString(), UriKind.Relative);
            object obj = null;
            try {
                obj = Application.LoadComponent(uri);
            }
            catch {
                stackPanelLeft.Cursor = frame1.Cursor = Cursors.Arrow;

                MessageBox.Show("未找到 " + uri.OriginalString, "出错了", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (obj is Window) {
                frame1.Source = null;
                var w = obj as Window;
                w.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                w.ShowDialog();
            }
            else if (obj is Page) {
                if (lastButton == btn) frame1.Refresh();
                else frame1.Source = uri;
            }
            else {
                MessageBox.Show("不支持此类型，注意目标必须是Window或者Page。", "出错了", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            stackPanelLeft.Cursor = frame1.Cursor = Cursors.Arrow;
            lastButton = btn;
        }
    }
}