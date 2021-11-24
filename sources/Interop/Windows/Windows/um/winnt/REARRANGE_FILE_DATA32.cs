// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct REARRANGE_FILE_DATA32
{
    [NativeTypeName("ULONGLONG")]
    public ulong SourceStartingOffset;

    [NativeTypeName("ULONGLONG")]
    public ulong TargetOffset;

    [NativeTypeName("UINT32")]
    public uint SourceFileHandle;

    [NativeTypeName("DWORD")]
    public uint Length;

    [NativeTypeName("DWORD")]
    public uint Flags;
}
