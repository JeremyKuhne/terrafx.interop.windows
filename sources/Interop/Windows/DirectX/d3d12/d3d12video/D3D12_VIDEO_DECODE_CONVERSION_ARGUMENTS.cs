// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS"]/*' />
public unsafe partial struct D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS
{
    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.Enable"]/*' />
    public BOOL Enable;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.pReferenceTexture2D"]/*' />
    public ID3D12Resource* pReferenceTexture2D;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.ReferenceSubresource"]/*' />
    public uint ReferenceSubresource;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.OutputColorSpace"]/*' />
    public DXGI_COLOR_SPACE_TYPE OutputColorSpace;

    /// <include file='D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS.DecodeColorSpace"]/*' />
    public DXGI_COLOR_SPACE_TYPE DecodeColorSpace;
}
