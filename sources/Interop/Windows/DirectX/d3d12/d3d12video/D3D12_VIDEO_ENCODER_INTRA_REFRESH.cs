// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_INTRA_REFRESH.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INTRA_REFRESH"]/*' />
public partial struct D3D12_VIDEO_ENCODER_INTRA_REFRESH
{
    /// <include file='D3D12_VIDEO_ENCODER_INTRA_REFRESH.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INTRA_REFRESH.Mode"]/*' />
    public D3D12_VIDEO_ENCODER_INTRA_REFRESH_MODE Mode;

    /// <include file='D3D12_VIDEO_ENCODER_INTRA_REFRESH.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_INTRA_REFRESH.IntraRefreshDuration"]/*' />
    public uint IntraRefreshDuration;
}
