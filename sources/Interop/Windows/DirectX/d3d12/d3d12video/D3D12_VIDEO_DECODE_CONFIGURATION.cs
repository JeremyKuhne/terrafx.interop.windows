// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_DECODE_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONFIGURATION"]/*' />
public partial struct D3D12_VIDEO_DECODE_CONFIGURATION
{
    /// <include file='D3D12_VIDEO_DECODE_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONFIGURATION.DecodeProfile"]/*' />
    public Guid DecodeProfile;

    /// <include file='D3D12_VIDEO_DECODE_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONFIGURATION.BitstreamEncryption"]/*' />
    public D3D12_BITSTREAM_ENCRYPTION_TYPE BitstreamEncryption;

    /// <include file='D3D12_VIDEO_DECODE_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_CONFIGURATION.InterlaceType"]/*' />
    public D3D12_VIDEO_FRAME_CODED_INTERLACE_TYPE InterlaceType;
}
