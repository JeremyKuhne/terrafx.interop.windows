// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct JOBOBJECT_IO_ATTRIBUTION_STATS
{
    [NativeTypeName("ULONG_PTR")]
    public nuint IoCount;

    [NativeTypeName("ULONGLONG")]
    public ulong TotalNonOverlappedQueueTime;

    [NativeTypeName("ULONGLONG")]
    public ulong TotalNonOverlappedServiceTime;

    [NativeTypeName("ULONGLONG")]
    public ulong TotalSize;
}
