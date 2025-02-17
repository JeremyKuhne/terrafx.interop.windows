// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FORMAT_SUPPORT"]/*' />
public partial struct D3D12_FEATURE_DATA_FORMAT_SUPPORT
{
    /// <include file='D3D12_FEATURE_DATA_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FORMAT_SUPPORT.Format"]/*' />
    public DXGI_FORMAT Format;

    /// <include file='D3D12_FEATURE_DATA_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FORMAT_SUPPORT.Support1"]/*' />
    public D3D12_FORMAT_SUPPORT1 Support1;

    /// <include file='D3D12_FEATURE_DATA_FORMAT_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_FORMAT_SUPPORT.Support2"]/*' />
    public D3D12_FORMAT_SUPPORT2 Support2;
}
