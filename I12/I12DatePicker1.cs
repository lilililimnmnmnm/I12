using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace I12
{
    public partial class I12DatePicker1
    {
        private static readonly Style style = new(typeof(I12DatePicker1));
        private static readonly ControlTemplate buttonControlTemplate = new(typeof(Button));
        private static readonly ControlTemplate datePickerTextBoxControlTemplate = new(typeof(DatePickerTextBox));
        private static readonly double fontSize = 12.0;
        private static readonly Thickness padding = new(4);
        private static readonly Thickness borderThickness = new(0, 0, 4, 0);
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

        static I12DatePicker1()
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
            InitializeButtonControlTemplate();
            InitializeDatePickerTextBoxControlTemplate();
            InitializeStyle();
        }

        private static void InitializeButtonControlTemplate()
        {
            FrameworkElementFactory rectangle = new(typeof(Rectangle));
            rectangle.SetValue(Shape.FillProperty, defaultBackgroundColor);
            buttonControlTemplate.VisualTree = rectangle;
            buttonControlTemplate.Seal();
        }

        private static void InitializeDatePickerTextBoxControlTemplate()
        {
            FrameworkElementFactory PART_ContentHost = new(typeof(ScrollViewer), nameof(PART_ContentHost));
            datePickerTextBoxControlTemplate.VisualTree = PART_ContentHost;
            datePickerTextBoxControlTemplate.Seal();
        }

        private static void InitializeStyle()
        {
            ControlTemplate controlTemplate = new(typeof(I12DatePicker1));
            FrameworkElementFactory border = new(typeof(Border));
            FrameworkElementFactory grid = new(typeof(Grid));
            FrameworkElementFactory PART_Button = new(typeof(Button), nameof(PART_Button));
            FrameworkElementFactory PART_Popup = new(typeof(Popup), nameof(PART_Popup));
            FrameworkElementFactory dockPanel = new(typeof(DockPanel));
            FrameworkElementFactory ellipse = new(typeof(Ellipse), nameof(ellipse));
            FrameworkElementFactory textBlock = new(typeof(TextBlock));
            FrameworkElementFactory i12Icon16Calendar1 = new(typeof(I12Icon16Calendar1));
            FrameworkElementFactory PART_TextBox = new(typeof(DatePickerTextBox), nameof(PART_TextBox));
            Trigger trigger1 = new() { Property = TitleTextProperty, Value = string.Empty };
            Trigger trigger2 = new() { Property = IsMouseOverProperty, Value = true };
            Trigger trigger3 = new() { Property = IsKeyboardFocusWithinProperty, Value = true };
            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(BackgroundProperty));
            border.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(BorderBrushProperty));
            border.SetValue(Border.BorderThicknessProperty, new TemplateBindingExtension(BorderThicknessProperty));
            PART_Button.SetValue(FocusableProperty, false);
            PART_Button.SetValue(TemplateProperty, buttonControlTemplate);
            dockPanel.SetValue(MarginProperty, new TemplateBindingExtension(PaddingProperty));
            ellipse.SetValue(VerticalAlignmentProperty, VerticalAlignment.Center);
            ellipse.SetValue(HeightProperty, 4.0);
            ellipse.SetValue(WidthProperty, 4.0);
            ellipse.SetValue(MarginProperty, new Thickness(4));
            ellipse.SetValue(Shape.FillProperty, focusedTitleColor);
            PART_Popup.SetValue(Popup.StaysOpenProperty, false);
            textBlock.SetValue(IsHitTestVisibleProperty, false);
            textBlock.SetValue(VerticalAlignmentProperty, VerticalAlignment.Center);
            textBlock.SetValue(WidthProperty, new TemplateBindingExtension(TitleWidthProperty));
            textBlock.SetValue(DockPanel.DockProperty, Dock.Left);
            textBlock.SetValue(TextBlock.ForegroundProperty, new TemplateBindingExtension(TitleColorProperty));
            textBlock.SetValue(TextBlock.PaddingProperty, new TemplateBindingExtension(PaddingProperty));
            textBlock.SetValue(TextBlock.TextProperty, new TemplateBindingExtension(TitleTextProperty));
            i12Icon16Calendar1.SetValue(IsHitTestVisibleProperty, false);
            i12Icon16Calendar1.SetValue(MarginProperty, new Thickness(6, 0, 6, 0));
            i12Icon16Calendar1.SetValue(VerticalAlignmentProperty, VerticalAlignment.Center);
            i12Icon16Calendar1.SetValue(DockPanel.DockProperty, Dock.Right);
            PART_TextBox.SetValue(TemplateProperty, datePickerTextBoxControlTemplate);
            PART_TextBox.SetValue(FocusVisualStyleProperty, I12FocusVisibleStyle.Style1);
            PART_TextBox.SetValue(CursorProperty, Cursors.IBeam);
            PART_TextBox.SetValue(PaddingProperty, new TemplateBindingExtension(PaddingProperty));
            PART_TextBox.SetValue(BackgroundProperty, defaultBackgroundColor);
            PART_TextBox.SetValue(ForegroundProperty, new TemplateBindingExtension(ForegroundProperty));
            PART_TextBox.SetValue(TextBoxBase.CaretBrushProperty, new TemplateBindingExtension(ForegroundProperty));
            PART_TextBox.SetValue(DockPanel.DockProperty, Dock.Left);
            trigger1.Setters.Add(new Setter(VisibilityProperty, Visibility.Hidden, nameof(ellipse)));
            trigger2.Setters.Add(new Setter(BackgroundProperty, mouseOverBackgroundColor));
            trigger2.Setters.Add(new Setter(BorderBrushProperty, mouseOverBorderColor));
            trigger2.Setters.Add(new Setter(TitleColorProperty, mouseOverTitleColor));
            trigger3.Setters.Add(new Setter(BackgroundProperty, focusedBackgroundColor));
            trigger3.Setters.Add(new Setter(BorderBrushProperty, focusedBorderColor));
            trigger3.Setters.Add(new Setter(ForegroundProperty, focusedForegroundColor));
            trigger3.Setters.Add(new Setter(TitleColorProperty, focusedTitleColor));
            border.AppendChild(grid);
            grid.AppendChild(PART_Button);
            grid.AppendChild(dockPanel);
            grid.AppendChild(PART_Popup);
            dockPanel.AppendChild(ellipse);
            dockPanel.AppendChild(textBlock);
            dockPanel.AppendChild(i12Icon16Calendar1);
            dockPanel.AppendChild(PART_TextBox);
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
            style.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            style.Triggers.Add(trigger2);
            style.Triggers.Add(trigger3);
            style.Seal();
        }
    }

    public partial class I12DatePicker1 : DatePicker
    {
        public static readonly DependencyProperty TitleWidthProperty = DependencyProperty.Register(nameof(TitleWidth), typeof(double), typeof(I12DatePicker1), new PropertyMetadata(double.NaN));
        public static readonly DependencyProperty TitleTextProperty = DependencyProperty.Register(nameof(TitleText), typeof(string), typeof(I12DatePicker1), new PropertyMetadata(string.Empty));
        public static readonly DependencyProperty TitleColorProperty = DependencyProperty.Register(nameof(TitleColor), typeof(SolidColorBrush), typeof(I12DatePicker1), new PropertyMetadata(defaultTitleColor));
        public double TitleWidth { get => (double)GetValue(TitleWidthProperty); set => SetValue(TitleWidthProperty, value); }
        public string TitleText { get => (string)GetValue(TitleTextProperty); set => SetValue(TitleTextProperty, value); }
        public SolidColorBrush TitleColor { get => (SolidColorBrush)GetValue(TitleColorProperty); set => SetValue(TitleColorProperty, value); }

        private DatePickerTextBox? PART_TextBox;
        public event RoutedEventHandler? PressEnter;

        public I12DatePicker1()
        {
            Style = style;
            CalendarStyle = I12Calendar1.I12Calendar1Style;
        }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            if (GetTemplateChild(nameof(PART_TextBox)) is DatePickerTextBox child)
                PART_TextBox = child;
        }

        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            base.OnMouseWheel(e);
            try
            {
                if (PART_TextBox is not null && SelectedDate is not null && !IsDropDownOpen)
                {
                    int delta = e.Delta > 0 ? 1 : -1;
                    int caretIndex = PART_TextBox.CaretIndex;
                    if (caretIndex < 5)
                    {
                        SelectedDate = SelectedDate.Value.AddYears(delta);
                        PART_TextBox.CaretIndex = caretIndex;
                    }
                    else if (caretIndex < 8)
                    {
                        SelectedDate = SelectedDate.Value.AddMonths(delta);
                        PART_TextBox.CaretIndex = caretIndex;
                    }
                    else
                    {
                        SelectedDate = SelectedDate.Value.AddDays(delta);
                        PART_TextBox.CaretIndex = caretIndex;
                    }
                }
            }
            catch { }
        }

        protected override void OnPreviewKeyDown(KeyEventArgs e)
        {
            base.OnPreviewKeyDown(e);
            try
            {
                if (e.Key == Key.Enter)
                {
                    PressEnter?.Invoke(this, e);
                }
                if (PART_TextBox is not null && SelectedDate is not null && !IsDropDownOpen)
                {
                    int delta = 0;
                    if (e.Key == Key.Down)
                    {
                        delta = -1;
                    }
                    else if (e.Key == Key.Up)
                    {
                        delta = 1;
                    }
                    else
                    {
                        return;
                    }
                    int caretIndex = PART_TextBox.CaretIndex;
                    if (caretIndex < 5)
                    {
                        SelectedDate = SelectedDate.Value.AddYears(delta);
                        PART_TextBox.CaretIndex = caretIndex;
                    }
                    else if (caretIndex < 8)
                    {
                        SelectedDate = SelectedDate.Value.AddMonths(delta);
                        PART_TextBox.CaretIndex = caretIndex;
                    }
                    else
                    {
                        SelectedDate = SelectedDate.Value.AddDays(delta);
                        PART_TextBox.CaretIndex = caretIndex;
                    }
                }
            }
            catch { }
        }
    }
}