using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24Reset1 : I12Icon24Generic<I12Icon24Reset1>
    {
        static I12Icon24Reset1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 250, 140, 0));
            Pen pen1 = new(solidColorBrush1, 3);
            solidColorBrush1.Freeze();
            pen1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                StreamGeometry streamGeometry2 = new();
                StreamGeometry streamGeometry3 = new();
                StreamGeometry streamGeometry4 = new();
                using (StreamGeometryContext streamGeometryContext = streamGeometry1.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(6, 12), false, false);
                    streamGeometryContext.ArcTo(new Point(16.24, 7.76), new Size(6, 6), 0, false, SweepDirection.Clockwise, true, true);
                }
                using (StreamGeometryContext streamGeometryContext = streamGeometry2.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(18, 12), false, false);
                    streamGeometryContext.ArcTo(new Point(7.76, 16.24), new Size(6, 6), 0, false, SweepDirection.Clockwise, true, true);
                }
                using (StreamGeometryContext streamGeometryContext = streamGeometry3.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(3, 12), true, true);
                    streamGeometryContext.LineTo(new Point(9, 12), false, false);
                    streamGeometryContext.LineTo(new Point(6, 15), false, false);
                }
                using (StreamGeometryContext streamGeometryContext = streamGeometry4.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(21, 12), true, true);
                    streamGeometryContext.LineTo(new Point(15, 12), false, false);
                    streamGeometryContext.LineTo(new Point(18, 9), false, false);
                }
                streamGeometry1.Freeze();
                streamGeometry2.Freeze();
                streamGeometry3.Freeze();
                streamGeometry4.Freeze();
                drawingContext.DrawGeometry(null, pen1, streamGeometry1);
                drawingContext.DrawGeometry(null, pen1, streamGeometry2);
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry3);
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry4);
            }
            iconSource.Freeze();
        }
    }
}