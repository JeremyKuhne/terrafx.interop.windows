// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_INPUT_CLASSIFICATION.xml' path='doc/member[@name="D3D12_INPUT_CLASSIFICATION"]/*' />
public enum D3D12_INPUT_CLASSIFICATION
{
    /// <include file='D3D12_INPUT_CLASSIFICATION.xml' path='doc/member[@name="D3D12_INPUT_CLASSIFICATION.D3D12_INPUT_CLASSIFICATION_PER_VERTEX_DATA"]/*' />
    D3D12_INPUT_CLASSIFICATION_PER_VERTEX_DATA = 0,

    /// <include file='D3D12_INPUT_CLASSIFICATION.xml' path='doc/member[@name="D3D12_INPUT_CLASSIFICATION.D3D12_INPUT_CLASSIFICATION_PER_INSTANCE_DATA"]/*' />
    D3D12_INPUT_CLASSIFICATION_PER_INSTANCE_DATA = 1,
}
