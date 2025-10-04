using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24Wait1 : I12Icon24Generic<I12Icon24Wait1>
    {
        static I12Icon24Wait1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 127, 127, 127));
            solidColorBrush1.Freeze();
            using (DrawingContext drawingContext = IconSource.Open())
            {
                drawingContext.DrawEllipse(solidColorBrush1, null, new Point(6, 12), 2, 2);
                drawingContext.DrawEllipse(solidColorBrush1, null, new Point(12, 12), 2, 2);
                drawingContext.DrawEllipse(solidColorBrush1, null, new Point(18, 12), 2, 2);
            }
            IconSource.Freeze();
        }
    }
}