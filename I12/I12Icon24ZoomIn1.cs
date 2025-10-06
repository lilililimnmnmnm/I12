using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24ZoomIn1 : I12Icon24Generic<I12Icon24ZoomIn1>
    {
        static I12Icon24ZoomIn1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 50, 170, 120));
            Pen pen1 = new(solidColorBrush1, 2.5);
            solidColorBrush1.Freeze();
            pen1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                drawingContext.DrawEllipse(null, pen1, new Point(11, 11), 6, 6);
                drawingContext.DrawLine(pen1, new Point(15, 15), new Point(20, 20));
                drawingContext.DrawRoundedRectangle(solidColorBrush1, null, new Rect(8, 10, 6, 2), 1, 1);
                drawingContext.DrawRoundedRectangle(solidColorBrush1, null, new Rect(10, 8, 2, 6), 1, 1);
            }
            iconSource.Freeze();
        }
    }
}