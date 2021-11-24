// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct BANDINFOSFB
{
    [NativeTypeName("DWORD")]
    public uint dwMask;

    [NativeTypeName("DWORD")]
    public uint dwStateMask;

    [NativeTypeName("DWORD")]
    public uint dwState;

    public COLORREF crBkgnd;

    public COLORREF crBtnLt;

    public COLORREF crBtnDk;

    [NativeTypeName("WORD")]
    public ushort wViewMode;

    [NativeTypeName("WORD")]
    public ushort wAlign;

    public IShellFolder* psf;

    [NativeTypeName("LPITEMIDLIST")]
    public ITEMIDLIST* pidl;
}
