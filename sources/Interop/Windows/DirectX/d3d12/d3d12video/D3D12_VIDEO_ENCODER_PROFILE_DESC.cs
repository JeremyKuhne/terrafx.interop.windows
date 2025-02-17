// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_PROFILE_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_DESC"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_PROFILE_DESC
{
    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_DESC.DataSize"]/*' />
    public uint DataSize;

    /// <include file='D3D12_VIDEO_ENCODER_PROFILE_DESC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_PROFILE_DESC.Anonymous"]/*' />
    [NativeTypeName("D3D12_VIDEO_ENCODER_PROFILE_DESC::(anonymous union at ./d3d12video.h:6300:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264Profile"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_PROFILE_H264* pH264Profile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pH264Profile;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCProfile"]/*' />
    [UnscopedRef]
    public ref D3D12_VIDEO_ENCODER_PROFILE_HEVC* pHEVCProfile
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pHEVCProfile;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pH264Profile"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_PROFILE_H264* pH264Profile;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pHEVCProfile"]/*' />
        [FieldOffset(0)]
        public D3D12_VIDEO_ENCODER_PROFILE_HEVC* pHEVCProfile;
    }
}
