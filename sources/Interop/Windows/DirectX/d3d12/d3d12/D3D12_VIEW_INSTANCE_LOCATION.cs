// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIEW_INSTANCE_LOCATION.xml' path='doc/member[@name="D3D12_VIEW_INSTANCE_LOCATION"]/*' />
public partial struct D3D12_VIEW_INSTANCE_LOCATION
{
    /// <include file='D3D12_VIEW_INSTANCE_LOCATION.xml' path='doc/member[@name="D3D12_VIEW_INSTANCE_LOCATION.ViewportArrayIndex"]/*' />
    public uint ViewportArrayIndex;

    /// <include file='D3D12_VIEW_INSTANCE_LOCATION.xml' path='doc/member[@name="D3D12_VIEW_INSTANCE_LOCATION.RenderTargetArrayIndex"]/*' />
    public uint RenderTargetArrayIndex;
}
