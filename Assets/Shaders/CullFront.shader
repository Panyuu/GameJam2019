Shader "Unlit/CullFront"
{
    SubShader
    {
        Tags { "RenderType"="Opaque" }

        Pass
        {
            Cull Front
        }
    }
}
