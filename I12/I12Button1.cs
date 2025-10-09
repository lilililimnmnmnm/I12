using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace I12
{
    public partial class I12Button1 : Button
    {
        private static readonly Style style = new(typeof(I12Button1));
        private static readonly Thickness thickness = new(0);
        private static readonly Thickness borderThickness = new(0, 0, 0, 2);
        private static readonly SolidColorBrush defaultBackgroundColor = new(Color.FromArgb(0, 0, 0, 0));
        private static readonly SolidColorBrush defaultBorderColor = new(Color.FromArgb(255, 200, 200, 200));
        private static readonly SolidColorBrush defaultForegroundColor = new(Color.FromArgb(255, 60, 70, 80));
        private static readonly SolidColorBrush mouseOverBackgroundColor = new(Color.FromArgb(150, 255, 255, 255));
        private static readonly SolidColorBrush mouseOverBorderColor = new(Color.FromArgb(255, 0, 120, 210));
        private static readonly SolidColorBrush mouseOverForegroundColor = new(Color.FromArgb(255, 0, 120, 210));

        static I12Button1()
        {
            defaultBackgroundColor.Freeze();
            defaultBorderColor.Freeze();
            defaultForegroundColor.Freeze();
            mouseOverBackgroundColor.Freeze();
            mouseOverBorderColor.Freeze();
            mouseOverForegroundColor.Freeze();
            ControlTemplate controlTemplate = new(typeof(I12Button1));
            FrameworkElementFactory border = new(typeof(Border));
            FrameworkElementFactory contentPresenter = new(typeof(ContentPresenter));
            Trigger trigger = new() { Property = IsMouseOverProperty, Value = true };
            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(BackgroundProperty));
            border.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(BorderBrushProperty));
            border.SetValue(Border.BorderThicknessProperty, new TemplateBindingExtension(BorderThicknessProperty));
            contentPresenter.SetValue(ContentProperty, new TemplateBindingExtension(ContentProperty));
            contentPresenter.SetValue(HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(VerticalAlignmentProperty, VerticalAlignment.Center);
            trigger.Setters.Add(new Setter(BackgroundProperty, mouseOverBackgroundColor));
            trigger.Setters.Add(new Setter(BorderBrushProperty, mouseOverBorderColor));
            trigger.Setters.Add(new Setter(ForegroundProperty, mouseOverForegroundColor));
            border.AppendChild(contentPresenter);
            controlTemplate.VisualTree = border;
            controlTemplate.Seal();
            style.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            style.Setters.Add(new Setter(FocusableProperty, false));
            style.Setters.Add(new Setter(IsTabStopProperty, false));
            style.Setters.Add(new Setter(BackgroundProperty, defaultBackgroundColor));
            style.Setters.Add(new Setter(BorderBrushProperty, defaultBorderColor));
            style.Setters.Add(new Setter(ForegroundProperty, defaultForegroundColor));
            style.Setters.Add(new Setter(PaddingProperty, thickness));
            style.Setters.Add(new Setter(BorderThicknessProperty, borderThickness));
            style.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            style.Triggers.Add(trigger);
            style.Seal();
        }
    }

    public partial class I12Button1 : Button
    {
        public I12Button1()
        {
            Style = style;
        }
    }
}