// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_COMMAND_QUEUE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_DESC"]/*' />
public partial struct D3D12_COMMAND_QUEUE_DESC
{
    /// <include file='D3D12_COMMAND_QUEUE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_DESC.Type"]/*' />
    public D3D12_COMMAND_LIST_TYPE Type;

    /// <include file='D3D12_COMMAND_QUEUE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_DESC.Priority"]/*' />
    public int Priority;

    /// <include file='D3D12_COMMAND_QUEUE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_DESC.Flags"]/*' />
    public D3D12_COMMAND_QUEUE_FLAGS Flags;

    /// <include file='D3D12_COMMAND_QUEUE_DESC.xml' path='doc/member[@name="D3D12_COMMAND_QUEUE_DESC.NodeMask"]/*' />
    public uint NodeMask;
}
