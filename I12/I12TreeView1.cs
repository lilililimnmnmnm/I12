using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Shapes;

namespace I12
{
    public partial class I12TreeView1 : TreeView
    {
        private static readonly Style style = new(typeof(I12TreeView1));
        private static readonly Style toggleButtonStyle = new(typeof(ToggleButton));
        private static readonly Style itemContainerStyle = new(typeof(TreeViewItem));
        private static readonly Thickness thickness = new(0);
        private static readonly SolidColorBrush defaultBackgroundColor = new(Color.FromArgb(0, 0, 0, 0));
        private static readonly SolidColorBrush selectedBackgroundColor = new(Color.FromArgb(20, 0, 120, 210));
        private static readonly SolidColorBrush defaultToggleButtonColor = new(Color.FromArgb(200, 100, 100, 100));
        private static readonly SolidColorBrush mouseOverToggleButtonColor = new(Color.FromArgb(255, 0, 120, 210));

        static I12TreeView1()
        {
            defaultBackgroundColor.Freeze();
            selectedBackgroundColor.Freeze();
            defaultToggleButtonColor.Freeze();
            mouseOverToggleButtonColor.Freeze();
            InitializeToggleButtonStyle();
            InitializeStyle();
            InitializeItemContainerStyle();
        }

        public static void InitializeToggleButtonStyle()
        {
            ControlTemplate controlTemplate = new(typeof(ToggleButton));
            FrameworkElementFactory grid = new(typeof(Grid));
            FrameworkElementFactory polyline = new(typeof(Polyline), nameof(polyline));
            Trigger trigger1 = new() { Property = IsMouseOverProperty, Value = true };
            Trigger trigger2 = new() { Property = ToggleButton.IsCheckedProperty, Value = true };
            grid.SetValue(BackgroundProperty, new TemplateBindingExtension(BackgroundProperty));
            polyline.SetValue(HeightProperty, 24.0);
            polyline.SetValue(WidthProperty, 24.0);
            polyline.SetValue(HorizontalAlignmentProperty, HorizontalAlignment.Center);
            polyline.SetValue(VerticalAlignmentProperty, VerticalAlignment.Center);
            polyline.SetValue(Shape.StrokeProperty, new TemplateBindingExtension(ForegroundProperty));
            polyline.SetValue(Shape.StrokeThicknessProperty, 2.0);
            polyline.SetValue(Polyline.PointsProperty, new PointCollection { new Point(8, 10), new Point(12, 14), new Point(16, 10) });
            grid.AppendChild(polyline);
            controlTemplate.VisualTree = grid;
            trigger1.Setters.Add(new Setter(BackgroundProperty, selectedBackgroundColor));
            trigger1.Setters.Add(new Setter(Shape.StrokeProperty, mouseOverToggleButtonColor));
            trigger2.Setters.Add(new Setter(Polyline.PointsProperty, new PointCollection { new Point(10, 8), new Point(14, 12), new Point(10, 16) }, nameof(polyline)));
            controlTemplate.Triggers.Add(trigger1);
            controlTemplate.Triggers.Add(trigger2);
            controlTemplate.Seal();
            toggleButtonStyle.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            toggleButtonStyle.Setters.Add(new Setter(FocusableProperty, false));
            toggleButtonStyle.Setters.Add(new Setter(IsTabStopProperty, false));
            toggleButtonStyle.Setters.Add(new Setter(BackgroundProperty, defaultBackgroundColor));
            toggleButtonStyle.Setters.Add(new Setter(BorderBrushProperty, null));
            toggleButtonStyle.Setters.Add(new Setter(ForegroundProperty, defaultToggleButtonColor));
            toggleButtonStyle.Setters.Add(new Setter(PaddingProperty, thickness));
            toggleButtonStyle.Setters.Add(new Setter(BorderThicknessProperty, thickness));
            toggleButtonStyle.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            toggleButtonStyle.Seal();
        }

