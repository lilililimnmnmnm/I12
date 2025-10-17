using I12;
using System.Windows;
using System.Windows.Media;

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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (ColorR is not null &&
                ColorG is not null &&
                ColorB is not null &&
                overlayEffect is not null)
                overlayEffect.C0 = Color.FromArgb(255, (byte)(int)ColorR.Value, (byte)(int)ColorG.Value, (byte)(int)ColorB.Value);
        }
    }
}