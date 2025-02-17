// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PLACED_SUBRESOURCE_FOOTPRINT.xml' path='doc/member[@name="D3D12_PLACED_SUBRESOURCE_FOOTPRINT"]/*' />
public partial struct D3D12_PLACED_SUBRESOURCE_FOOTPRINT
{
    /// <include file='D3D12_PLACED_SUBRESOURCE_FOOTPRINT.xml' path='doc/member[@name="D3D12_PLACED_SUBRESOURCE_FOOTPRINT.Offset"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Offset;

    /// <include file='D3D12_PLACED_SUBRESOURCE_FOOTPRINT.xml' path='doc/member[@name="D3D12_PLACED_SUBRESOURCE_FOOTPRINT.Footprint"]/*' />
    public D3D12_SUBRESOURCE_FOOTPRINT Footprint;
}
