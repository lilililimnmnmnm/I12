using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon16Reset1 : I12Icon16Generic<I12Icon16Reset1>
    {
        static I12Icon16Reset1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 250, 140, 0));
            Pen pen1 = new(solidColorBrush1, 2);
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
                    streamGeometryContext.BeginFigure(new Point(3, 8), false, false);
                    streamGeometryContext.ArcTo(new Point(11.54, 4.46), new Size(5, 5), 0, false, SweepDirection.Clockwise, true, true);
                }
                using (StreamGeometryContext streamGeometryContext = streamGeometry2.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(13, 8), false, false);
                    streamGeometryContext.ArcTo(new Point(4.46, 11.54), new Size(5, 5), 0, false, SweepDirection.Clockwise, true, true);
                }
                using (StreamGeometryContext streamGeometryContext = streamGeometry3.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(1, 8), true, true);
                    streamGeometryContext.LineTo(new Point(5, 8), false, false);
                    streamGeometryContext.LineTo(new Point(3, 10), false, false);
                }
                using (StreamGeometryContext streamGeometryContext = streamGeometry4.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(15, 8), true, true);
                    streamGeometryContext.LineTo(new Point(11, 8), false, false);
                    streamGeometryContext.LineTo(new Point(13, 6), false, false);
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