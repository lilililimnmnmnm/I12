using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24Setting1 : I12Icon24Generic<I12Icon24Setting1>
    {
        static I12Icon24Setting1()
        {
            Point[] pointArray1 = [
                new Point(1, 10),
                new Point(1, 14),
                new Point(4.29, 15.2),
                new Point(2.81, 18.36),
                new Point(5.64, 21.19),
                new Point(8.8, 19.71),
                new Point(10, 23),
                new Point(14, 23),
                new Point(15.2, 19.71),
                new Point(18.36, 21.19),
                new Point(21.19, 18.36),
                new Point(19.71, 15.2),
                new Point(23, 14),
                new Point(23, 10),
                new Point(19.71, 8.8),
                new Point(21.19, 5.64),
                new Point(18.36, 2.81),
                new Point(15.2, 4.29),
                new Point(14, 1),
                new Point(10, 1),
                new Point(8.8, 4.29),
                new Point(5.64, 2.81),
                new Point(2.81, 5.64),
                new Point(4.29,8.8)
            ];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 180, 180, 180));
            SolidColorBrush solidColorBrush2 = new(Color.FromArgb(255, 255, 255, 255));
            SolidColorBrush solidColorBrush3 = new(Color.FromArgb(255, 150, 150, 150));
            Pen pen1 = new(solidColorBrush3, 2);
            solidColorBrush1.Freeze();
            solidColorBrush2.Freeze();
            solidColorBrush3.Freeze();
            pen1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                using (StreamGeometryContext streamGeometryContext = streamGeometry1.Open())
                {
                    streamGeometryContext.BeginFigure(pointArray1[0], true, true);
                    streamGeometryContext.PolyLineTo(pointArray1, false, false);
                }
                streamGeometry1.Freeze();
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry1);
                drawingContext.DrawEllipse(solidColorBrush1, null, new Point(12, 12), 9, 9);
                drawingContext.DrawEllipse(solidColorBrush2, pen1, new Point(12, 12), 4, 4);
            }
            iconSource.Freeze();
        }
    }
}