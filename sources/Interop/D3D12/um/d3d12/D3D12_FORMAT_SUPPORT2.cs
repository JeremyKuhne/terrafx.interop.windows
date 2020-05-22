// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    [Flags]
    public enum D3D12_FORMAT_SUPPORT2
    {
        D3D12_FORMAT_SUPPORT2_NONE = 0,
        D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_ADD = 0x1,
        D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_BITWISE_OPS = 0x2,
        D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_COMPARE_STORE_OR_COMPARE_EXCHANGE = 0x4,
        D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_EXCHANGE = 0x8,
        D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_SIGNED_MIN_OR_MAX = 0x10,
        D3D12_FORMAT_SUPPORT2_UAV_ATOMIC_UNSIGNED_MIN_OR_MAX = 0x20,
        D3D12_FORMAT_SUPPORT2_UAV_TYPED_LOAD = 0x40,
        D3D12_FORMAT_SUPPORT2_UAV_TYPED_STORE = 0x80,
        D3D12_FORMAT_SUPPORT2_OUTPUT_MERGER_LOGIC_OP = 0x100,
        D3D12_FORMAT_SUPPORT2_TILED = 0x200,
        D3D12_FORMAT_SUPPORT2_MULTIPLANE_OVERLAY = 0x4000,
    }
}
