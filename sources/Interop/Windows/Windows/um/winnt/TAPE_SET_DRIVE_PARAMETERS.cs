// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct TAPE_SET_DRIVE_PARAMETERS
{
    [NativeTypeName("BOOLEAN")]
    public byte ECC;

    [NativeTypeName("BOOLEAN")]
    public byte Compression;

    [NativeTypeName("BOOLEAN")]
    public byte DataPadding;

    [NativeTypeName("BOOLEAN")]
    public byte ReportSetmarks;

    [NativeTypeName("DWORD")]
    public uint EOTWarningZoneSize;
}
