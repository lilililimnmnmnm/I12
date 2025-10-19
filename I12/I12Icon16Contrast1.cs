using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon16Contrast1 : I12Icon16Generic<I12Icon16Contrast1>
    {
        static I12Icon16Contrast1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 50, 50, 50));
            SolidColorBrush solidColorBrush2 = new(Color.FromArgb(255, 255, 255, 255));
            solidColorBrush1.Freeze();
            solidColorBrush2.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                using (StreamGeometryContext streamGeometryContext = streamGeometry1.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(8, 2), true, true);
                    streamGeometryContext.ArcTo(new Point(8, 14), new Size(6, 6), 0, false, SweepDirection.Clockwise, false, false);
                }
                streamGeometry1.Freeze();
                drawingContext.DrawEllipse(solidColorBrush1, null, new Point(8, 8), 8, 8);
                drawingContext.DrawGeometry(solidColorBrush2, null, streamGeometry1);
            }
            iconSource.Freeze();
        }
    }
}