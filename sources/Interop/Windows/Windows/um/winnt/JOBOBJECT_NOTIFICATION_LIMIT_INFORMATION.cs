// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
public partial struct JOBOBJECT_NOTIFICATION_LIMIT_INFORMATION
{
    [NativeTypeName("DWORD64")]
    public ulong IoReadBytesLimit;

    [NativeTypeName("DWORD64")]
    public ulong IoWriteBytesLimit;

    public LARGE_INTEGER PerJobUserTimeLimit;

    [NativeTypeName("DWORD64")]
    public ulong JobMemoryLimit;

    public JOBOBJECT_RATE_CONTROL_TOLERANCE RateControlTolerance;

    public JOBOBJECT_RATE_CONTROL_TOLERANCE_INTERVAL RateControlToleranceInterval;

    [NativeTypeName("DWORD")]
    public uint LimitFlags;
}
