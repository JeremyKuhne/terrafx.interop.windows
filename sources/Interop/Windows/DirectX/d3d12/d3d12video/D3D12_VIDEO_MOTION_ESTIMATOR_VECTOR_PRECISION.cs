// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public enum D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION
{
    /// <include file='D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION.xml' path='doc/member[@name="D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION.D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_QUARTER_PEL"]/*' />
    D3D12_VIDEO_MOTION_ESTIMATOR_VECTOR_PRECISION_QUARTER_PEL = 0,
}
