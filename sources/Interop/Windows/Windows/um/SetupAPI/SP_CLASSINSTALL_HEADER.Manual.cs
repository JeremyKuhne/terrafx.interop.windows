// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_CLASSINSTALL_HEADER
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_CLASSINSTALL_HEADER32));
            }
            else
            {
                return (uint)(sizeof(SP_CLASSINSTALL_HEADER64));
            }
        }
    }

    [FieldOffset(0)]
    public SP_CLASSINSTALL_HEADER32 _value32;

    [FieldOffset(0)]
    public SP_CLASSINSTALL_HEADER64 _value64;

    [NativeTypeName("DWORD")]
    [UnscopedRef]
    public ref uint cbSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.cbSize;
            }
            else
            {
                return ref _value64.cbSize;
            }
        }
    }

    [NativeTypeName("DI_FUNCTION")]
    [UnscopedRef]
    public ref uint InstallFunction
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref _value32.InstallFunction;
            }
            else
            {
                return ref _value64.InstallFunction;
            }
        }
    }
}
