// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.DecodeProfile"]/*' />
    public Guid DecodeProfile;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.Width"]/*' />
    public uint Width;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.Height"]/*' />
    public uint Height;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.DecodeFormat"]/*' />
    public DXGI_FORMAT DecodeFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.Components"]/*' />
    public D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS Components;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.BinCount"]/*' />
    public uint BinCount;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_DECODE_HISTOGRAM.CounterBitDepth"]/*' />
    public uint CounterBitDepth;
}
