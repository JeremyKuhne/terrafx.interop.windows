// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct OPENASINFO
{
    [NativeTypeName("LPCWSTR")]
    public ushort* pcszFile;

    [NativeTypeName("LPCWSTR")]
    public ushort* pcszClass;

    [NativeTypeName("OPEN_AS_INFO_FLAGS")]
    public int oaifInFlags;
}
