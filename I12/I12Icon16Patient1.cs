using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon16Patient1 : I12Icon16Generic<I12Icon16Patient1>
    {
        static I12Icon16Patient1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 50, 180, 120));
            SolidColorBrush solidColorBrush2 = new(Color.FromArgb(255, 30, 120, 80));
            SolidColorBrush solidColorBrush3 = new(Color.FromArgb(255, 255, 255, 255));
            Pen pen1 = new(solidColorBrush2, 1);
            solidColorBrush1.Freeze();
            solidColorBrush2.Freeze();
            solidColorBrush3.Freeze();
            pen1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                StreamGeometry streamGeometry2 = new();
                StreamGeometry streamGeometry3 = new();
                using (StreamGeometryContext streamGeometryContext = streamGeometry1.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(0, 13), true, true);
                    streamGeometryContext.ArcTo(new Point(11, 13), new Size(5.5, 5.5), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext.LineTo(new Point(11, 15), false, true);
                    streamGeometryContext.ArcTo(new Point(10, 16), new Size(1, 1), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext.LineTo(new Point(1, 16), false, true);
                    streamGeometryContext.ArcTo(new Point(0, 15), new Size(1, 1), 0, false, SweepDirection.Clockwise, false, true);
                }
                using (StreamGeometryContext streamGeometryContext = streamGeometry2.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(15, 0), true, true);
                    streamGeometryContext.ArcTo(new Point(16, 1), new Size(1, 1), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext.LineTo(new Point(16, 5), false, true);
                    streamGeometryContext.ArcTo(new Point(11, 5), new Size(2.5, 2.5), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext.LineTo(new Point(11, 1), false, true);
                    streamGeometryContext.ArcTo(new Point(12, 0), new Size(1, 1), 0, false, SweepDirection.Clockwise, false, true);
                }
                using (StreamGeometryContext streamGeometryContext = streamGeometry3.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(13.5, 6), false, false);
                    streamGeometryContext.LineTo(new Point(13.5, 12), true, true);
                    streamGeometryContext.ArcTo(new Point(11, 14.5), new Size(2.5, 2.5), 0, false, SweepDirection.Clockwise, true, true);
                }
                streamGeometry1.Freeze();
                streamGeometry2.Freeze();
                streamGeometry3.Freeze();
                drawingContext.DrawEllipse(solidColorBrush1, null, new Point(5.5, 5.5), 3.5, 3.5);
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry1);
                drawingContext.DrawGeometry(solidColorBrush2, null, streamGeometry2);
                drawingContext.DrawGeometry(null, pen1, streamGeometry3);
                drawingContext.DrawRectangle(solidColorBrush3, null, new Rect(12, 3, 3, 1));
                drawingContext.DrawRectangle(solidColorBrush3, null, new Rect(13, 2, 1, 3));
            }
            iconSource.Freeze();
        }
    }
}