// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_META_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_STAGE"]/*' />
public enum D3D12_META_COMMAND_PARAMETER_STAGE
{
    /// <include file='D3D12_META_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_STAGE.D3D12_META_COMMAND_PARAMETER_STAGE_CREATION"]/*' />
    D3D12_META_COMMAND_PARAMETER_STAGE_CREATION = 0,

    /// <include file='D3D12_META_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_STAGE.D3D12_META_COMMAND_PARAMETER_STAGE_INITIALIZATION"]/*' />
    D3D12_META_COMMAND_PARAMETER_STAGE_INITIALIZATION = 1,

    /// <include file='D3D12_META_COMMAND_PARAMETER_STAGE.xml' path='doc/member[@name="D3D12_META_COMMAND_PARAMETER_STAGE.D3D12_META_COMMAND_PARAMETER_STAGE_EXECUTION"]/*' />
    D3D12_META_COMMAND_PARAMETER_STAGE_EXECUTION = 2,
}
