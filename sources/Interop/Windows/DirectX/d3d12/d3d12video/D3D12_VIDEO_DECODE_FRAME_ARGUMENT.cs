// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_DECODE_FRAME_ARGUMENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_FRAME_ARGUMENT"]/*' />
public unsafe partial struct D3D12_VIDEO_DECODE_FRAME_ARGUMENT
{
    /// <include file='D3D12_VIDEO_DECODE_FRAME_ARGUMENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_FRAME_ARGUMENT.Type"]/*' />
    public D3D12_VIDEO_DECODE_ARGUMENT_TYPE Type;

    /// <include file='D3D12_VIDEO_DECODE_FRAME_ARGUMENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_FRAME_ARGUMENT.Size"]/*' />
    public uint Size;

    /// <include file='D3D12_VIDEO_DECODE_FRAME_ARGUMENT.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_FRAME_ARGUMENT.pData"]/*' />
    public void* pData;
}
