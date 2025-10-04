using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24Success1 : I12Icon24Generic<I12Icon24Success1>
    {
        static I12Icon24Success1()
        {
            Point[] pointArray1 = [new Point(4, 12), new Point(9, 17), new Point(18, 8)];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 50, 180, 120));
            Pen pen1 = new(solidColorBrush1, 3);
            solidColorBrush1.Freeze();
            pen1.Freeze();
            using (DrawingContext drawingContext = IconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                using (StreamGeometryContext streamGeometryContext1 = streamGeometry1.Open())
                {
                    streamGeometryContext1.BeginFigure(pointArray1[0], false, false);
                    streamGeometryContext1.PolyLineTo(pointArray1, true, false);
                }
                streamGeometry1.Freeze();
                drawingContext.DrawGeometry(null, pen1, streamGeometry1);
            }
            IconSource.Freeze();
        }
    }
}