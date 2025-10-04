using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Effects;

namespace I12.Shader
{
    public class AddEffect : ShaderEffect
    {
        private static readonly PixelShader pixelShader = new() { UriSource = new Uri("pack://application:,,,/I12;component/Shader/AddEffect.ps", UriKind.Absolute) };
        public static readonly DependencyProperty S0Property = RegisterPixelShaderSamplerProperty(nameof(S0), typeof(AddEffect), 0);
        public static readonly DependencyProperty S1Property = RegisterPixelShaderSamplerProperty(nameof(S1), typeof(AddEffect), 1);
        public Brush S0 { get => (Brush)GetValue(S0Property); set => SetValue(S0Property, value); }
        public Brush S1 { get => (Brush)GetValue(S1Property); set => SetValue(S1Property, value); }

        public AddEffect()
        {
            PixelShader = pixelShader;
            UpdateShaderValue(S0Property);
            UpdateShaderValue(S1Property);
        }
    }
}