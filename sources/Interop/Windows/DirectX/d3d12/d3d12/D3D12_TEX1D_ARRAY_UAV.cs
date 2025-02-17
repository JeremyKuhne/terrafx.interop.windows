// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEX1D_ARRAY_UAV.xml' path='doc/member[@name="D3D12_TEX1D_ARRAY_UAV"]/*' />
public partial struct D3D12_TEX1D_ARRAY_UAV
{
    /// <include file='D3D12_TEX1D_ARRAY_UAV.xml' path='doc/member[@name="D3D12_TEX1D_ARRAY_UAV.MipSlice"]/*' />
    public uint MipSlice;

    /// <include file='D3D12_TEX1D_ARRAY_UAV.xml' path='doc/member[@name="D3D12_TEX1D_ARRAY_UAV.FirstArraySlice"]/*' />
    public uint FirstArraySlice;

    /// <include file='D3D12_TEX1D_ARRAY_UAV.xml' path='doc/member[@name="D3D12_TEX1D_ARRAY_UAV.ArraySize"]/*' />
    public uint ArraySize;
}
