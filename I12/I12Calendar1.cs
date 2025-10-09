using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace I12
{
    public partial class I12Calendar1 : Calendar
    {
        private static readonly DataTemplate dayTitleTemplate = new();
        private static readonly Style calendarItemStyle = new(typeof(CalendarItem));
        private static readonly Style calendarButtonStyle = new(typeof(CalendarButton));
        private static readonly Style calendarDayButtonStyle = new(typeof(CalendarDayButton));
        private static readonly SolidColorBrush defaultBackgroundColor = new(Color.FromArgb(255, 255, 255, 255));
        private static readonly SolidColorBrush defaultHeaderBackgroundColor = new(Color.FromArgb(255, 245, 245, 245));
        private static readonly SolidColorBrush defaultBorderColor = new(Color.FromArgb(255, 127, 127, 127));
        private static readonly SolidColorBrush defaultForegroundColor = new(Color.FromArgb(255, 60, 70, 80));
        private static readonly SolidColorBrush defaultTitleBackgroundColor = new(Color.FromArgb(255, 240, 240, 240));
        private static readonly SolidColorBrush defaultTitleBorderColor = new(Color.FromArgb(255, 200, 200, 200));
        private static readonly SolidColorBrush defaultButtonBackgroundColor = new(Color.FromArgb(0, 0, 0, 0));
        private static readonly SolidColorBrush defaultButtonBorderColor = new(Color.FromArgb(0, 0, 0, 0));
        private static readonly SolidColorBrush mouseOverForegroundColor = new(Color.FromArgb(255, 30, 40, 50));
        private static readonly SolidColorBrush mouseOverButtonBackgroundColor = new(Color.FromArgb(20, 0, 120, 210));
        private static readonly SolidColorBrush mouseOverButtonBorderColor = new(Color.FromArgb(255, 0, 120, 210));
        private static readonly SolidColorBrush todayButtonBackgroundColor = new(Color.FromArgb(20, 50, 180, 120));
        private static readonly SolidColorBrush inactiveForegroundColor = new(Color.FromArgb(255, 150, 150, 150));
        public static readonly Style I12Calendar1Style = new(typeof(Calendar));

        static I12Calendar1()
        {
            defaultBackgroundColor.Freeze();
            defaultHeaderBackgroundColor.Freeze();
            defaultBorderColor.Freeze();
            defaultForegroundColor.Freeze();
            defaultTitleBackgroundColor.Freeze();
            defaultTitleBorderColor.Freeze();
            defaultButtonBackgroundColor.Freeze();
            defaultButtonBorderColor.Freeze();
            mouseOverForegroundColor.Freeze();
            mouseOverButtonBackgroundColor.Freeze();
            mouseOverButtonBorderColor.Freeze();
            todayButtonBackgroundColor.Freeze();
            inactiveForegroundColor.Freeze();
            InitializeDayTitleTemplate();
            InitializeCalendarItemStyle();
            InitializeCalendarButtonStyle();
            InitializeCalendarDayButtonStyle();
            InitializeI12Calendar1Style();
        }

        private static void InitializeDayTitleTemplate()
        {
            FrameworkElementFactory border = new(typeof(Border));
            FrameworkElementFactory textBlock = new(typeof(TextBlock));
            border.SetValue(Border.BackgroundProperty, defaultTitleBackgroundColor);
            border.SetValue(Border.BorderBrushProperty, defaultTitleBorderColor);
            border.SetValue(Border.BorderThicknessProperty, new Thickness(0, 0, 0, 1));
            border.SetValue(HeightProperty, 30.0);
            border.SetValue(WidthProperty, 40.0);
            textBlock.SetValue(HorizontalAlignmentProperty, HorizontalAlignment.Center);
            textBlock.SetValue(VerticalAlignmentProperty, VerticalAlignment.Center);
            textBlock.SetValue(FontSizeProperty, 12.0);
            textBlock.SetValue(TextBlock.ForegroundProperty, defaultForegroundColor);
            textBlock.SetBinding(TextBlock.TextProperty, new Binding());
            border.AppendChild(textBlock);
            dayTitleTemplate.VisualTree = border;
            dayTitleTemplate.Seal();
        }

        private static void InitializeCalendarItemStyle()
        {
            ControlTemplate controlTemplate = new(typeof(CalendarItem));
            FrameworkElementFactory border = new(typeof(Border));
            FrameworkElementFactory stackPanel1 = new(typeof(StackPanel));
            FrameworkElementFactory stackPanel2 = new(typeof(StackPanel));
            FrameworkElementFactory polyline1 = new(typeof(Polyline));
            FrameworkElementFactory polyline2 = new(typeof(Polyline));
            FrameworkElementFactory PART_PreviousButton = new(typeof(I12Button1), nameof(PART_PreviousButton));
            FrameworkElementFactory PART_HeaderButton = new(typeof(I12Button1), nameof(PART_HeaderButton));
            FrameworkElementFactory PART_NextButton = new(typeof(I12Button1), nameof(PART_NextButton));
            FrameworkElementFactory grid = new(typeof(Grid));
            FrameworkElementFactory PART_MonthView = new(typeof(Grid), nameof(PART_MonthView));
            FrameworkElementFactory columnDefinitionMonthView1 = new(typeof(ColumnDefinition));
            FrameworkElementFactory columnDefinitionMonthView2 = new(typeof(ColumnDefinition));
            FrameworkElementFactory columnDefinitionMonthView3 = new(typeof(ColumnDefinition));
            FrameworkElementFactory columnDefinitionMonthView4 = new(typeof(ColumnDefinition));
            FrameworkElementFactory columnDefinitionMonthView5 = new(typeof(ColumnDefinition));
            FrameworkElementFactory columnDefinitionMonthView6 = new(typeof(ColumnDefinition));
            FrameworkElementFactory columnDefinitionMonthView7 = new(typeof(ColumnDefinition));
            FrameworkElementFactory rowDefinitionMonthView1 = new(typeof(RowDefinition));
            FrameworkElementFactory rowDefinitionMonthView2 = new(typeof(RowDefinition));
            FrameworkElementFactory rowDefinitionMonthView3 = new(typeof(RowDefinition));
            FrameworkElementFactory rowDefinitionMonthView4 = new(typeof(RowDefinition));
            FrameworkElementFactory rowDefinitionMonthView5 = new(typeof(RowDefinition));
            FrameworkElementFactory rowDefinitionMonthView6 = new(typeof(RowDefinition));
            FrameworkElementFactory rowDefinitionMonthView7 = new(typeof(RowDefinition));
            FrameworkElementFactory PART_YearView = new(typeof(Grid), nameof(PART_YearView));
            FrameworkElementFactory columnDefinitionYearView1 = new(typeof(ColumnDefinition));
            FrameworkElementFactory columnDefinitionYearView2 = new(typeof(ColumnDefinition));
            FrameworkElementFactory columnDefinitionYearView3 = new(typeof(ColumnDefinition));
            FrameworkElementFactory columnDefinitionYearView4 = new(typeof(ColumnDefinition));
            FrameworkElementFactory rowDefinitionYearView1 = new(typeof(RowDefinition));
            FrameworkElementFactory rowDefinitionYearView2 = new(typeof(RowDefinition));
            FrameworkElementFactory rowDefinitionYearView3 = new(typeof(RowDefinition));
            DataTrigger trigger1 = new() { Binding = new Binding(nameof(DisplayMode)) { RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(Calendar), 1) }, Value = CalendarMode.Year };
            DataTrigger trigger2 = new() { Binding = new Binding(nameof(DisplayMode)) { RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(Calendar), 1) }, Value = CalendarMode.Decade };
            border.SetValue(Border.BackgroundProperty, defaultBackgroundColor);
            border.SetValue(Border.BorderBrushProperty, defaultBorderColor);
            border.SetValue(Border.BorderThicknessProperty, new Thickness(1));
            stackPanel2.SetValue(WidthProperty, 280.0);
            stackPanel2.SetValue(Panel.BackgroundProperty, defaultHeaderBackgroundColor);
            stackPanel2.SetValue(StackPanel.OrientationProperty, Orientation.Horizontal);
            polyline1.SetValue(HeightProperty, 16.0);
            polyline1.SetValue(WidthProperty, 16.0);
            polyline1.SetBinding(Shape.StrokeProperty, new Binding(nameof(Foreground)) { RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(I12Button1), 1) });
            polyline1.SetValue(Shape.StrokeThicknessProperty, 3.0);
            polyline1.SetValue(Polyline.PointsProperty, new PointCollection { new Point(12, 2), new Point(4, 8), new Point(12, 14) });
            polyline2.SetValue(HeightProperty, 16.0);
            polyline2.SetValue(WidthProperty, 16.0);
            polyline2.SetBinding(Shape.StrokeProperty, new Binding(nameof(Foreground)) { RelativeSource = new RelativeSource(RelativeSourceMode.FindAncestor, typeof(I12Button1), 1) });
            polyline2.SetValue(Shape.StrokeThicknessProperty, 3.0);
            polyline2.SetValue(Polyline.PointsProperty, new PointCollection { new Point(4, 2), new Point(12, 8), new Point(4, 14) });
            PART_PreviousButton.SetValue(HeightProperty, 40.0);
            PART_PreviousButton.SetValue(WidthProperty, 50.0);
            PART_HeaderButton.SetValue(HeightProperty, 40.0);
            PART_HeaderButton.SetValue(WidthProperty, 180.0);
            PART_NextButton.SetValue(HeightProperty, 40.0);
            PART_NextButton.SetValue(WidthProperty, 50.0);
            PART_MonthView.SetValue(VisibilityProperty, Visibility.Visible);
            PART_YearView.SetValue(VisibilityProperty, Visibility.Hidden);
            trigger1.Setters.Add(new Setter(VisibilityProperty, Visibility.Hidden, nameof(PART_MonthView)));
            trigger1.Setters.Add(new Setter(VisibilityProperty, Visibility.Visible, nameof(PART_YearView)));
            trigger2.Setters.Add(new Setter(VisibilityProperty, Visibility.Hidden, nameof(PART_MonthView)));
            trigger2.Setters.Add(new Setter(VisibilityProperty, Visibility.Visible, nameof(PART_YearView)));
            border.AppendChild(stackPanel1);
            stackPanel1.AppendChild(stackPanel2);
            stackPanel2.AppendChild(PART_PreviousButton);
            stackPanel2.AppendChild(PART_HeaderButton);
            stackPanel2.AppendChild(PART_NextButton);
            PART_PreviousButton.AppendChild(polyline1);
            PART_NextButton.AppendChild(polyline2);
            stackPanel1.AppendChild(grid);
            grid.AppendChild(PART_MonthView);
            grid.AppendChild(PART_YearView);
            PART_MonthView.AppendChild(columnDefinitionMonthView1);
            PART_MonthView.AppendChild(columnDefinitionMonthView2);
            PART_MonthView.AppendChild(columnDefinitionMonthView3);
            PART_MonthView.AppendChild(columnDefinitionMonthView4);
            PART_MonthView.AppendChild(columnDefinitionMonthView5);
            PART_MonthView.AppendChild(columnDefinitionMonthView6);
            PART_MonthView.AppendChild(columnDefinitionMonthView7);
            PART_MonthView.AppendChild(rowDefinitionMonthView1);
            PART_MonthView.AppendChild(rowDefinitionMonthView2);
            PART_MonthView.AppendChild(rowDefinitionMonthView3);
            PART_MonthView.AppendChild(rowDefinitionMonthView4);
            PART_MonthView.AppendChild(rowDefinitionMonthView5);
            PART_MonthView.AppendChild(rowDefinitionMonthView6);
            PART_MonthView.AppendChild(rowDefinitionMonthView7);
            PART_YearView.AppendChild(columnDefinitionYearView1);
            PART_YearView.AppendChild(columnDefinitionYearView2);
            PART_YearView.AppendChild(columnDefinitionYearView3);
            PART_YearView.AppendChild(columnDefinitionYearView4);
            PART_YearView.AppendChild(rowDefinitionYearView1);
            PART_YearView.AppendChild(rowDefinitionYearView2);
            PART_YearView.AppendChild(rowDefinitionYearView3);
            controlTemplate.VisualTree = border;
            controlTemplate.Triggers.Add(trigger1);
            controlTemplate.Triggers.Add(trigger2);
            controlTemplate.Resources.Add(CalendarItem.DayTitleTemplateResourceKey, dayTitleTemplate);
            controlTemplate.Seal();
            calendarItemStyle.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            calendarItemStyle.Setters.Add(new Setter(MarginProperty, new Thickness(0)));
            calendarItemStyle.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            calendarItemStyle.Seal();
        }

        private static void InitializeCalendarButtonStyle()
        {
            ControlTemplate controlTemplate = new(typeof(CalendarButton));
            FrameworkElementFactory border = new(typeof(Border));
            FrameworkElementFactory contentPresenter = new(typeof(ContentPresenter));
            Trigger trigger1 = new() { Property = IsMouseOverProperty, Value = true };
            Trigger trigger2 = new() { Property = CalendarButton.HasSelectedDaysProperty, Value = true };
            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(BackgroundProperty));
            border.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(BorderBrushProperty));
            border.SetValue(Border.BorderThicknessProperty, new Thickness(1));
            contentPresenter.SetValue(HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(VerticalAlignmentProperty, VerticalAlignment.Center);
            trigger1.Setters.Add(new Setter(ForegroundProperty, mouseOverForegroundColor));
            trigger1.Setters.Add(new Setter(Border.BackgroundProperty, mouseOverButtonBackgroundColor));
            trigger1.Setters.Add(new Setter(Border.BorderBrushProperty, mouseOverButtonBackgroundColor));
            trigger2.Setters.Add(new Setter(ForegroundProperty, mouseOverButtonBorderColor));
            trigger2.Setters.Add(new Setter(Border.BackgroundProperty, mouseOverButtonBackgroundColor));
            trigger2.Setters.Add(new Setter(Border.BorderBrushProperty, mouseOverButtonBorderColor));
            border.AppendChild(contentPresenter);
            controlTemplate.VisualTree = border;
            controlTemplate.Triggers.Add(trigger1);
            controlTemplate.Triggers.Add(trigger2);
            controlTemplate.Seal();
            calendarButtonStyle.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            calendarButtonStyle.Setters.Add(new Setter(HeightProperty, 70.0));
            calendarButtonStyle.Setters.Add(new Setter(WidthProperty, 70.0));
            calendarButtonStyle.Setters.Add(new Setter(FontSizeProperty, 12.0));
            calendarButtonStyle.Setters.Add(new Setter(BackgroundProperty, defaultButtonBackgroundColor));
            calendarButtonStyle.Setters.Add(new Setter(BorderBrushProperty, defaultButtonBorderColor));
            calendarButtonStyle.Setters.Add(new Setter(ForegroundProperty, defaultForegroundColor));
            calendarButtonStyle.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            calendarButtonStyle.Setters.Add(new Setter(FocusVisualStyleProperty, I12FocusVisibleStyle.Style1));
            calendarButtonStyle.Seal();
        }

        private static void InitializeCalendarDayButtonStyle()
        {
            ControlTemplate controlTemplate = new(typeof(CalendarDayButton));
            FrameworkElementFactory border = new(typeof(Border));
            FrameworkElementFactory contentPresenter = new(typeof(ContentPresenter));
            Trigger trigger1 = new() { Property = CalendarDayButton.IsTodayProperty, Value = true };
            Trigger trigger2 = new() { Property = IsMouseOverProperty, Value = true };
            Trigger trigger3 = new() { Property = CalendarDayButton.IsSelectedProperty, Value = true };
            Trigger trigger4 = new() { Property = CalendarDayButton.IsInactiveProperty, Value = true };
            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(BackgroundProperty));
            border.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(BorderBrushProperty));
            border.SetValue(Border.BorderThicknessProperty, new Thickness(1));
            contentPresenter.SetValue(HorizontalAlignmentProperty, HorizontalAlignment.Center);
            contentPresenter.SetValue(VerticalAlignmentProperty, VerticalAlignment.Center);
            trigger1.Setters.Add(new Setter(Border.BackgroundProperty, todayButtonBackgroundColor));
            trigger1.Setters.Add(new Setter(Border.BorderBrushProperty, todayButtonBackgroundColor));
            trigger2.Setters.Add(new Setter(ForegroundProperty, mouseOverForegroundColor));
            trigger2.Setters.Add(new Setter(Border.BackgroundProperty, mouseOverButtonBackgroundColor));
            trigger2.Setters.Add(new Setter(Border.BorderBrushProperty, mouseOverButtonBackgroundColor));
            trigger3.Setters.Add(new Setter(ForegroundProperty, mouseOverButtonBorderColor));
            trigger3.Setters.Add(new Setter(Border.BackgroundProperty, mouseOverButtonBackgroundColor));
            trigger3.Setters.Add(new Setter(Border.BorderBrushProperty, mouseOverButtonBorderColor));
            trigger4.Setters.Add(new Setter(ForegroundProperty, inactiveForegroundColor));
            border.AppendChild(contentPresenter);
            controlTemplate.VisualTree = border;
            controlTemplate.Triggers.Add(trigger1);
            controlTemplate.Triggers.Add(trigger2);
            controlTemplate.Triggers.Add(trigger3);
            controlTemplate.Triggers.Add(trigger4);
            controlTemplate.Seal();
            calendarDayButtonStyle.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            calendarDayButtonStyle.Setters.Add(new Setter(HeightProperty, 30.0));
            calendarDayButtonStyle.Setters.Add(new Setter(WidthProperty, 40.0));
            calendarDayButtonStyle.Setters.Add(new Setter(FontSizeProperty, 12.0));
            calendarDayButtonStyle.Setters.Add(new Setter(BackgroundProperty, defaultButtonBackgroundColor));
            calendarDayButtonStyle.Setters.Add(new Setter(BorderBrushProperty, defaultButtonBorderColor));
            calendarDayButtonStyle.Setters.Add(new Setter(ForegroundProperty, defaultForegroundColor));
            calendarDayButtonStyle.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            calendarDayButtonStyle.Setters.Add(new Setter(FocusVisualStyleProperty, I12FocusVisibleStyle.Style1));
            calendarDayButtonStyle.Seal();
        }

        private static void InitializeI12Calendar1Style()
        {
            I12Calendar1Style.Setters.Add(new Setter(CalendarItemStyleProperty, calendarItemStyle));
            I12Calendar1Style.Setters.Add(new Setter(CalendarButtonStyleProperty, calendarButtonStyle));
            I12Calendar1Style.Setters.Add(new Setter(CalendarDayButtonStyleProperty, calendarDayButtonStyle));
            I12Calendar1Style.Seal();
        }
    }

    public partial class I12Calendar1 : Calendar
    {
        public I12Calendar1()
        {
            Style = I12Calendar1Style;
        }
    }
}