Shader "Unlit/CullOff"
{
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        Pass
        {
            Cull Off
        }
    }
}
