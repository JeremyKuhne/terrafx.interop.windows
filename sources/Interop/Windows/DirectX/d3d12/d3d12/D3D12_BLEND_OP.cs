// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_BLEND_OP.xml' path='doc/member[@name="D3D12_BLEND_OP"]/*' />
public enum D3D12_BLEND_OP
{
    /// <include file='D3D12_BLEND_OP.xml' path='doc/member[@name="D3D12_BLEND_OP.D3D12_BLEND_OP_ADD"]/*' />
    D3D12_BLEND_OP_ADD = 1,

    /// <include file='D3D12_BLEND_OP.xml' path='doc/member[@name="D3D12_BLEND_OP.D3D12_BLEND_OP_SUBTRACT"]/*' />
    D3D12_BLEND_OP_SUBTRACT = 2,

    /// <include file='D3D12_BLEND_OP.xml' path='doc/member[@name="D3D12_BLEND_OP.D3D12_BLEND_OP_REV_SUBTRACT"]/*' />
    D3D12_BLEND_OP_REV_SUBTRACT = 3,

    /// <include file='D3D12_BLEND_OP.xml' path='doc/member[@name="D3D12_BLEND_OP.D3D12_BLEND_OP_MIN"]/*' />
    D3D12_BLEND_OP_MIN = 4,

    /// <include file='D3D12_BLEND_OP.xml' path='doc/member[@name="D3D12_BLEND_OP.D3D12_BLEND_OP_MAX"]/*' />
    D3D12_BLEND_OP_MAX = 5,
}
