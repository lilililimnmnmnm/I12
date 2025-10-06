using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24Cancel1 : I12Icon24Generic<I12Icon24Cancel1>
    {
        static I12Icon24Cancel1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 255, 100, 100));
            Pen pen1 = new(solidColorBrush1, 3);
            solidColorBrush1.Freeze();
            pen1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                drawingContext.DrawLine(pen1, new Point(6, 6), new Point(18, 18));
                drawingContext.DrawLine(pen1, new Point(6, 18), new Point(18, 6));
            }
            iconSource.Freeze();
        }
    }
}