// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_TRANSFORM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_TRANSFORM"]/*' />
public partial struct D3D12_VIDEO_PROCESS_TRANSFORM
{
    /// <include file='D3D12_VIDEO_PROCESS_TRANSFORM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_TRANSFORM.SourceRectangle"]/*' />
    [NativeTypeName("D3D12_RECT")]
    public RECT SourceRectangle;

    /// <include file='D3D12_VIDEO_PROCESS_TRANSFORM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_TRANSFORM.DestinationRectangle"]/*' />
    [NativeTypeName("D3D12_RECT")]
    public RECT DestinationRectangle;

    /// <include file='D3D12_VIDEO_PROCESS_TRANSFORM.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_TRANSFORM.Orientation"]/*' />
    public D3D12_VIDEO_PROCESS_ORIENTATION Orientation;
}
