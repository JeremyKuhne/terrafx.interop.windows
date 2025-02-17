// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using static TerraFX.Interop.DirectX.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS"]/*' />
[Flags]
public enum D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS
{
    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_NONE"]/*' />
    D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_NONE = 0,

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_Y"]/*' />
    D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_Y = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_Y),

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_U"]/*' />
    D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_U = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_U),

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_V"]/*' />
    D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_V = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_V),

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_R"]/*' />
    D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_R = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_R),

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_G"]/*' />
    D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_G = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_G),

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_B"]/*' />
    D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_B = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_B),

    /// <include file='D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAGS.D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_A"]/*' />
    D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_FLAG_A = (1 << D3D12_VIDEO_DECODE_HISTOGRAM_COMPONENT_A),
}
