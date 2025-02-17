// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PREDICATION_OP.xml' path='doc/member[@name="D3D12_PREDICATION_OP"]/*' />
public enum D3D12_PREDICATION_OP
{
    /// <include file='D3D12_PREDICATION_OP.xml' path='doc/member[@name="D3D12_PREDICATION_OP.D3D12_PREDICATION_OP_EQUAL_ZERO"]/*' />
    D3D12_PREDICATION_OP_EQUAL_ZERO = 0,

    /// <include file='D3D12_PREDICATION_OP.xml' path='doc/member[@name="D3D12_PREDICATION_OP.D3D12_PREDICATION_OP_NOT_EQUAL_ZERO"]/*' />
    D3D12_PREDICATION_OP_NOT_EQUAL_ZERO = 1,
}
