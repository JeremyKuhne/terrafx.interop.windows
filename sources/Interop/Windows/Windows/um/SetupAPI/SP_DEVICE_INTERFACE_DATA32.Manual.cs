// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SP_DEVICE_INTERFACE_DATA32
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    public Guid InterfaceClassGuid;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("ULONG_PTR")]
    public nuint Reserved;
}
