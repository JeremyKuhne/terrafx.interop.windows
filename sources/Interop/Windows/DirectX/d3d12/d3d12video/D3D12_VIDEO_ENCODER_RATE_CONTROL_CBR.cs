// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR"]/*' />
public partial struct D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR
{
    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.InitialQP"]/*' />
    public uint InitialQP;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.MinQP"]/*' />
    public uint MinQP;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.MaxQP"]/*' />
    public uint MaxQP;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.MaxFrameBitSize"]/*' />
    [NativeTypeName("UINT64")]
    public ulong MaxFrameBitSize;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.TargetBitRate"]/*' />
    [NativeTypeName("UINT64")]
    public ulong TargetBitRate;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.VBVCapacity"]/*' />
    [NativeTypeName("UINT64")]
    public ulong VBVCapacity;

    /// <include file='D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RATE_CONTROL_CBR.InitialVBVFullness"]/*' />
    [NativeTypeName("UINT64")]
    public ulong InitialVBVFullness;
}
