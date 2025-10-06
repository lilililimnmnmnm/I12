using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24Patient1 : I12Icon24Generic<I12Icon24Patient1>
    {
        static I12Icon24Patient1()
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
                    streamGeometryContext.BeginFigure(new Point(1, 18), true, true);
                    streamGeometryContext.ArcTo(new Point(14, 18), new Size(6.5, 6.5), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext.LineTo(new Point(14, 22), false, true);
                    streamGeometryContext.ArcTo(new Point(13, 23), new Size(1, 1), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext.LineTo(new Point(2, 23), false, true);
                    streamGeometryContext.ArcTo(new Point(1, 22), new Size(1, 1), 0, false, SweepDirection.Clockwise, false, true);
                }
                using (StreamGeometryContext streamGeometryContext = streamGeometry2.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(22, 2), true, true);
                    streamGeometryContext.ArcTo(new Point(23, 3), new Size(1, 1), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext.LineTo(new Point(23, 9), false, true);
                    streamGeometryContext.ArcTo(new Point(20, 12), new Size(3, 3), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext.LineTo(new Point(19, 12), false, true);
                    streamGeometryContext.ArcTo(new Point(16, 9), new Size(3, 3), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext.LineTo(new Point(16, 3), false, true);
                    streamGeometryContext.ArcTo(new Point(17, 2), new Size(1, 1), 0, false, SweepDirection.Clockwise, false, true);
                }
                using (StreamGeometryContext streamGeometryContext = streamGeometry3.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(19.5, 11), false, false);
                    streamGeometryContext.LineTo(new Point(19.5, 17.5), true, true);
                    streamGeometryContext.ArcTo(new Point(15.5, 21.5), new Size(4, 4), 0, false, SweepDirection.Clockwise, true, true);
                    streamGeometryContext.LineTo(new Point(14, 21.5), true, true);
                }
                streamGeometry1.Freeze();
                streamGeometry2.Freeze();
                streamGeometry3.Freeze();
                drawingContext.DrawEllipse(solidColorBrush1, null, new Point(7.5, 8), 4, 4);
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry1);
                drawingContext.DrawGeometry(solidColorBrush2, null, streamGeometry2);
                drawingContext.DrawGeometry(null, pen1, streamGeometry3);
                drawingContext.DrawRectangle(solidColorBrush3, null, new Rect(17, 6, 5, 1));
                drawingContext.DrawRectangle(solidColorBrush3, null, new Rect(19, 4, 1, 5));
            }
            iconSource.Freeze();
        }
    }
}