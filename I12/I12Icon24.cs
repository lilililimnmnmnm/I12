using System.Windows;
using System.Windows.Media;

namespace I12
{
    public class I12Icon24 : FrameworkElement
    {
        private static readonly DrawingGroup drawingGroup = new();

        static I12Icon24()
        {
            drawingGroup.Freeze();
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register(nameof(Icon), typeof(DrawingGroup), typeof(I12Icon24), new FrameworkPropertyMetadata(drawingGroup, FrameworkPropertyMetadataOptions.AffectsRender));
        public DrawingGroup Icon { get => (DrawingGroup)GetValue(IconProperty); set => SetValue(IconProperty, value); }

        public I12Icon24() : base()
        {
            SnapsToDevicePixels = true;
            Width = 24;
            Height = 24;
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            drawingContext.DrawDrawing(Icon);
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
                    isIconSourceInitialized = true;
                    Activator.CreateInstance<T>();
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