// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC"]/*' />
public partial struct D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC
{
    /// <include file='D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC.Level"]/*' />
    public D3D12_VIDEO_ENCODER_LEVELS_HEVC Level;

    /// <include file='D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_LEVEL_TIER_CONSTRAINTS_HEVC.Tier"]/*' />
    public D3D12_VIDEO_ENCODER_TIER_HEVC Tier;
}
