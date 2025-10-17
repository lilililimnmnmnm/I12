sampler2D _s0 : register(s0);
float4 _c0 : register(c0);

float4 main(float2 uv : TEXCOORD0) : COLOR0
{
    float4 __s0 = tex2D(_s0, uv);
    float3 __c0 = _c0.rgb;
    float3 result = (__s0.rgb < 0.5) ? (2.0 * __s0.rgb * __c0) : (1.0 - 2.0 * (1.0 - __s0.rgb) * (1.0 - __c0));
    return float4(result, 1.0);
}