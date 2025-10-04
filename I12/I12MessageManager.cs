using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace I12
{
    public static class I12MessageManager
    {
        public readonly static List<I12MessageControl> MemberList = [];

        public static void ShowMessage(string message)
        {
            foreach (I12MessageControl member in MemberList)
            {
                member.ShowMessage(message);
            }
        }

        public static void ShowErrorMessage(string message)
        {
            foreach (I12MessageControl member in MemberList)
            {
                member.ShowErrorMessage(message);
            }
        }

        public static void ShowImportantMessage(string message)
        {
            foreach (I12MessageControl member in MemberList)
            {
                member.ShowImportantMessage(message);
            }
        }
    }

    public enum I12MessageType
    {
        Notify,
        Error,
        Important
    }

    public class I12MessageControl : Control
    {
        public static readonly DependencyProperty MessageTypeProperty = DependencyProperty.Register(nameof(MessageType), typeof(I12MessageType), typeof(I12MessageControl1), new PropertyMetadata(I12MessageType.Notify));
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string), typeof(I12MessageControl1), new PropertyMetadata(string.Empty));
        public I12MessageType MessageType { get => (I12MessageType)GetValue(MessageTypeProperty); set => SetValue(MessageTypeProperty, value); }
        public string Text { get => (string)GetValue(TextProperty); set => SetValue(TextProperty, value); }

        public I12MessageControl()
        {
            Loaded += (sender, e) => I12MessageManager.MemberList.Add(this);
            Unloaded += (sender, e) => I12MessageManager.MemberList.Remove(this);
        }

        public virtual void ShowMessage(string message)
        {
            SetCurrentValue(MessageTypeProperty, I12MessageType.Notify);
            SetCurrentValue(TextProperty, message);
        }

        public virtual void ShowErrorMessage(string message)
        {
            SetCurrentValue(MessageTypeProperty, I12MessageType.Error);
            SetCurrentValue(TextProperty, message);
        }

        public virtual void ShowImportantMessage(string message)
        {
            SetCurrentValue(MessageTypeProperty, I12MessageType.Important);
            SetCurrentValue(TextProperty, message);
        }
    }

    public partial class I12MessageControl1 : I12MessageControl
    {
        private static readonly Style style = new(typeof(I12MessageControl1));
        private static readonly SolidColorBrush defaultBackgroundColor = new(Color.FromRgb(70, 110, 170));
        private static readonly SolidColorBrush defaultBorderColor = new(Color.FromRgb(70, 110, 170));
        private static readonly SolidColorBrush defaultForegroundColor = new(Color.FromRgb(255, 255, 255));
        private static readonly SolidColorBrush errorBackgroundColor = new(Color.FromRgb(200, 80, 80));
        private static readonly SolidColorBrush errorBorderColor = new(Color.FromRgb(200, 80, 80));
        private static readonly SolidColorBrush errorForegroundColor = new(Color.FromRgb(255, 255, 255));
        private static readonly SolidColorBrush importantBackgroundColor = new(Color.FromRgb(50, 160, 100));
        private static readonly SolidColorBrush importantBorderColor = new(Color.FromRgb(50, 160, 100));
        private static readonly SolidColorBrush importantForegroundColor = new(Color.FromRgb(255, 255, 255));
        private static readonly Thickness borderThickness = new(0);
        private static readonly Thickness padding = new(12, 6, 12, 6);
        private static readonly double fontSize = 13.0;

        static I12MessageControl1()
        {
            defaultBackgroundColor.Freeze();
            defaultBorderColor.Freeze();
            defaultForegroundColor.Freeze();
            errorBackgroundColor.Freeze();
            errorBorderColor.Freeze();
            errorForegroundColor.Freeze();
            importantBackgroundColor.Freeze();
            importantBorderColor.Freeze();
            importantForegroundColor.Freeze();
            ControlTemplate controlTemplate = new(typeof(I12MessageControl1));
            FrameworkElementFactory border = new(typeof(Border));
            FrameworkElementFactory textBlock = new(typeof(TextBlock));
            Trigger error = new() { Property = MessageTypeProperty, Value = I12MessageType.Error };
            Trigger important = new() { Property = MessageTypeProperty, Value = I12MessageType.Important };
            border.SetValue(SnapsToDevicePixelsProperty, true);
            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(BackgroundProperty));
            border.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(BorderBrushProperty));
            border.SetValue(Border.BorderThicknessProperty, new TemplateBindingExtension(BorderThicknessProperty));
            border.SetValue(Border.PaddingProperty, new TemplateBindingExtension(PaddingProperty));
            textBlock.SetValue(TextBlock.ForegroundProperty, new TemplateBindingExtension(ForegroundProperty));
            textBlock.SetValue(TextBlock.TextProperty, new TemplateBindingExtension(TextProperty));
            error.Setters.Add(new Setter(BackgroundProperty, errorBackgroundColor));
            error.Setters.Add(new Setter(BorderBrushProperty, errorBorderColor));
            error.Setters.Add(new Setter(ForegroundProperty, errorForegroundColor));
            important.Setters.Add(new Setter(BackgroundProperty, importantBackgroundColor));
            important.Setters.Add(new Setter(BorderBrushProperty, importantBorderColor));
            important.Setters.Add(new Setter(ForegroundProperty, importantForegroundColor));
            border.AppendChild(textBlock);
            controlTemplate.VisualTree = border;
            controlTemplate.Seal();
            style.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            style.Setters.Add(new Setter(FocusableProperty, false));
            style.Setters.Add(new Setter(BackgroundProperty, defaultBackgroundColor));
            style.Setters.Add(new Setter(BorderBrushProperty, defaultBorderColor));
            style.Setters.Add(new Setter(ForegroundProperty, defaultForegroundColor));
            style.Setters.Add(new Setter(PaddingProperty, padding));
            style.Setters.Add(new Setter(BorderThicknessProperty, borderThickness));
            style.Setters.Add(new Setter(FontSizeProperty, fontSize));
            style.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            style.Triggers.Add(error);
            style.Triggers.Add(important);
            style.Seal();
        }

        public I12MessageControl1()
        {
            Style = style;
        }
    }

    public class DelayExponentialEase : EasingFunctionBase
    {
        protected override Freezable CreateInstanceCore()
        {
            return new DelayExponentialEase();
        }

        protected override double EaseInCore(double normalizedTime)
        {
            if (normalizedTime < 0.8)
            {
                return 0.0;
            }
            else
            {
                double t = (normalizedTime - 0.8) / 0.2;
                return Math.Pow(2, 10 * (t - 1));
            }
        }
    }

    public partial class I12MessageControl2 : I12MessageControl
    {
        private static readonly Style style = new(typeof(I12MessageControl2));
        private static readonly SolidColorBrush defaultBackgroundColor = new(Color.FromRgb(70, 110, 170));
        private static readonly SolidColorBrush defaultBorderColor = new(Color.FromRgb(70, 110, 170));
        private static readonly SolidColorBrush defaultForegroundColor = new(Color.FromRgb(255, 255, 255));
        private static readonly SolidColorBrush errorBackgroundColor = new(Color.FromRgb(255, 100, 100));
        private static readonly SolidColorBrush errorBorderColor = new(Color.FromRgb(255, 100, 100));
        private static readonly SolidColorBrush errorForegroundColor = new(Color.FromRgb(255, 255, 255));
        private static readonly SolidColorBrush importantBackgroundColor = new(Color.FromRgb(50, 180, 120));
        private static readonly SolidColorBrush importantBorderColor = new(Color.FromRgb(50, 180, 120));
        private static readonly SolidColorBrush importantForegroundColor = new(Color.FromRgb(255, 255, 255));
        private static readonly CornerRadius cornerRadius = new(4);
        private static readonly Thickness borderThickness = new(0);
        private static readonly Thickness padding = new(16);
        private static readonly double fontSize = 14.0;

        static I12MessageControl2()
        {
            defaultBackgroundColor.Freeze();
            defaultBorderColor.Freeze();
            defaultForegroundColor.Freeze();
            errorBackgroundColor.Freeze();
            errorBorderColor.Freeze();
            errorForegroundColor.Freeze();
            importantBackgroundColor.Freeze();
            importantBorderColor.Freeze();
            importantForegroundColor.Freeze();
            ControlTemplate controlTemplate = new(typeof(I12MessageControl2));
            FrameworkElementFactory border = new(typeof(Border));
            FrameworkElementFactory textBlock = new(typeof(TextBlock));
            Trigger error = new() { Property = MessageTypeProperty, Value = I12MessageType.Error };
            Trigger important = new() { Property = MessageTypeProperty, Value = I12MessageType.Important };
            Trigger opacity = new() { Property = OpacityProperty, Value = 0.0 };
            border.SetValue(SnapsToDevicePixelsProperty, true);
            border.SetValue(Border.CornerRadiusProperty, cornerRadius);
            border.SetValue(Border.BackgroundProperty, new TemplateBindingExtension(BackgroundProperty));
            border.SetValue(Border.BorderBrushProperty, new TemplateBindingExtension(BorderBrushProperty));
            border.SetValue(Border.BorderThicknessProperty, new TemplateBindingExtension(BorderThicknessProperty));
            border.SetValue(Border.PaddingProperty, new TemplateBindingExtension(PaddingProperty));
            textBlock.SetValue(TextBlock.ForegroundProperty, new TemplateBindingExtension(ForegroundProperty));
            textBlock.SetValue(TextBlock.TextProperty, new TemplateBindingExtension(TextProperty));
            error.Setters.Add(new Setter(BackgroundProperty, errorBackgroundColor));
            error.Setters.Add(new Setter(BorderBrushProperty, errorBorderColor));
            error.Setters.Add(new Setter(ForegroundProperty, errorForegroundColor));
            important.Setters.Add(new Setter(BackgroundProperty, importantBackgroundColor));
            important.Setters.Add(new Setter(BorderBrushProperty, importantBorderColor));
            important.Setters.Add(new Setter(ForegroundProperty, importantForegroundColor));
            opacity.Setters.Add(new Setter(IsHitTestVisibleProperty, false));
            border.AppendChild(textBlock);
            controlTemplate.VisualTree = border;
            controlTemplate.Seal();
            style.Setters.Add(new Setter(IsHitTestVisibleProperty, true));
            style.Setters.Add(new Setter(SnapsToDevicePixelsProperty, true));
            style.Setters.Add(new Setter(OpacityProperty, 0.0));
            style.Setters.Add(new Setter(FocusableProperty, false));
            style.Setters.Add(new Setter(BackgroundProperty, defaultBackgroundColor));
            style.Setters.Add(new Setter(BorderBrushProperty, defaultBorderColor));
            style.Setters.Add(new Setter(ForegroundProperty, defaultForegroundColor));
            style.Setters.Add(new Setter(HorizontalAlignmentProperty, HorizontalAlignment.Center));
            style.Setters.Add(new Setter(VerticalAlignmentProperty, VerticalAlignment.Center));
            style.Setters.Add(new Setter(PaddingProperty, padding));
            style.Setters.Add(new Setter(BorderThicknessProperty, borderThickness));
            style.Setters.Add(new Setter(FontSizeProperty, fontSize));
            style.Setters.Add(new Setter(TemplateProperty, controlTemplate));
            style.Triggers.Add(error);
            style.Triggers.Add(important);
            style.Triggers.Add(opacity);
            style.Seal();
        }

        private static readonly DoubleAnimation opacityAnimation = new(1.0, 0.1, new Duration(new TimeSpan(0, 0, 5)), FillBehavior.Stop)
        {
            EasingFunction = new DelayExponentialEase() { EasingMode = EasingMode.EaseIn }
        };

        public I12MessageControl2()
        {
            Style = style;
        }

        public override void ShowMessage(string message)
        {
            Visibility = Visibility.Hidden;
        }

        public override void ShowErrorMessage(string message)
        {
            base.ShowErrorMessage(message);
            Visibility = Visibility.Visible;
            BeginAnimation(OpacityProperty, opacityAnimation);
        }

        public override void ShowImportantMessage(string message)
        {
            base.ShowImportantMessage(message);
            Visibility = Visibility.Visible;
            BeginAnimation(OpacityProperty, opacityAnimation);
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            Visibility = Visibility.Hidden;
        }
    }
}