using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon16Tag1 : I12Icon16Generic<I12Icon16Tag1>
    {
        static I12Icon16Tag1()
        {
            Point[] pointArray1 = [new Point(0, 9), new Point(4, 13), new Point(12, 5), new Point(12, 1), new Point(8, 1)];
            Point[] pointArray2 = [new Point(8, 15), new Point(14, 15), new Point(14, 5), new Point(11, 2), new Point(8, 5)];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 255, 100, 0));
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
