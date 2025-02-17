// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_ROOT_SIGNATURE_VERSION.xml' path='doc/member[@name="D3D_ROOT_SIGNATURE_VERSION"]/*' />
public enum D3D_ROOT_SIGNATURE_VERSION
{
    /// <include file='D3D_ROOT_SIGNATURE_VERSION.xml' path='doc/member[@name="D3D_ROOT_SIGNATURE_VERSION.D3D_ROOT_SIGNATURE_VERSION_1"]/*' />
    D3D_ROOT_SIGNATURE_VERSION_1 = 0x1,

    /// <include file='D3D_ROOT_SIGNATURE_VERSION.xml' path='doc/member[@name="D3D_ROOT_SIGNATURE_VERSION.D3D_ROOT_SIGNATURE_VERSION_1_0"]/*' />
    D3D_ROOT_SIGNATURE_VERSION_1_0 = 0x1,

    /// <include file='D3D_ROOT_SIGNATURE_VERSION.xml' path='doc/member[@name="D3D_ROOT_SIGNATURE_VERSION.D3D_ROOT_SIGNATURE_VERSION_1_1"]/*' />
    D3D_ROOT_SIGNATURE_VERSION_1_1 = 0x2,
}
