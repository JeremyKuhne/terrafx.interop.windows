// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_TILED_RESOURCE_COORDINATE"]/*' />
public partial struct D3D12_TILED_RESOURCE_COORDINATE
{
    /// <include file='D3D12_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_TILED_RESOURCE_COORDINATE.X"]/*' />
    public uint X;

    /// <include file='D3D12_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_TILED_RESOURCE_COORDINATE.Y"]/*' />
    public uint Y;

    /// <include file='D3D12_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_TILED_RESOURCE_COORDINATE.Z"]/*' />
    public uint Z;

    /// <include file='D3D12_TILED_RESOURCE_COORDINATE.xml' path='doc/member[@name="D3D12_TILED_RESOURCE_COORDINATE.Subresource"]/*' />
    public uint Subresource;
}
