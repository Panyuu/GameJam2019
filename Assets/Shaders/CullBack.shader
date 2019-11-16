Shader "Unlit/CullBack"
{
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        Pass
        {
            Cull Back
        }
    }
}
