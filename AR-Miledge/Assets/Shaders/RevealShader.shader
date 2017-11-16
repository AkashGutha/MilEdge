Shader "Image Effects/RevealShader"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_CutOff ("Cut off", Range( 0, 1 )) = 0.5
		_Color ("Overlay Color", Color) = (0,0,0,1)
	}
	SubShader
	{
		// No culling or depth
		Cull Off ZWrite Off ZTest Always

		Pass
		{
			CGPROGRAM
			#pragma vertex vert_img
			#pragma fragment frag
			
			#include "UnityCG.cginc"

			sampler2D _MainTex;
			fixed4 _Color;
			float _CutOff;

			fixed4 frag (v2f_img i) : SV_Target
			{
				if(i.uv.x < _CutOff){
					return _Color;
				}

				fixed4 col = tex2D(_MainTex, i.uv);
				return col;
			}
			ENDCG
		}
	}
}
