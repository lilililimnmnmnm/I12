using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon16Information1 : I12Icon16Generic<I12Icon16Information1>
    {
        static I12Icon16Information1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 0, 170, 220));
            SolidColorBrush solidColorBrush2 = new(Color.FromArgb(255, 255, 255, 255));
            solidColorBrush1.Freeze();
            solidColorBrush2.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                drawingContext.DrawEllipse(solidColorBrush1, null, new Point(8, 8), 8, 8);
                drawingContext.DrawRectangle(solidColorBrush2, null, new Rect(7, 3, 2, 2));
                drawingContext.DrawRectangle(solidColorBrush2, null, new Rect(7, 7, 2, 5));
            }
            iconSource.Freeze();
        }
    }
}