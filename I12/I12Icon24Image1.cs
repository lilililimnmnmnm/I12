using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24Image1 : I12Icon24Generic<I12Icon24Image1>
    {
        static I12Icon24Image1()
        {
            Point[] pointArray1 = [new Point(2, 20), new Point(22, 20), new Point(22, 16), new Point(18, 14), new Point(15, 15), new Point(8, 10), new Point(2, 16)];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 160, 200, 255));
            SolidColorBrush solidColorBrush2 = new(Color.FromArgb(255, 255, 255, 255));
            SolidColorBrush solidColorBrush3 = new(Color.FromArgb(255, 80, 120, 200));
            Pen pen1 = new(solidColorBrush3, 1);
            solidColorBrush1.Freeze();
            solidColorBrush2.Freeze();
            solidColorBrush3.Freeze();
            pen1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                using (StreamGeometryContext streamGeometryContext = streamGeometry1.Open())
                {
                    streamGeometryContext.BeginFigure(pointArray1[0], true, true);
                    streamGeometryContext.PolyLineTo(pointArray1, false, true);
                }
                streamGeometry1.Freeze();
                drawingContext.DrawRectangle(solidColorBrush1, null, new Rect(2, 4, 20, 16));
                drawingContext.DrawEllipse(solidColorBrush2, null, new Point(16, 8), 2, 2);
                drawingContext.DrawGeometry(solidColorBrush3, null, streamGeometry1);
                drawingContext.DrawRoundedRectangle(null, pen1, new Rect(1.5, 3.5, 21, 17), 2, 2);
            }
            iconSource.Freeze();
        }
    }
}