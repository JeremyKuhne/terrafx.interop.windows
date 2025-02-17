// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12sdklayers.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_MESSAGE.xml' path='doc/member[@name="D3D12_MESSAGE"]/*' />
public unsafe partial struct D3D12_MESSAGE
{
    /// <include file='D3D12_MESSAGE.xml' path='doc/member[@name="D3D12_MESSAGE.Category"]/*' />
    public D3D12_MESSAGE_CATEGORY Category;

    /// <include file='D3D12_MESSAGE.xml' path='doc/member[@name="D3D12_MESSAGE.Severity"]/*' />
    public D3D12_MESSAGE_SEVERITY Severity;

    /// <include file='D3D12_MESSAGE.xml' path='doc/member[@name="D3D12_MESSAGE.ID"]/*' />
    public D3D12_MESSAGE_ID ID;

    /// <include file='D3D12_MESSAGE.xml' path='doc/member[@name="D3D12_MESSAGE.pDescription"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* pDescription;

    /// <include file='D3D12_MESSAGE.xml' path='doc/member[@name="D3D12_MESSAGE.DescriptionByteLength"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint DescriptionByteLength;
}
