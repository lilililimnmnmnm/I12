using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon32Confirm1 : I12Icon32Generic<I12Icon32Confirm1>
    {
        static I12Icon32Confirm1()
        {
            Point[] pointArray1 = [new Point(5, 15), new Point(13, 23), new Point(27, 9),];
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 50, 170, 120));
            Pen pen1 = new(solidColorBrush1, 4);
            solidColorBrush1.Freeze();
            pen1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                using (StreamGeometryContext streamGeometryContext1 = streamGeometry1.Open())
                {
                    streamGeometryContext1.BeginFigure(pointArray1[0], false, false);
                    streamGeometryContext1.PolyLineTo(pointArray1, true, false);
                }
                streamGeometry1.Freeze();
                drawingContext.DrawGeometry(null, pen1, streamGeometry1);
            }
            iconSource.Freeze();
        }
    }
}