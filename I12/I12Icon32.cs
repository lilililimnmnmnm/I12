using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon32 : FrameworkElement
    {
        private static readonly DrawingGroup drawingGroup = new();
        private static readonly Size size = new(32, 32);

        static I12Icon32()
        {
            drawingGroup.Freeze();
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(nameof(Icon), typeof(DrawingGroup), typeof(I12Icon32), new FrameworkPropertyMetadata(drawingGroup, FrameworkPropertyMetadataOptions.AffectsRender));
        public DrawingGroup Icon { get => (DrawingGroup)GetValue(IconProperty); set => SetValue(IconProperty, value); }

        protected override Size MeasureOverride(Size availableSize)
        {
            return size;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.PushClip(new RectangleGeometry(new Rect(0, 0, ActualWidth, ActualHeight)));
            drawingContext.DrawDrawing(Icon);
            drawingContext.Pop();
        }
    }

    public class I12Icon32Generic<T> : I12Icon32
    {
        private static bool isIconSourceInitialized;
        protected static readonly DrawingGroup iconSource = new();

        public static DrawingGroup IconSource
        {
            get
            {
                if (!isIconSourceInitialized)
                {
                    isIconSourceInitialized = true;
                    Activator.CreateInstance<T>();
                }
                return iconSource;
            }
        }

        public I12Icon32Generic() : base()
        {
            Icon = iconSource;
        }
    }
}