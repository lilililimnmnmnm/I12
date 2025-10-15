using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon16Warning1 : I12Icon16Generic<I12Icon16Warning1>
    {
        static I12Icon16Warning1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 240, 50, 50));
            SolidColorBrush solidColorBrush2 = new(Color.FromArgb(255, 255, 255, 255));
            solidColorBrush1.Freeze();
            solidColorBrush2.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                using (StreamGeometryContext streamGeometryContext = streamGeometry1.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(7.01, -1.74), true, true);
                    streamGeometryContext.LineTo(new Point(15.01, 12.26), false, false);
                    streamGeometryContext.QuadraticBezierTo(new Point(16, 14), new Point(14, 14), false, false);
                    streamGeometryContext.LineTo(new Point(2, 14), false, false);
                    streamGeometryContext.QuadraticBezierTo(new Point(0, 14), new Point(0.99, 12.26), false, false);
                    streamGeometryContext.LineTo(new Point(7.01, 1.74), false, false);
                    streamGeometryContext.QuadraticBezierTo(new Point(8, 0), new Point(8.99, 1.74), false, false);
                }
                streamGeometry1.Freeze();
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry1);
                drawingContext.DrawRectangle(solidColorBrush2, null, new Rect(7, 5, 2, 4));
                drawingContext.DrawRectangle(solidColorBrush2, null, new Rect(7, 10, 2, 2));
            }
            iconSource.Freeze();
        }
    }
}