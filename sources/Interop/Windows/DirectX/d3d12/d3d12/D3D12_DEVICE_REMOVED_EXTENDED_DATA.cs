// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA"]/*' />
public unsafe partial struct D3D12_DEVICE_REMOVED_EXTENDED_DATA
{
    /// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA.Flags"]/*' />
    public D3D12_DRED_FLAGS Flags;

    /// <include file='D3D12_DEVICE_REMOVED_EXTENDED_DATA.xml' path='doc/member[@name="D3D12_DEVICE_REMOVED_EXTENDED_DATA.pHeadAutoBreadcrumbNode"]/*' />
    public D3D12_AUTO_BREADCRUMB_NODE* pHeadAutoBreadcrumbNode;
}
