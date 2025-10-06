using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24Directory1 : I12Icon24Generic<I12Icon24Directory1>
    {
        static I12Icon24Directory1()
        {
            Point[] pointArray1 = [new Point(2, 6), new Point(3, 4), new Point(10, 4), new Point(12, 7), new Point(21, 7), new Point(22, 8), new Point(22, 19), new Point(21, 20), new Point(3, 20), new Point(2, 19)];
            Point[] pointArray2 = [new Point(2, 10), new Point(9, 10), new Point(12, 8), new Point(21, 8), new Point(21, 8), new Point(22, 9), new Point(22, 19), new Point(21, 20), new Point(3, 20), new Point(2, 19)];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 230, 140, 0));
            SolidColorBrush solidColorBrush2 = new(Color.FromArgb(255, 255, 180, 0));
            solidColorBrush1.Freeze();
            solidColorBrush2.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                StreamGeometry streamGeometry2 = new();
                using (StreamGeometryContext streamGeometryContext = streamGeometry1.Open())
                {
                    streamGeometryContext.BeginFigure(pointArray1[0], true, true);
                    streamGeometryContext.PolyLineTo(pointArray1, false, true);
                }
                using (StreamGeometryContext streamGeometryContext = streamGeometry2.Open())
                {
                    streamGeometryContext.BeginFigure(pointArray2[0], true, true);
                    streamGeometryContext.PolyLineTo(pointArray2, false, true);
                }
                streamGeometry1.Freeze();
                streamGeometry2.Freeze();
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry1);
                drawingContext.DrawGeometry(solidColorBrush2, null, streamGeometry2);
            }
            iconSource.Freeze();
        }
    }
}