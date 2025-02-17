// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMPUTE_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_COMPUTE_PIPELINE_STATE_DESC"]/*' />
public unsafe partial struct D3D12_COMPUTE_PIPELINE_STATE_DESC
{
    /// <include file='D3D12_COMPUTE_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_COMPUTE_PIPELINE_STATE_DESC.pRootSignature"]/*' />
    public ID3D12RootSignature* pRootSignature;

    /// <include file='D3D12_COMPUTE_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_COMPUTE_PIPELINE_STATE_DESC.CS"]/*' />
    public D3D12_SHADER_BYTECODE CS;

    /// <include file='D3D12_COMPUTE_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_COMPUTE_PIPELINE_STATE_DESC.NodeMask"]/*' />
    public uint NodeMask;

    /// <include file='D3D12_COMPUTE_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_COMPUTE_PIPELINE_STATE_DESC.CachedPSO"]/*' />
    public D3D12_CACHED_PIPELINE_STATE CachedPSO;

    /// <include file='D3D12_COMPUTE_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3D12_COMPUTE_PIPELINE_STATE_DESC.Flags"]/*' />
    public D3D12_PIPELINE_STATE_FLAGS Flags;
}
