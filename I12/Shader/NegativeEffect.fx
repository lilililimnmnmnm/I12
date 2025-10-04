sampler2D _s0 : register(s0);

float4 main(float2 uv : TEXCOORD0) : COLOR0
{
    float4 __s0 = tex2D(_s0, uv);
    return float4(1.0f - __s0.rgb, __s0.a);
}