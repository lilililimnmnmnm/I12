using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace I12
{
    public partial class I12TextBox1
    {
        private static readonly Style style = new(typeof(I12TextBox1));
        private static readonly double fontSize = 12.0;
        private static readonly Thickness padding = new(4);
        private static readonly Thickness borderThickness = new(0, 0, 4, 0);
        private static readonly Cursor cursor = Cursors.IBeam;
        private static readonly SolidColorBrush defaultBackgroundColor = new(Color.FromArgb(0, 0, 0, 0));
        private static readonly SolidColorBrush defaultBorderColor = new(Color.FromArgb(0, 0, 0, 0));
        private static readonly SolidColorBrush defaultForegroundColor = new(Color.FromArgb(255, 50, 50, 50));
        private static readonly SolidColorBrush defaultTitleColor = new(Color.FromArgb(255, 100, 100, 100));
        private static readonly SolidColorBrush mouseOverBackgroundColor = new(Color.FromArgb(150, 255, 255, 255));
        private static readonly SolidColorBrush mouseOverBorderColor = new(Color.FromArgb(255, 150, 150, 150));
        private static readonly SolidColorBrush mouseOverTitleColor = new(Color.FromArgb(255, 0, 120, 210));
        private static readonly SolidColorBrush focusedBackgroundColor = new(Color.FromArgb(150, 255, 255, 255));
        private static readonly SolidColorBrush focusedBorderColor = new(Color.FromArgb(255, 0, 120, 210));
        private static readonly SolidColorBrush focusedForegroundColor = new(Color.FromArgb(255, 30, 30, 30));
        private static readonly SolidColorBrush focusedTitleColor = new(Color.FromArgb(255, 0, 120, 210));


        static I12TextBox1()
        {
            defaultBackgroundColor.Freeze();
            defaultBorderColor.Freeze();
            defaultForegroundColor.Freeze();
            defaultTitleColor.Freeze();
            mouseOverBackgroundColor.Freeze();
            mouseOverBorderColor.Freeze();
            mouseOverTitleColor.Freeze();
            focusedBackgroundColor.Freeze();
            focusedBorderColor.Freeze();
            focusedForegroundColor.Freeze();
            focusedTitleColor.Freeze();
            ControlTemplate controlTemplate = new(typeof(I12TextBox1));
            FrameworkElementFactory border = new(typeof(Border));
            FrameworkElementFactory dockPanel = new(typeof(DockPanel));
            FrameworkElementFactory ellipse = new(typeof(Ellipse), nameof(ellipse));
            FrameworkElementFactory textBlock = new(typeof(TextBlock));
            FrameworkElementFactory PART_ContentHost = new(typeof(ScrollViewer), nameof(PART_ContentHost));
            Trigger trigger1 = new() { Property = TitleTextProperty, Value = string.Empty };
            Trigger trigger2 = new() { Property = IsMouseOverProperty, Value = true };
            Trigger trigger3 = new() { Property = IsFocusedProperty, Value = true };
            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(BackgroundProperty));
            border.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(BorderBrushProperty));
            border.SetValue(Border.PaddingProperty, new TemplateBindingExtension(PaddingProperty));
            border.SetValue(Border.BorderThicknessProperty, new TemplateBindingExtension(BorderThicknessProperty));
            ellipse.SetValue(VerticalAlignmentProperty, VerticalAlignment.Center);
            ellipse.SetValue(HeightProperty, 4.0);
            ellipse.SetValue(WidthProperty, 4.0);
            ellipse.SetValue(MarginProperty, new Thickness(4));
            ellipse.SetValue(Shape.FillProperty, focusedTitleColor);
            textBlock.SetValue(VerticalAlignmentProperty, VerticalAlignment.Center);
            textBlock.SetValue(WidthProperty, new TemplateBindingExtension(TitleWidthProperty));
            textBlock.SetValue(DockPanel.DockProperty, Dock.Left);
            textBlock.SetValue(TextBlock.ForegroundProperty, new TemplateBindingExtension(TitleColorProperty));
            textBlock.SetValue(TextBlock.PaddingProperty, new TemplateBindingExtension(PaddingProperty));
            textBlock.SetValue(TextBlock.TextProperty, new TemplateBindingExtension(TitleTextProperty));
            PART_ContentHost.SetValue(DockPanel.DockProperty, Dock.Left);
            trigger1.Setters.Add(new Setter(VisibilityProperty, Visibility.Hidden, nameof(ellipse)));
            trigger2.Setters.Add(new Setter(BackgroundProperty, mouseOverBackgroundColor));
            trigger2.Setters.Add(new Setter(BorderBrushProperty, mouseOverBorderColor));
            trigger2.Setters.Add(new Setter(TitleColorProperty, mouseOverTitleColor));
            trigger3.Setters.Add(new Setter(BackgroundProperty, focusedBackgroundColor));
            trigger3.Setters.Add(new Setter(BorderBrushProperty, focusedBorderColor));
            trigger3.Setters.Add(new Setter(ForegroundProperty, focusedForegroundColor));
            trigger3.Setters.Add(new Setter(TitleColorProperty, focusedTitleColor));
            border.AppendChild(dockPanel);
            dockPanel.AppendChild(ellipse);
            dockPanel.AppendChild(textBlock);
            dockPanel.AppendChild(PART_ContentHost);
            controlTemplate.VisualTree = border;
            controlTemplate.Triggers.Add(trigger1);
            controlTemplate.Seal();
            style.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            style.Setters.Add(new Setter(BackgroundProperty, defaultBackgroundColor));
            style.Setters.Add(new Setter(BorderBrushProperty, defaultBorderColor));
            style.Setters.Add(new Setter(ForegroundProperty, defaultForegroundColor));
            style.Setters.Add(new Setter(TitleColorProperty, defaultTitleColor));
            style.Setters.Add(new Setter(PaddingProperty, padding));
            style.Setters.Add(new Setter(BorderThicknessProperty, borderThickness));
            style.Setters.Add(new Setter(FontSizeProperty, fontSize));
            style.Setters.Add(new Setter(CursorProperty, cursor));
            style.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            style.Triggers.Add(trigger2);
            style.Triggers.Add(trigger3);
            style.Seal();
        }
    }

    public partial class I12TextBox1 : TextBox
    {
        public static readonly DependencyProperty TitleWidthProperty = DependencyProperty.Register(nameof(TitleWidth), typeof(double), typeof(I12TextBox1), new PropertyMetadata(double.NaN));
        public static readonly DependencyProperty TitleTextProperty = DependencyProperty.Register(nameof(TitleText), typeof(string), typeof(I12TextBox1), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty TitleColorProperty = DependencyProperty.Register(nameof(TitleColor), typeof(SolidColorBrush), typeof(I12TextBox1), new PropertyMetadata(defaultTitleColor));
        public double TitleWidth { get => (double)GetValue(TitleWidthProperty); set => SetValue(TitleWidthProperty, value); }
        public string TitleText { get => (string)GetValue(TitleTextProperty); set => SetValue(TitleTextProperty, value); }
        public SolidColorBrush TitleColor { get => (SolidColorBrush)GetValue(TitleColorProperty); set => SetValue(TitleColorProperty, value); }

        public I12TextBox1()
        {
            Style = style;
        }

        protected override void OnGotFocus(RoutedEventArgs e)
        {
            base.OnGotFocus(e);
            Dispatcher.Invoke(() => SelectAll());
        }
    }
}