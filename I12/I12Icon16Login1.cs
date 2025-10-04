using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon16Login1 : I12Icon16Generic<I12Icon16Login1>
    {
        static I12Icon16Login1()
        {
            Point[] pointArray1 = [new Point(4, 7), new Point(4, 9), new Point(7, 9), new Point(7, 11), new Point(10, 8), new Point(7, 5), new Point(7, 7)];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 255, 255, 255));
            Pen pen1 = new(solidColorBrush1, 2);
            solidColorBrush1.Freeze();
            pen1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                using (StreamGeometryContext streamGeometryContext1 = streamGeometry1.Open())
                {
                    streamGeometryContext1.BeginFigure(pointArray1[0], true, true);
                    streamGeometryContext1.PolyLineTo(pointArray1, false, true);
                }
                streamGeometry1.Freeze();
                drawingContext.DrawRoundedRectangle(null, pen1, new Rect(3, 3, 10, 10), 2, 2);
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry1);
            }
            iconSource.Freeze();
        }
    }
}