// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_SIZE_RANGE.xml' path='doc/member[@name="D3D12_VIDEO_SIZE_RANGE"]/*' />
public partial struct D3D12_VIDEO_SIZE_RANGE
{
    /// <include file='D3D12_VIDEO_SIZE_RANGE.xml' path='doc/member[@name="D3D12_VIDEO_SIZE_RANGE.MaxWidth"]/*' />
    public uint MaxWidth;

    /// <include file='D3D12_VIDEO_SIZE_RANGE.xml' path='doc/member[@name="D3D12_VIDEO_SIZE_RANGE.MaxHeight"]/*' />
    public uint MaxHeight;

    /// <include file='D3D12_VIDEO_SIZE_RANGE.xml' path='doc/member[@name="D3D12_VIDEO_SIZE_RANGE.MinWidth"]/*' />
    public uint MinWidth;

    /// <include file='D3D12_VIDEO_SIZE_RANGE.xml' path='doc/member[@name="D3D12_VIDEO_SIZE_RANGE.MinHeight"]/*' />
    public uint MinHeight;
}