        public static void InitializeStyle()
        {
            ControlTemplate controlTemplate = new(typeof(I12TreeView1));
            FrameworkElementFactory scrollViewer = new(typeof(ScrollViewer));
            FrameworkElementFactory itemsPresenter = new(typeof(ItemsPresenter));
            scrollViewer.SetValue(SnapsToDevicePixelsProperty, true);
            scrollViewer.SetValue(FocusableProperty, false);
            scrollViewer.SetValue(ScrollViewer.HorizontalScrollBarVisibilityProperty, ScrollBarVisibility.Disabled);
            scrollViewer.SetValue(ScrollViewer.VerticalScrollBarVisibilityProperty, ScrollBarVisibility.Auto);
            scrollViewer.AppendChild(itemsPresenter);
            controlTemplate.VisualTree = scrollViewer;
            controlTemplate.Seal();
            style.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            style.Setters.Add(new Setter(BackgroundProperty, defaultBackgroundColor));
            style.Setters.Add(new Setter(BorderBrushProperty, null));
            style.Setters.Add(new Setter(ForegroundProperty, null));
            style.Setters.Add(new Setter(PaddingProperty, thickness));
            style.Setters.Add(new Setter(BorderThicknessProperty, thickness));
            style.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            style.Seal();
        }

        public static void InitializeItemContainerStyle()
        {
            ControlTemplate controlTemplate = new(typeof(TreeViewItem));
            FrameworkElementFactory stackPanel = new(typeof(StackPanel));
            FrameworkElementFactory dockPanel = new(typeof(DockPanel));
            FrameworkElementFactory toggleButton = new(typeof(ToggleButton), nameof(toggleButton));
            FrameworkElementFactory contentPresenter = new(typeof(ContentPresenter));
            FrameworkElementFactory itemsPresenter = new(typeof(ItemsPresenter), nameof(itemsPresenter));
            Trigger trigger1 = new() { Property = HasItemsProperty, Value = false };
            Trigger trigger2 = new() { Property = TreeViewItem.IsExpandedProperty, Value = false };
            Trigger trigger3 = new() { Property = TreeViewItem.IsSelectedProperty, Value = true };
            dockPanel.SetValue(BackgroundProperty, new TemplateBindingExtension(BackgroundProperty));
            toggleButton.SetValue(StyleProperty, toggleButtonStyle);
            toggleButton.SetBinding(ToggleButton.IsCheckedProperty, new Binding() { Path = new PropertyPath(nameof(TreeViewItem.IsExpanded)), RelativeSource = new RelativeSource(RelativeSourceMode.TemplatedParent) });
            contentPresenter.SetValue(ContentPresenter.ContentSourceProperty, nameof(TreeViewItem.Header));
            itemsPresenter.SetValue(MarginProperty, new Thickness(16, 0, 0, 0));
            controlTemplate.VisualTree = stackPanel;
            stackPanel.AppendChild(dockPanel);
            stackPanel.AppendChild(itemsPresenter);
            dockPanel.AppendChild(toggleButton);
            dockPanel.AppendChild(contentPresenter);
            trigger1.Setters.Add(new Setter(VisibilityProperty, Visibility.Hidden, nameof(toggleButton)));
            trigger2.Setters.Add(new Setter(VisibilityProperty, Visibility.Collapsed, nameof(itemsPresenter)));
            trigger3.Setters.Add(new Setter(BackgroundProperty, selectedBackgroundColor));
            controlTemplate.Triggers.Add(trigger1);
            controlTemplate.Triggers.Add(trigger2);
            controlTemplate.Triggers.Add(trigger3);
            controlTemplate.Seal();
            itemContainerStyle.Setters.Add(new Setter(TreeViewItem.IsExpandedProperty, true));
            itemContainerStyle.Setters.Add(new Setter(BackgroundProperty, defaultBackgroundColor));
            itemContainerStyle.Setters.Add(new Setter(BorderBrushProperty, null));
            itemContainerStyle.Setters.Add(new Setter(ForegroundProperty, null));
            itemContainerStyle.Setters.Add(new Setter(PaddingProperty, thickness));
            itemContainerStyle.Setters.Add(new Setter(BorderThicknessProperty, thickness));
            itemContainerStyle.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            itemContainerStyle.Seal();
        }
    }

    public partial class I12TreeView1 : TreeView
    {
        public I12TreeView1()
        {
            FocusVisualStyle = I12FocusVisibleStyle.Style1;
            Style = style;
            ItemContainerStyle = itemContainerStyle;
        }
    }
}