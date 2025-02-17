// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SHFILEINFOA
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SHFILEINFO32A));
            }
            else
            {
                return (uint)(sizeof(SHFILEINFO64A));
            }
        }
    }

    [FieldOffset(0)]
    public SHFILEINFO32A _value32;

    [FieldOffset(0)]
    public SHFILEINFO64A _value64;

    [UnscopedRef]
    public ref HICON hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.hIcon;
            }
            else
            {
                return ref _value64.hIcon;
            }
        }
    }

    [UnscopedRef]
    public ref int iIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.iIcon;
            }
            else
            {
                return ref _value64.iIcon;
            }
        }
    }

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint dwAttributes
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.dwAttributes;
            }
            else
            {
                return ref _value64.dwAttributes;
            }
        }
    }

    [NativeTypeName("CHAR [260]")]
    [UnscopedRef]
    public Span<sbyte> szDisplayName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.szDisplayName[0], 260);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.szDisplayName[0], 260);
            }
        }
    }

    [NativeTypeName("CHAR [80]")]
    [UnscopedRef]
    public Span<sbyte> szTypeName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.szTypeName[0], 80);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.szTypeName[0], 80);
            }
        }
    }
}
