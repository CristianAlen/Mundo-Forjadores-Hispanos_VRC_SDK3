// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

//basic CG shader with a texture and an alpha - Double Sided

Shader "LiveDimensions/ScreenSpaceTexture"
{
	Properties
	{
		_Color("Shader Color", Color) = (0.3,0.3,0.3,1)
        _MainTex ("Texture", 2D) = "white" {}

	}
	SubShader
	{
		Tags {"Queue" = "Transparent" }
		//INSIDE OF SPHERE (USES RENDER TEXTURE)
		Pass
		{

			//Cull back faces so we can write front faces over the last pass
			Cull Front

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			sampler2D _MainTex;

			float4 vert(appdata_base v) : SV_POSITION
            {
                return UnityObjectToClipPos(v.vertex);
            }

			fixed4 frag(float4 i : VPOS) : SV_Target
			{
					return tex2D(_MainTex, ((i.xy / _ScreenParams.xy)));
			}
			ENDCG

		}
		
		//OUTSIDE OF SPHERE (USES RENDER TEXTURE * COLOR)
		Pass
		{
			ZWrite Off
			AlphaTest Greater 0.01

			//Cull front faces first
			Cull Back

			CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #pragma target 2.0
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata_t {
                float4 vertex : POSITION;
                UNITY_VERTEX_INPUT_INSTANCE_ID
            };

            struct v2f {
                float4 vertex : SV_POSITION;
                UNITY_FOG_COORDS(0)
                UNITY_VERTEX_OUTPUT_STEREO
            };

            fixed4 _Color;

            v2f vert (appdata_t v)
            {
                v2f o;
                UNITY_SETUP_INSTANCE_ID(v);
                UNITY_INITIALIZE_VERTEX_OUTPUT_STEREO(o);
                o.vertex = UnityObjectToClipPos(v.vertex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : COLOR
            {
                fixed4 col = _Color;
                UNITY_APPLY_FOG(i.fogCoord, col);
                UNITY_OPAQUE_ALPHA(col.a);
                return col;
            }
        ENDCG
		}
	}
}