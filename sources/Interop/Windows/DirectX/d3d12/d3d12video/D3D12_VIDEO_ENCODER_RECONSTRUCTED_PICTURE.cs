// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE"]/*' />
public unsafe partial struct D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE
{
    /// <include file='D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE.pReconstructedPicture"]/*' />
    public ID3D12Resource* pReconstructedPicture;

    /// <include file='D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE.xml' path='doc/member[@name="D3D12_VIDEO_ENCODER_RECONSTRUCTED_PICTURE.ReconstructedPictureSubresource"]/*' />
    public uint ReconstructedPictureSubresource;
}
