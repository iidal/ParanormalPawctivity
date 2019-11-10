Shader "Unlit/Highlight"
{
	Properties
	{
		_MainTex ("Texture", 2D) = "white" {}
		_OutlineColor("Outline color", Color) = (0,0,0,1)
		_OutlineWidth("Outline width", Range(1.0, 5.0)) = 1.1 //outline starts from one, 1.01 is very small
		_Color("Main Color", Color) = (0,0,0,0) //0.5,0.5,0.5,1
	}


	CGINCLUDE
	#include "UnityCG.cginc"

	struct appdata
			{
				float4 vertex : POSITION;
				float3 normal : NORMAL; // normal of that vertex
			};

			struct v2f
			{
				float4 pos : POSITION;
				//float4 color : COLOR;
				float3 normal : NORMAL;
			};

			//declaring outlinecolor and width
			float _OutlineWidth;
			float4 _OutlineColor;

				//vertex shader
			v2f vert(appdata v)
			{ //same mesh as the object but little bigger
				v.vertex.xyz *= _OutlineWidth;

				
				v2f o;
				UNITY_INITIALIZE_OUTPUT(v2f, o);
				o.pos = UnityObjectToClipPos(v.vertex); // back to world space

				//o.color = _OutlineColor; // above when multiplying the vertices, this will be that color
				return o;
			}


		ENDCG

	SubShader
	{
		Tags { "Queue" = "Transparent"}

		Pass //Rendering outline
		{
			
			//ZTest GEqual
			ZWrite off // other things can be rendered on this

			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			half4 frag(v2f i) : COLOR //i = vertex, siihen väri
			{	// 
				return _OutlineColor;
			}

			ENDCG
		
			
		}
		Pass//Render object on top (normal render)
		{	
			Zwrite On

			Material
			{
				Diffuse[_Color]
				Ambient[_Color]
			}
			Lighting On
		
			SetTexture[_MainTex]{
			ConstantColor[_Color]
			}
			SetTexture[_MainTex]{
				Combine previous * primary DOUBLE
			}

		}
	}
	}
