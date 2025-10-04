using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace I12.Shader
{
    public class NegativeEffect : ShaderEffect
    {
        private static readonly PixelShader pixelShader = new() { UriSource = new Uri("pack://application:,,,/I12;component/Shader/NegativeEffect.ps", UriKind.Absolute) };
        public static readonly DependencyProperty S0Property = RegisterPixelShaderSamplerProperty(nameof(S0), typeof(NegativeEffect), 0);
        public Brush S0 { get => (Brush)GetValue(S0Property); set => SetValue(S0Property, value); }

        public NegativeEffect()
        {
            PixelShader = pixelShader;
            UpdateShaderValue(S0Property);
        }
    }
}