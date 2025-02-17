// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12shader.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SHADER_BUFFER_DESC.xml' path='doc/member[@name="D3D12_SHADER_BUFFER_DESC"]/*' />
public unsafe partial struct D3D12_SHADER_BUFFER_DESC
{
    /// <include file='D3D12_SHADER_BUFFER_DESC.xml' path='doc/member[@name="D3D12_SHADER_BUFFER_DESC.Name"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;

    /// <include file='D3D12_SHADER_BUFFER_DESC.xml' path='doc/member[@name="D3D12_SHADER_BUFFER_DESC.Type"]/*' />
    public D3D_CBUFFER_TYPE Type;

    /// <include file='D3D12_SHADER_BUFFER_DESC.xml' path='doc/member[@name="D3D12_SHADER_BUFFER_DESC.Variables"]/*' />
    public uint Variables;

    /// <include file='D3D12_SHADER_BUFFER_DESC.xml' path='doc/member[@name="D3D12_SHADER_BUFFER_DESC.Size"]/*' />
    public uint Size;

    /// <include file='D3D12_SHADER_BUFFER_DESC.xml' path='doc/member[@name="D3D12_SHADER_BUFFER_DESC.uFlags"]/*' />
    public uint uFlags;
}
