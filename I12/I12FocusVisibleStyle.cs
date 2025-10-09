using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace I12
{
    public static class I12FocusVisibleStyle
    {
        public static readonly Style Style1 = new(typeof(Control));
        public static readonly Style Style2 = new(typeof(Control));

        static I12FocusVisibleStyle()
        {
            InitializeFocusVisibleStyle1();
            InitializeFocusVisibleStyle2();
        }

        private static void InitializeFocusVisibleStyle1()
        {
            ControlTemplate controlTemplate = new(typeof(Control));
            FrameworkElementFactory rectangle = new(typeof(Border));
            controlTemplate.VisualTree = rectangle;
            controlTemplate.Seal();
            Style1.Setters.Add(new Setter(UIElement.SnapsToDevicePixelsProperty, true));
            Style1.Setters.Add(new Setter(Control.TemplateProperty, controlTemplate));
            Style1.Seal();
        }

        private static void InitializeFocusVisibleStyle2()
        {
            double StrokeThickness = 2.0;
            SolidColorBrush stroke = new(Color.FromArgb(150, 0, 120, 210));
            ControlTemplate controlTemplate = new(typeof(Control));
            FrameworkElementFactory rectangle = new(typeof(Border));
            rectangle.SetValue(Shape.StrokeProperty, stroke);
            rectangle.SetValue(Shape.StrokeThicknessProperty, StrokeThickness);
            controlTemplate.VisualTree = rectangle;
            controlTemplate.Seal();
            Style2.Setters.Add(new Setter(UIElement.SnapsToDevicePixelsProperty, true));
            Style2.Setters.Add(new Setter(Control.TemplateProperty, controlTemplate));
            Style2.Seal();
        }
    }
}