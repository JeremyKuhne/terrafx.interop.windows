// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RESOURCE_BARRIER_TYPE.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER_TYPE"]/*' />
public enum D3D12_RESOURCE_BARRIER_TYPE
{
    /// <include file='D3D12_RESOURCE_BARRIER_TYPE.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER_TYPE.D3D12_RESOURCE_BARRIER_TYPE_TRANSITION"]/*' />
    D3D12_RESOURCE_BARRIER_TYPE_TRANSITION = 0,

    /// <include file='D3D12_RESOURCE_BARRIER_TYPE.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER_TYPE.D3D12_RESOURCE_BARRIER_TYPE_ALIASING"]/*' />
    D3D12_RESOURCE_BARRIER_TYPE_ALIASING = (D3D12_RESOURCE_BARRIER_TYPE_TRANSITION + 1),

    /// <include file='D3D12_RESOURCE_BARRIER_TYPE.xml' path='doc/member[@name="D3D12_RESOURCE_BARRIER_TYPE.D3D12_RESOURCE_BARRIER_TYPE_UAV"]/*' />
    D3D12_RESOURCE_BARRIER_TYPE_UAV = (D3D12_RESOURCE_BARRIER_TYPE_ALIASING + 1),
}
