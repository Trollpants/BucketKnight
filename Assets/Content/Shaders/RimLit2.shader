Shader "Custom/RimLit" {
Properties {
	_RimColor ("Rim Color", Color) = (0.26,0.19,0.16,0.0)
	_RimPower ("Rim Power", Range(0.5,8.0)) = 3.0
	_AlphPower ("Alpha Rim Power", Range(0.0,8.0)) = 3.0
	_AlphaMin ("Alpha Minimum", Range(0.0,1.0)) = 0.5

}
SubShader {
	Tags { "Queue" = "Transparent" }

		CGPROGRAM
		#pragma surface surf Lambert alpha
		struct Input {
		float2 uv_MainTex;
		float3 worldRefl;
		float3 viewDir;
		INTERNAL_DATA
	};
	float4 _RimColor;
	float _RimPower;
	float _AlphPower;
	float _AlphaMin;
	void surf (Input IN, inout SurfaceOutput o) {
		half rim = 1.0 - saturate(dot (normalize(IN.viewDir), o.Normal));
		o.Emission = _RimColor.rgb * pow (rim, _RimPower)*2 ;
		o.Alpha = (pow (rim, _AlphPower)*(1-_AlphaMin))+_AlphaMin ;
	}
	ENDCG
}
Fallback "VertexLit"
} 