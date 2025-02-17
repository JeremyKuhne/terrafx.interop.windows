// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DRED_BREADCRUMB_CONTEXT.xml' path='doc/member[@name="D3D12_DRED_BREADCRUMB_CONTEXT"]/*' />
public unsafe partial struct D3D12_DRED_BREADCRUMB_CONTEXT
{
    /// <include file='D3D12_DRED_BREADCRUMB_CONTEXT.xml' path='doc/member[@name="D3D12_DRED_BREADCRUMB_CONTEXT.BreadcrumbIndex"]/*' />
    public uint BreadcrumbIndex;

    /// <include file='D3D12_DRED_BREADCRUMB_CONTEXT.xml' path='doc/member[@name="D3D12_DRED_BREADCRUMB_CONTEXT.pContextString"]/*' />
    [NativeTypeName("const wchar_t *")]
    public ushort* pContextString;
}
