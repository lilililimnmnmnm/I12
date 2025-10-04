using System.Windows;
using System.Windows.Media;


namespace I12
{
    public class I12Icon32Search1 : I12Icon32Generic<I12Icon32Search1>
    {
        static I12Icon32Search1()
        {
            SolidColorBrush solidColorBrush1 = new(Color.FromArgb(255, 0, 170, 220));
            solidColorBrush1.Freeze();
            Pen pen1 = new(solidColorBrush1, 3);
            pen1.Freeze();
            using (DrawingContext drawingContext = iconSource.Open())
            {
                drawingContext.DrawEllipse(null, pen1, new Point(15, 15), 11.5, 11.5);
                drawingContext.DrawLine(pen1, new Point(24, 24), new Point(30, 30));
            }
            iconSource.Freeze();
        }
    }
}