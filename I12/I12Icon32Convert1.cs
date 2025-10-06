using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon32Convert1 : I12Icon32Generic<I12Icon32Convert1>
    {
        static I12Icon32Convert1()
        {
            Point[] pointArray1 = [new Point(4, 10), new Point(1, 14), new Point(31, 14), new Point(20, 4), new Point(20, 10),];
            Point[] pointArray2 = [new Point(28, 22), new Point(31, 18), new Point(1, 18), new Point(12, 28), new Point(12, 22),];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 120, 50, 180));
            solidColorBrush1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                StreamGeometry streamGeometry2 = new();
                using (StreamGeometryContext streamGeometryContext = streamGeometry1.Open())
                {
                    streamGeometryContext.BeginFigure(pointArray1[0], true, true);
                    streamGeometryContext.PolyLineTo(pointArray1, false, false);
                }
                using (StreamGeometryContext streamGeometryContext = streamGeometry2.Open())
                {
                    streamGeometryContext.BeginFigure(pointArray2[0], true, true);
                    streamGeometryContext.PolyLineTo(pointArray2, false, false);
                }
                streamGeometry1.Freeze();
                streamGeometry2.Freeze();
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry1);
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry2);
            }
            iconSource.Freeze();
        }
    }
}