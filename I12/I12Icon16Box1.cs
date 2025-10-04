using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon16Box1 : I12Icon16Generic<I12Icon16Box1>
    {
        static I12Icon16Box1()
        {
            Point[] pointArray1 = [new Point(1, 4), new Point(8, 2), new Point(15, 4), new Point(15, 12), new Point(8, 14), new Point(1, 12)];
            Point[] pointArray2 = [new Point(1, 4), new Point(8, 6), new Point(8, 14), new Point(1, 12)];
            Point[] pointArray3 = [new Point(15, 4), new Point(8, 6), new Point(8, 14), new Point(15, 12)];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 255, 120, 120));
            SolidColorBrush solidColorBrush2 = new(Color.FromArgb(255, 255, 80, 80));
            SolidColorBrush solidColorBrush3 = new(Color.FromArgb(255, 255, 60, 60));
            solidColorBrush1.Freeze();
            solidColorBrush2.Freeze();
            solidColorBrush3.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                StreamGeometry streamGeometry2 = new();
                StreamGeometry streamGeometry3 = new();
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
                using (StreamGeometryContext streamGeometryContext3 = streamGeometry3.Open())
                {
                    streamGeometryContext3.BeginFigure(pointArray3[0], true, true);
                    streamGeometryContext3.PolyLineTo(pointArray3, false, true);
                }
                streamGeometry1.Freeze();
                streamGeometry2.Freeze();
                streamGeometry3.Freeze();
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry1);
                drawingContext.DrawGeometry(solidColorBrush2, null, streamGeometry2);
                drawingContext.DrawGeometry(solidColorBrush3, null, streamGeometry3);
            }
            iconSource.Freeze();
        }
    }
}