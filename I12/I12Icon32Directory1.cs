using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon32Directory1 : I12Icon32Generic<I12Icon32Directory1>
    {
        static I12Icon32Directory1()
        {
            Point[] pointArray1 = [new Point(9, 4), new Point(3, 4), new Point(1, 6), new Point(1, 28), new Point(27, 28), new Point(27, 8), new Point(15, 8)];
            Point[] pointArray2 = [new Point(27, 28), new Point(31, 12), new Point(5, 12), new Point(1, 28)];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 230, 140, 0));
            SolidColorBrush solidColorBrush2 = new(Color.FromArgb(255, 255, 180, 0));
            solidColorBrush1.Freeze();
            solidColorBrush2.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                StreamGeometry streamGeometry2 = new();
                using (StreamGeometryContext streamGeometryContext1 = streamGeometry1.Open())
                {
                    streamGeometryContext1.BeginFigure(pointArray1[0], true, true);
                    streamGeometryContext1.PolyLineTo(pointArray1, false, true);
                }
                using (StreamGeometryContext streamGeometryContext2 = streamGeometry2.Open())
                {
                    streamGeometryContext2.BeginFigure(pointArray2[0], true, true);
                    streamGeometryContext2.PolyLineTo(pointArray2, false, true);
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