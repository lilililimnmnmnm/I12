using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace I12
{
    public partial class I12TabControl1
    {
        private static readonly Style style = new(typeof(I12TabControl1));
        private static readonly Thickness thickness = new(0);
        private static readonly Thickness borderThickness = new(1);
        private static readonly SolidColorBrush defaultBackgroundColor = new(Color.FromArgb(255, 255, 255, 255));
        private static readonly SolidColorBrush defaultBorderColor = new(Color.FromArgb(255, 200, 200, 200));
        private static readonly SolidColorBrush defaultForegroundColor = new(Color.FromArgb(255, 50, 50, 50));

        static I12TabControl1()
        {
            defaultBackgroundColor.Freeze();
            defaultBorderColor.Freeze();
            defaultForegroundColor.Freeze();
            ControlTemplate controlTemplate = new(typeof(I12TabControl1));
            FrameworkElementFactory border1 = new(typeof(Border));
            FrameworkElementFactory border2 = new(typeof(Border));
            FrameworkElementFactory dockPanel = new(typeof(DockPanel));
            FrameworkElementFactory tabPanel = new(typeof(TabPanel));
            FrameworkElementFactory contentPresenter = new(typeof(ContentPresenter));
            border1.SetValue(Border.BackgroundProperty, defaultBackgroundColor);
            border1.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(BorderBrushProperty));
            border1.SetValue(Border.BorderThicknessProperty, new TemplateBindingExtension(BorderThicknessProperty));
            border2.SetValue(DockPanel.DockProperty, Dock.Top);
            border2.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(BorderBrushProperty));
            border2.SetValue(Border.BorderThicknessProperty, new Thickness(0, 0, 0, 1));
            tabPanel.SetValue(MarginProperty, new Thickness(0, -1, 16, -1));
            tabPanel.SetValue(Panel.IsItemsHostProperty, true);
            contentPresenter.SetValue(DockPanel.DockProperty, Dock.Top);
            contentPresenter.SetValue(ContentPresenter.ContentSourceProperty, "SelectedContent");
            border1.AppendChild(dockPanel);
            dockPanel.AppendChild(border2);
            dockPanel.AppendChild(contentPresenter);
            border2.AppendChild(tabPanel);
            controlTemplate.VisualTree = border1;
            controlTemplate.Seal();
            style.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            style.Setters.Add(new Setter(BackgroundProperty, defaultBackgroundColor));
            style.Setters.Add(new Setter(BorderBrushProperty, defaultBorderColor));
            style.Setters.Add(new Setter(ForegroundProperty, defaultForegroundColor));
            style.Setters.Add(new Setter(PaddingProperty, thickness));
            style.Setters.Add(new Setter(BorderThicknessProperty, borderThickness));
            style.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            style.Seal();
        }
    }

    public partial class I12TabControl1 : TabControl
    {
        public I12TabControl1()
        {
            Style = style;
            ItemContainerStyle = I12TabItem1.I12TabItem1Style;
        }
    }

    public partial class I12TabItem1 : TabItem
    {
        private static readonly Style style = new(typeof(TabItem));
        private static readonly Thickness padding = new(16, 6, 16, 6);
        private static readonly Thickness borderThickness = new(0, 1, 1, 0);
        private static readonly SolidColorBrush defaultBackgroundColor = new(Color.FromArgb(0, 0, 0, 0));
        private static readonly SolidColorBrush defaultBorderColor = new(Color.FromArgb(255, 200, 200, 200));
        private static readonly SolidColorBrush selectedBackgroundColor = new(Color.FromArgb(255, 245, 245, 245));
        private static readonly SolidColorBrush defaultForegroundColor = new(Color.FromArgb(255, 50, 50, 50));
        public static Style I12TabItem1Style => style;

        static I12TabItem1()
        {
            defaultBackgroundColor.Freeze();
            defaultBorderColor.Freeze();
            selectedBackgroundColor.Freeze();
            ControlTemplate controlTemplate = new(typeof(TabItem));
            FrameworkElementFactory border = new(typeof(Border));
            FrameworkElementFactory contentPresenter = new(typeof(ContentPresenter));
            Trigger trigger = new() { Property = IsSelectedProperty, Value = true };
            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(BackgroundProperty));
            border.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(BorderBrushProperty));
            border.SetValue(Border.PaddingProperty, new TemplateBindingExtension(PaddingProperty));
            border.SetValue(Border.BorderThicknessProperty, new TemplateBindingExtension(BorderThicknessProperty));
            contentPresenter.SetValue(ContentPresenter.ContentSourceProperty, "Header");
            trigger.Setters.Add(new Setter(Panel.BackgroundProperty, selectedBackgroundColor));
            border.AppendChild(contentPresenter);
            controlTemplate.VisualTree = border;
            controlTemplate.Seal();
            style.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            style.Setters.Add(new Setter(BackgroundProperty, defaultBackgroundColor));
            style.Setters.Add(new Setter(BorderBrushProperty, defaultBorderColor));
            style.Setters.Add(new Setter(ForegroundProperty, defaultForegroundColor));
            style.Setters.Add(new Setter(PaddingProperty, padding));
            style.Setters.Add(new Setter(BorderThicknessProperty, borderThickness));
            style.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            style.Setters.Add(new Setter(FocusVisualStyleProperty, I12FocusVisibleStyle.Style2));
            style.Triggers.Add(trigger);
            style.Seal();
        }
    }

    public partial class I12TabItem1 : TabItem
    {
        public I12TabItem1()
        {
            Style = style;
        }
    }
}