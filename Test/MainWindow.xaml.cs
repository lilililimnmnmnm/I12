using I12;
using System.Windows;

namespace Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void I12Icon24Button1_Click1(object sender, RoutedEventArgs e)
        {
            I12MessageManager.ShowMessage("[Notify] My Message");
        }

        private void I12Icon24Button1_Click2(object sender, RoutedEventArgs e)
        {
            I12MessageManager.ShowImportantMessage("[Alert] My Message");
        }

        private void I12Icon24Button1_Click3(object sender, RoutedEventArgs e)
        {
            I12MessageManager.ShowErrorMessage("[Error] My Message");
        }
    }
}