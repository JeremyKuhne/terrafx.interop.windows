// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT.Codec"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC Codec;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT.Profile"]/*' />
    public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_INPUT_FORMAT.IsSupported"]/*' />
    public BOOL IsSupported;
}
