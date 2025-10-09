using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace I12
{
    public partial class I12Icon16Button1 : Button
    {
        private static readonly Style style = new(typeof(I12Icon16Button1));
        private static readonly Thickness thickness = new(0);
        private static readonly SolidColorBrush defaultBackgroundColor = new(Color.FromArgb(0, 0, 0, 0));
        private static readonly SolidColorBrush mouseOverBackgroundColor = new(Color.FromArgb(150, 255, 255, 255));

        static I12Icon16Button1()
        {
            defaultBackgroundColor.Freeze();
            mouseOverBackgroundColor.Freeze();
            ControlTemplate controlTemplate = new(typeof(I12Icon16Button1));
            FrameworkElementFactory border = new(typeof(Border));
            FrameworkElementFactory i12Icon16 = new(typeof(I12Icon16));
            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(BackgroundProperty));
            border.SetValue(Border.PaddingProperty, new TemplateBindingExtension(PaddingProperty));
            i12Icon16.SetValue(HorizontalAlignmentProperty, new TemplateBindingExtension(HorizontalContentAlignmentProperty));
            i12Icon16.SetValue(VerticalAlignmentProperty, new TemplateBindingExtension(VerticalContentAlignmentProperty));
            i12Icon16.SetValue(I12Icon16.IconProperty, new TemplateBindingExtension(IconProperty));
            Trigger trigger = new() { Property = IsMouseOverProperty, Value = true };
            trigger.Setters.Add(new Setter(BackgroundProperty, mouseOverBackgroundColor));
            trigger.Setters.Add(new Setter(OpacityProperty, 1.0));
            border.AppendChild(i12Icon16);
            controlTemplate.VisualTree = border;
            controlTemplate.Seal();
            style.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            style.Setters.Add(new Setter(FocusableProperty, false));
            style.Setters.Add(new Setter(IsTabStopProperty, false));
            style.Setters.Add(new Setter(OpacityProperty, 0.9));
            style.Setters.Add(new Setter(BackgroundProperty, defaultBackgroundColor));
            style.Setters.Add(new Setter(BorderBrushProperty, null));
            style.Setters.Add(new Setter(ForegroundProperty, null));
            style.Setters.Add(new Setter(PaddingProperty, thickness));
            style.Setters.Add(new Setter(BorderThicknessProperty, thickness));
            style.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            style.Setters.Add(new Setter(FocusVisualStyleProperty, I12FocusVisibleStyle.Style2));
            style.Triggers.Add(trigger);
            style.Seal();
        }
    }

    public partial class I12Icon16Button1 : Button
    {
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(nameof(Icon), typeof(DrawingGroup), typeof(I12Icon16Button1));
        public DrawingGroup Icon { get => (DrawingGroup)GetValue(IconProperty); set => SetValue(IconProperty, value); }

        public I12Icon16Button1()
        {
            Style = style;
        }
    }

    public partial class I12Icon24Button1 : Button
    {
        private static readonly Thickness thickness = new(0);
        private static readonly SolidColorBrush defaultBackgroundColor = new(Color.FromArgb(0, 0, 0, 0));
        private static readonly SolidColorBrush mouseOverBackgroundColor = new(Color.FromArgb(150, 255, 255, 255));
        private static readonly Style style = new(typeof(I12Icon24Button1));
        static I12Icon24Button1()
        {
            defaultBackgroundColor.Freeze();
            mouseOverBackgroundColor.Freeze();
            ControlTemplate controlTemplate = new(typeof(I12Icon24Button1));
            FrameworkElementFactory border = new(typeof(Border));
            FrameworkElementFactory i12Icon24 = new(typeof(I12Icon24));
            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(BackgroundProperty));
            border.SetValue(Border.PaddingProperty, new TemplateBindingExtension(PaddingProperty));
            i12Icon24.SetValue(HorizontalAlignmentProperty, new TemplateBindingExtension(HorizontalContentAlignmentProperty));
            i12Icon24.SetValue(VerticalAlignmentProperty, new TemplateBindingExtension(VerticalContentAlignmentProperty));
            i12Icon24.SetValue(I12Icon24.IconProperty, new TemplateBindingExtension(IconProperty));
            Trigger trigger = new() { Property = IsMouseOverProperty, Value = true };
            trigger.Setters.Add(new Setter(BackgroundProperty, mouseOverBackgroundColor));
            trigger.Setters.Add(new Setter(OpacityProperty, 1.0));
            border.AppendChild(i12Icon24);
            controlTemplate.VisualTree = border;
            controlTemplate.Seal();
            style.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            style.Setters.Add(new Setter(FocusableProperty, false));
            style.Setters.Add(new Setter(OpacityProperty, 0.85));
            style.Setters.Add(new Setter(PaddingProperty, thickness));
            style.Setters.Add(new Setter(BackgroundProperty, defaultBackgroundColor));
            style.Setters.Add(new Setter(ForegroundProperty, null));
            style.Setters.Add(new Setter(BorderBrushProperty, null));
            style.Setters.Add(new Setter(BorderThicknessProperty, thickness));
            style.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            style.Triggers.Add(trigger);
            style.Seal();
        }
    }

    public partial class I12Icon24Button1 : Button
    {
        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(nameof(Icon), typeof(DrawingGroup), typeof(I12Icon24Button1));
        public DrawingGroup Icon { get => (DrawingGroup)GetValue(IconProperty); set => SetValue(IconProperty, value); }

        public I12Icon24Button1()
        {
            Style = style;
        }
    }
}