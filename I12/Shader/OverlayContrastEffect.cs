using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace I12.Shader
{
    public class OverlayContrastEffect : ShaderEffect
    {
        private static readonly PixelShader pixelShader = new() { UriSource = new Uri("pack://application:,,,/I12;component/Shader/OverlayContrastEffect.ps", UriKind.Absolute) };
        public static readonly DependencyProperty S0Property = RegisterPixelShaderSamplerProperty(nameof(S0), typeof(OverlayContrastEffect), 0);
        public static readonly DependencyProperty C0Property = DependencyProperty.Register(nameof(C0), typeof(Color), typeof(OverlayContrastEffect), new UIPropertyMetadata(Color.FromArgb(255, 127, 127, 127), PixelShaderConstantCallback(0)));
        public Brush S0 { get => (Brush)GetValue(S0Property); set => SetValue(S0Property, value); }
        public Color C0 { get => (Color)GetValue(C0Property); set => SetValue(C0Property, value); }

        public OverlayContrastEffect()
        {
            PixelShader = pixelShader;
            UpdateShaderValue(S0Property);
            UpdateShaderValue(C0Property);
        }
    }
}