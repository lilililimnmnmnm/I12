using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24Confirm1 : I12Icon24Generic<I12Icon24Confirm1>
    {
        static I12Icon24Confirm1()
        {
            Point[] pointArray1 = [new Point(5, 11), new Point(10, 16), new Point(19, 7)];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 50, 170, 120));
            Pen pen1 = new(solidColorBrush1, 3);
            solidColorBrush1.Freeze();
            pen1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                using (StreamGeometryContext streamGeometryContext = streamGeometry1.Open())
                {
                    streamGeometryContext.BeginFigure(pointArray1[0], false, false);
                    streamGeometryContext.PolyLineTo(pointArray1, true, false);
                }
                streamGeometry1.Freeze();
                drawingContext.DrawGeometry(null, pen1, streamGeometry1);
            }
            iconSource.Freeze();
        }
    }
}