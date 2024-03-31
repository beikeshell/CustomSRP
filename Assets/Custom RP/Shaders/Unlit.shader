Shader "Custom RP/Unlit"
{
    Properties
    {
        _BaseColor("Base Color", Color) = (1.0, 1.0, 0.0, 1.0)
        [Enum(UnityEngine.Rendering.BlendMode)]
        _SrcBlend("Src Blend", Float) = 1
        [Enum(UnityEngine.Rendering.BlendMode)]
        _DestBlend("Dest Blend", Float) = 0
    }
    
    SubShader
    {
        Pass
        {
            Blend [_SrcBlend] [_DestBlend]
            
            HLSLPROGRAM

            #pragma multi_compile_instancing
            #pragma vertex UnlitPassVertex
            #pragma fragment UnlitPassFragment
            #include "UnlitPass.hlsl"
            
            ENDHLSL
        }
    }
}