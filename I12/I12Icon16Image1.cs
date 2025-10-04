using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon16Image1 : I12Icon16Generic<I12Icon16Image1>
    {
        static I12Icon16Image1()
        {
            Point[] pointArray1 = [new Point(1, 10), new Point(1, 14), new Point(15, 14), new Point(15, 11), new Point(13, 10), new Point(11, 11), new Point(6, 7)];
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
                using (StreamGeometryContext streamGeometryContext1 = streamGeometry1.Open())
                {
                    streamGeometryContext1.BeginFigure(pointArray1[0], true, true);
                    streamGeometryContext1.PolyLineTo(pointArray1, false, true);
                }
                streamGeometry1.Freeze();
                drawingContext.DrawRectangle(solidColorBrush1, null, new Rect(1, 2, 14, 12));
                drawingContext.DrawEllipse(solidColorBrush2, null, new Point(11.5, 5.5), 1.5, 1.5);
                drawingContext.DrawGeometry(solidColorBrush3, null, streamGeometry1);
                drawingContext.DrawRoundedRectangle(null, pen1, new Rect(0.5, 1.5, 15, 13), 1, 1);
            }
            iconSource.Freeze();
        }
    }
}