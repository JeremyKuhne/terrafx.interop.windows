// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM"]/*' />
public unsafe partial struct D3D12_VIDEO_PROCESS_OUTPUT_STREAM
{
    /// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM.pTexture2D"]/*' />
    public ID3D12Resource* pTexture2D;

    /// <include file='D3D12_VIDEO_PROCESS_OUTPUT_STREAM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_OUTPUT_STREAM.Subresource"]/*' />
    public uint Subresource;
}
