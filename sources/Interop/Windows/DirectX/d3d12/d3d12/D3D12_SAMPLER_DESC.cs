// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC"]/*' />
public unsafe partial struct D3D12_SAMPLER_DESC
{
    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.Filter"]/*' />
    public D3D12_FILTER Filter;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.AddressU"]/*' />
    public D3D12_TEXTURE_ADDRESS_MODE AddressU;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.AddressV"]/*' />
    public D3D12_TEXTURE_ADDRESS_MODE AddressV;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.AddressW"]/*' />
    public D3D12_TEXTURE_ADDRESS_MODE AddressW;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.MipLODBias"]/*' />
    public float MipLODBias;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.MaxAnisotropy"]/*' />
    public uint MaxAnisotropy;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.ComparisonFunc"]/*' />
    public D3D12_COMPARISON_FUNC ComparisonFunc;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.BorderColor"]/*' />
    [NativeTypeName("FLOAT[4]")]
    public fixed float BorderColor[4];

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.MinLOD"]/*' />
    public float MinLOD;

    /// <include file='D3D12_SAMPLER_DESC.xml' path='doc/member[@name="D3D12_SAMPLER_DESC.MaxLOD"]/*' />
    public float MaxLOD;
}
