using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24 : FrameworkElement
    {
        private static readonly DrawingGroup drawingGroup = new();
        private static readonly Style style = new(typeof(I12Icon24));

        static I12Icon24()
        {
            drawingGroup.Freeze();
            style.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            style.Setters.Add(new Setter(MinHeightProperty, 24.0));
            style.Setters.Add(new Setter(MinWidthProperty, 24.0));
            style.Setters.Add(new Setter(HeightProperty, 24.0));
            style.Setters.Add(new Setter(WidthProperty, 24.0));
            style.Seal();
        }

        public I12Icon24() : base()
        {
            Style = style;
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(nameof(Icon), typeof(DrawingGroup), typeof(I12Icon24), new FrameworkPropertyMetadata(drawingGroup, FrameworkPropertyMetadataOptions.AffectsRender));
        public DrawingGroup Icon { get => (DrawingGroup)GetValue(IconProperty); set => SetValue(IconProperty, value); }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            drawingContext.DrawDrawing(Icon);
        }

        protected override Size MeasureOverride(Size availableSize)
        {
            return new Size(24.0, 24.0);
        }
    }

    public class I12Icon24Generic<T> : I12Icon24
    {
        private static bool isIconSourceInitialized;
        protected static readonly DrawingGroup iconSource = new();
        public static DrawingGroup IconSource
        {
            get
            {
                if (!isIconSourceInitialized)
                {
                    Activator.CreateInstance<T>();
                    isIconSourceInitialized = true;
                }
                return iconSource;
            }
        }

        public I12Icon24Generic() : base()
        {
            Icon = iconSource;
        }
    }
}