// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM"]/*' />
public unsafe partial struct D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM
{
    /// <include file='D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM.Offset"]/*' />
    [NativeTypeName("UINT64")]
    public ulong Offset;

    /// <include file='D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_OUTPUT_HISTOGRAM.pBuffer"]/*' />
    public ID3D12Resource* pBuffer;
}
