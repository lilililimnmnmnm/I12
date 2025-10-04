using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24Skip1 : I12Icon24Generic<I12Icon24Skip1>
    {
        static I12Icon24Skip1()
        {
            Point[] pointArray1 = [new Point(6, 6), new Point(6, 18), new Point(12, 14), new Point(12, 18), new Point(20, 12), new Point(12, 6), new Point(12, 10)];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 0, 170, 220));
            solidColorBrush1.Freeze();
            using (DrawingContext drawingContext = IconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                using (StreamGeometryContext streamGeometryContext1 = streamGeometry1.Open())
                {
                    streamGeometryContext1.BeginFigure(pointArray1[0], true, true);
                    streamGeometryContext1.PolyLineTo(pointArray1, true, false);
                }
                streamGeometry1.Freeze();
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry1);
            }
            IconSource.Freeze();
        }
    }
}