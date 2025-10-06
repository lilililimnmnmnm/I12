using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon16FilterCancel1 : I12Icon16Generic<I12Icon16FilterCancel1>
    {
        static I12Icon16FilterCancel1()
        {
            Point[] pointArray1 = [new Point(0, 1), new Point(0, 2), new Point(4, 6), new Point(4, 12), new Point(7, 12), new Point(7, 6), new Point(11, 2), new Point(11, 1)];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 100, 100, 100));
            SolidColorBrush solidColorBrush2 = new(Color.FromArgb(255, 255, 100, 100));
            Pen pen1 = new(solidColorBrush2, 2.5);
            solidColorBrush1.Freeze();
            solidColorBrush2.Freeze();
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
                drawingContext.DrawLine(pen1, new Point(9, 9), new Point(15, 15));
                drawingContext.DrawLine(pen1, new Point(9, 15), new Point(15, 9));
            }
            iconSource.Freeze();
        }
    }
}