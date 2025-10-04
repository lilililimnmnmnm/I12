using I12;
using System.Windows;
using System.Windows.Input;

namespace Test
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void I12MessageControl1_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            I12MessageManager.ShowErrorMessage("[Error] My Message");
        }
    }
}