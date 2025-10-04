using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon16Password1 : I12Icon16Generic<I12Icon16Password1>
    {
        static I12Icon16Password1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 255, 255, 255));
            Pen pen1 = new(solidColorBrush1, 2);
            solidColorBrush1.Freeze();
            pen1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                using (StreamGeometryContext streamGeometryContext1 = streamGeometry1.Open())
                {
                    streamGeometryContext1.BeginFigure(new Point(5, 7), false, false);
                    streamGeometryContext1.LineTo(new Point(5, 5), true, true);
                    streamGeometryContext1.ArcTo(new Point(11, 5), new Size(3, 3), 0, false, SweepDirection.Clockwise, true, true);
                    streamGeometryContext1.LineTo(new Point(11, 7), true, true);
                }
                streamGeometry1.Freeze();
                drawingContext.DrawRoundedRectangle(solidColorBrush1, null, new Rect(3, 7, 10, 7), 1, 1);
                drawingContext.DrawGeometry(null, pen1, streamGeometry1);
            }
            iconSource.Freeze();
        }
    }
}