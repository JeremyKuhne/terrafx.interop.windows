// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_ELEMENTS_LAYOUT.xml' path='doc/member[@name="D3D12_ELEMENTS_LAYOUT"]/*' />
public enum D3D12_ELEMENTS_LAYOUT
{
    /// <include file='D3D12_ELEMENTS_LAYOUT.xml' path='doc/member[@name="D3D12_ELEMENTS_LAYOUT.D3D12_ELEMENTS_LAYOUT_ARRAY"]/*' />
    D3D12_ELEMENTS_LAYOUT_ARRAY = 0,

    /// <include file='D3D12_ELEMENTS_LAYOUT.xml' path='doc/member[@name="D3D12_ELEMENTS_LAYOUT.D3D12_ELEMENTS_LAYOUT_ARRAY_OF_POINTERS"]/*' />
    D3D12_ELEMENTS_LAYOUT_ARRAY_OF_POINTERS = 0x1,
}
