// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT.xml' path='doc/member[@name="D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT
{
    /// <include file='D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT.xml' path='doc/member[@name="D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT.pMotionVectorHeap"]/*' />
    public ID3D12VideoMotionVectorHeap* pMotionVectorHeap;

    /// <include file='D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT.xml' path='doc/member[@name="D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT.PixelWidth"]/*' />
    public uint PixelWidth;

    /// <include file='D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT.xml' path='doc/member[@name="D3D12_RESOLVE_VIDEO_MOTION_VECTOR_HEAP_INPUT.PixelHeight"]/*' />
    public uint PixelHeight;
}
