// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.DataSize"]/*' />
    public uint DataSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT.Anonymous"]/*' />
    [NativeTypeName("D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT::(anonymous union at ./d3d12video.h:6626:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264Support"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264* pH264Support
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pH264Support;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCSupport"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC* pHEVCSupport
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pHEVCSupport;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264Support"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_H264* pH264Support;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCSupport"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_CODEC_PICTURE_CONTROL_SUPPORT_HEVC* pHEVCSupport;
    }
}
