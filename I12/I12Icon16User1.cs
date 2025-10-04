using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon16User1 : I12Icon16Generic<I12Icon16User1>
    {
        static I12Icon16User1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 255, 255, 255));
            solidColorBrush1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                using (StreamGeometryContext streamGeometryContext1 = streamGeometry1.Open())
                {
                    streamGeometryContext1.BeginFigure(new Point(3, 12), true, true);
                    streamGeometryContext1.ArcTo(new Point(13, 12), new Size(5, 5), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext1.ArcTo(new Point(13, 13), new Size(5, 5), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext1.ArcTo(new Point(12, 14), new Size(1, 1), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext1.LineTo(new Point(4, 14), false, true);
                    streamGeometryContext1.ArcTo(new Point(3, 13), new Size(1, 1), 0, false, SweepDirection.Clockwise, false, true);
                }
                streamGeometry1.Freeze();
                drawingContext.DrawEllipse(solidColorBrush1, null, new Point(8, 5), 3, 3);
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry1);
            }
            iconSource.Freeze();
        }
    }
}