using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24History1 : I12Icon24Generic<I12Icon24History1>
    {
        static I12Icon24History1()
        {
            Point[] pointArray1 = [new Point(18, 15), new Point(18, 18), new Point(21, 18)];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 140, 140, 200));
            SolidColorBrush solidColorBrush2 = new(Color.FromArgb(255, 100, 100, 180));
            SolidColorBrush solidColorBrush3 = new(Color.FromArgb(255, 245, 245, 255));
            SolidColorBrush solidColorBrush4 = new(Color.FromArgb(255, 0, 200, 255));
            solidColorBrush1.Freeze();
            solidColorBrush2.Freeze();
            solidColorBrush3.Freeze();
            solidColorBrush4.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                using (StreamGeometryContext streamGeometryContext = streamGeometry1.Open())
                {
                    streamGeometryContext.BeginFigure(pointArray1[0], false, false);
                    streamGeometryContext.PolyLineTo(pointArray1, true, false);
                }
                streamGeometry1.Freeze();
                drawingContext.DrawRoundedRectangle(solidColorBrush1, null, new Rect(3, 2, 18, 20), 2, 2);
                drawingContext.DrawRectangle(solidColorBrush2, null, new Rect(7, 1, 10, 4));
                drawingContext.DrawRectangle(solidColorBrush3, null, new Rect(7, 7, 10, 2));
                drawingContext.DrawRectangle(solidColorBrush3, null, new Rect(7, 11, 6, 2));
                drawingContext.DrawRectangle(solidColorBrush3, null, new Rect(7, 15, 4, 2));
                drawingContext.DrawEllipse(solidColorBrush4, null, new Point(18, 18), 6, 6);
                drawingContext.DrawRectangle(solidColorBrush3, null, new Rect(7, 15, 4, 2));
                drawingContext.DrawRectangle(solidColorBrush3, null, new Rect(7, 15, 4, 2));
                drawingContext.DrawRoundedRectangle(solidColorBrush3, null, new Rect(17, 15, 2, 4), 1, 1);
                drawingContext.DrawRoundedRectangle(solidColorBrush3, null, new Rect(17, 17, 4, 2), 1, 1);
            }
            iconSource.Freeze();
        }
    }
}