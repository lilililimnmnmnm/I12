using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon16Calendar1 : I12Icon16Generic<I12Icon16Calendar1>
    {
        static I12Icon16Calendar1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 50, 120, 200));
            SolidColorBrush solidColorBrush2 = new(Color.FromArgb(255, 120, 160, 220));
            SolidColorBrush solidColorBrush3 = new(Color.FromArgb(255, 180, 180, 200));
            SolidColorBrush solidColorBrush4 = new(Color.FromArgb(255, 220, 240, 255));
            solidColorBrush1.Freeze();
            solidColorBrush2.Freeze();
            solidColorBrush3.Freeze();
            solidColorBrush4.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                StreamGeometry streamGeometry1 = new();
                StreamGeometry streamGeometry2 = new();
                using (StreamGeometryContext streamGeometryContext = streamGeometry1.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(0, 3.5), true, true);
                    streamGeometryContext.ArcTo(new Point(1.5, 2), new Size(1.5, 1.5), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext.LineTo(new Point(14.5, 2), false, true);
                    streamGeometryContext.ArcTo(new Point(16, 3.5), new Size(1.5, 1.5), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext.LineTo(new Point(16, 6), false, true);
                    streamGeometryContext.LineTo(new Point(0, 6), false, true);
                }
                using (StreamGeometryContext streamGeometryContext = streamGeometry2.Open())
                {
                    streamGeometryContext.BeginFigure(new Point(0, 6), true, true);
                    streamGeometryContext.LineTo(new Point(16, 6), false, true);
                    streamGeometryContext.LineTo(new Point(16, 14.5), false, true);
                    streamGeometryContext.ArcTo(new Point(14.5, 16), new Size(1.5, 1.5), 0, false, SweepDirection.Clockwise, false, true);
                    streamGeometryContext.LineTo(new Point(1.5, 16), false, true);
                    streamGeometryContext.ArcTo(new Point(0, 14.5), new Size(1.5, 1.5), 0, false, SweepDirection.Clockwise, false, true);
                }
                streamGeometry1.Freeze();
                streamGeometry2.Freeze();
                drawingContext.DrawGeometry(solidColorBrush1, null, streamGeometry1);
                drawingContext.DrawGeometry(solidColorBrush2, null, streamGeometry2);
                drawingContext.DrawRectangle(solidColorBrush3, null, new Rect(3, 0, 2, 4));
                drawingContext.DrawRectangle(solidColorBrush3, null, new Rect(11, 0, 2, 4));
                drawingContext.DrawRectangle(solidColorBrush4, null, new Rect(3, 8, 2, 2));
                drawingContext.DrawRectangle(solidColorBrush4, null, new Rect(3, 11, 2, 2));
                drawingContext.DrawRectangle(solidColorBrush4, null, new Rect(7, 8, 2, 2));
                drawingContext.DrawRectangle(solidColorBrush4, null, new Rect(7, 11, 2, 2));
                drawingContext.DrawRectangle(solidColorBrush4, null, new Rect(11, 8, 2, 2));
                drawingContext.DrawRectangle(solidColorBrush4, null, new Rect(11, 11, 2, 2));
            }
            iconSource.Freeze();
        }
    }
}