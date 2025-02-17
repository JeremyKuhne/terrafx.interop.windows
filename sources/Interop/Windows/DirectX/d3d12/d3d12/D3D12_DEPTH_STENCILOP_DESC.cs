// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DEPTH_STENCILOP_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCILOP_DESC"]/*' />
public partial struct D3D12_DEPTH_STENCILOP_DESC
{
    /// <include file='D3D12_DEPTH_STENCILOP_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCILOP_DESC.StencilFailOp"]/*' />
    public D3D12_STENCIL_OP StencilFailOp;

    /// <include file='D3D12_DEPTH_STENCILOP_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCILOP_DESC.StencilDepthFailOp"]/*' />
    public D3D12_STENCIL_OP StencilDepthFailOp;

    /// <include file='D3D12_DEPTH_STENCILOP_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCILOP_DESC.StencilPassOp"]/*' />
    public D3D12_STENCIL_OP StencilPassOp;

    /// <include file='D3D12_DEPTH_STENCILOP_DESC.xml' path='doc/member[@name="D3D12_DEPTH_STENCILOP_DESC.StencilFunc"]/*' />
    public D3D12_COMPARISON_FUNC StencilFunc;
}
