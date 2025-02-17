// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SHFILEOPSTRUCT32A
{
    public HWND hwnd;

    public uint wFunc;

    [NativeTypeName("PCZZSTR")]
    public sbyte* pFrom;

    [NativeTypeName("PCZZSTR")]
    public sbyte* pTo;

    [NativeTypeName("FILEOP_FLAGS")]
    public ushort fFlags;

    public BOOL fAnyOperationsAborted;

    [NativeTypeName("LPVOID")]
    public void* hNameMappings;

    [NativeTypeName("PCSTR")]
    public sbyte* lpszProgressTitle;
}
