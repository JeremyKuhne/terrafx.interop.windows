// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreAdapterMemoryBudgetNodeSegmentGroup.xml' path='doc/member[@name="DXCoreAdapterMemoryBudgetNodeSegmentGroup"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct DXCoreAdapterMemoryBudgetNodeSegmentGroup
{
    /// <include file='DXCoreAdapterMemoryBudgetNodeSegmentGroup.xml' path='doc/member[@name="DXCoreAdapterMemoryBudgetNodeSegmentGroup.nodeIndex"]/*' />
    [NativeTypeName("uint32_t")]
    public uint nodeIndex;

    /// <include file='DXCoreAdapterMemoryBudgetNodeSegmentGroup.xml' path='doc/member[@name="DXCoreAdapterMemoryBudgetNodeSegmentGroup.segmentGroup"]/*' />
    public DXCoreSegmentGroup segmentGroup;
}
