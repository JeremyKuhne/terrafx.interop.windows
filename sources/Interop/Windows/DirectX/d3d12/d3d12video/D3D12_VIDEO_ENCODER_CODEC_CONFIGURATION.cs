// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION
{
    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION.DataSize"]/*' />
    public uint DataSize;

    /// <include file='D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION.Anonymous"]/*' />
    [NativeTypeName("D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION::(anonymous union at ./d3d12video.h:6716:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264Config"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264* pH264Config
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pH264Config;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCConfig"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC* pHEVCConfig
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pHEVCConfig;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264Config"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_H264* pH264Config;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCConfig"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_CODEC_CONFIGURATION_HEVC* pHEVCConfig;
    }
}
