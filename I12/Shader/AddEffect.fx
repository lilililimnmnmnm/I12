sampler2D _s0 : register(s0);
sampler2D _s1 : register(s1);

float4 main(float2 uv : TEXCOORD0) : COLOR0
{
    float4 __s0 = tex2D(_s0, uv);
    float4 __s1 = tex2D(_s1, uv);
    float r, g, b, a;
    r = __s0.r + __s1.r * __s1.a;
    g = __s0.g + __s1.g * __s1.a;
    b = __s0.b + __s1.b * __s1.a;
    a = __s0.a + __s1.a * __s1.a;
    if (r > 1.0f) r = 1.0f;
    if (g > 1.0f) g = 1.0f;
    if (b > 1.0f) b = 1.0f;
    if (a > 1.0f) a = 1.0f;
    return float4(r, g, b, a);
}