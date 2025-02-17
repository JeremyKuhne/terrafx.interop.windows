// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DRED_FLAGS.xml' path='doc/member[@name="D3D12_DRED_FLAGS"]/*' />
[Flags]
public enum D3D12_DRED_FLAGS
{
    /// <include file='D3D12_DRED_FLAGS.xml' path='doc/member[@name="D3D12_DRED_FLAGS.D3D12_DRED_FLAG_NONE"]/*' />
    D3D12_DRED_FLAG_NONE = 0,

    /// <include file='D3D12_DRED_FLAGS.xml' path='doc/member[@name="D3D12_DRED_FLAGS.D3D12_DRED_FLAG_FORCE_ENABLE"]/*' />
    D3D12_DRED_FLAG_FORCE_ENABLE = 1,

    /// <include file='D3D12_DRED_FLAGS.xml' path='doc/member[@name="D3D12_DRED_FLAGS.D3D12_DRED_FLAG_DISABLE_AUTOBREADCRUMBS"]/*' />
    D3D12_DRED_FLAG_DISABLE_AUTOBREADCRUMBS = 2,
}
