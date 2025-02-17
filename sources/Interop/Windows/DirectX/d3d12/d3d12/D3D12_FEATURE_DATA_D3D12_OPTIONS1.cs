// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS1"]/*' />
public partial struct D3D12_FEATURE_DATA_D3D12_OPTIONS1
{
    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS1.WaveOps"]/*' />
    public BOOL WaveOps;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS1.WaveLaneCountMin"]/*' />
    public uint WaveLaneCountMin;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS1.WaveLaneCountMax"]/*' />
    public uint WaveLaneCountMax;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS1.TotalLaneCount"]/*' />
    public uint TotalLaneCount;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS1.ExpandedComputeResourceStates"]/*' />
    public BOOL ExpandedComputeResourceStates;

    /// <include file='D3D12_FEATURE_DATA_D3D12_OPTIONS1.xml' path='doc/member[@name="D3D12_FEATURE_DATA_D3D12_OPTIONS1.Int64ShaderOps"]/*' />
    public BOOL Int64ShaderOps;
}
