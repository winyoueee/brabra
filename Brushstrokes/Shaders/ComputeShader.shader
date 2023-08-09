// ComputeShader.shader
#pragma kernel CSMain

RWTexture3D<float4> Result;
int3 Dims;

[numthreads(8,8,8)]
void CSMain (uint3 id : SV_DispatchThreadID)
{
    if (id.x < Dims.x && id.y < Dims.y && id.z < Dims.z)
    {
        float4 color = float4(0, 0, 0, 0);
        Result[id] = color;
    }
}