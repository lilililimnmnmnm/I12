using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon32Cancel1 : I12Icon32Generic<I12Icon32Cancel1>
    {
        static I12Icon32Cancel1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 255, 100, 100));
            Pen pen1 = new(solidColorBrush1, 4);
            solidColorBrush1.Freeze();
            pen1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                drawingContext.DrawLine(pen1, new Point(6, 6), new Point(26, 26));
                drawingContext.DrawLine(pen1, new Point(6, 26), new Point(26, 6));
            }
            iconSource.Freeze();
        }
    }
}