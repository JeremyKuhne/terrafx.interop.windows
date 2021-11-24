// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct DRIVER_VER_MAJORMINOR
{
    [NativeTypeName("DWORD")]
    public uint dwMajor;

    [NativeTypeName("DWORD")]
    public uint dwMinor;
}
