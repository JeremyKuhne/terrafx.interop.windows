// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEXTURE_COPY_TYPE.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_TYPE"]/*' />
public enum D3D12_TEXTURE_COPY_TYPE
{
    /// <include file='D3D12_TEXTURE_COPY_TYPE.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_TYPE.D3D12_TEXTURE_COPY_TYPE_SUBRESOURCE_INDEX"]/*' />
    D3D12_TEXTURE_COPY_TYPE_SUBRESOURCE_INDEX = 0,

    /// <include file='D3D12_TEXTURE_COPY_TYPE.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_TYPE.D3D12_TEXTURE_COPY_TYPE_PLACED_FOOTPRINT"]/*' />
    D3D12_TEXTURE_COPY_TYPE_PLACED_FOOTPRINT = 1,
}
