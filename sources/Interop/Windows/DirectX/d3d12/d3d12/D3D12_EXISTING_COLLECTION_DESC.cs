// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_EXISTING_COLLECTION_DESC.xml' path='doc/member[@name="D3D12_EXISTING_COLLECTION_DESC"]/*' />
public unsafe partial struct D3D12_EXISTING_COLLECTION_DESC
{
    /// <include file='D3D12_EXISTING_COLLECTION_DESC.xml' path='doc/member[@name="D3D12_EXISTING_COLLECTION_DESC.pExistingCollection"]/*' />
    public ID3D12StateObject* pExistingCollection;

    /// <include file='D3D12_EXISTING_COLLECTION_DESC.xml' path='doc/member[@name="D3D12_EXISTING_COLLECTION_DESC.NumExports"]/*' />
    public uint NumExports;

    /// <include file='D3D12_EXISTING_COLLECTION_DESC.xml' path='doc/member[@name="D3D12_EXISTING_COLLECTION_DESC.pExports"]/*' />
    public D3D12_EXPORT_DESC* pExports;
}
