// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_BUFFER_SRV.xml' path='doc/member[@name="D3D12_BUFFER_SRV"]/*' />
public partial struct D3D12_BUFFER_SRV
{
    /// <include file='D3D12_BUFFER_SRV.xml' path='doc/member[@name="D3D12_BUFFER_SRV.FirstElement"]/*' />
    [NativeTypeName("UINT64")]
    public ulong FirstElement;

    /// <include file='D3D12_BUFFER_SRV.xml' path='doc/member[@name="D3D12_BUFFER_SRV.NumElements"]/*' />
    public uint NumElements;

    /// <include file='D3D12_BUFFER_SRV.xml' path='doc/member[@name="D3D12_BUFFER_SRV.StructureByteStride"]/*' />
    public uint StructureByteStride;

    /// <include file='D3D12_BUFFER_SRV.xml' path='doc/member[@name="D3D12_BUFFER_SRV.Flags"]/*' />
    public D3D12_BUFFER_SRV_FLAGS Flags;
}
