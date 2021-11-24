// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct EMRGDICOMMENT
{
    public EMR emr;

    [NativeTypeName("DWORD")]
    public uint cbData;

    [NativeTypeName("BYTE [1]")]
    public fixed byte Data[1];
}
