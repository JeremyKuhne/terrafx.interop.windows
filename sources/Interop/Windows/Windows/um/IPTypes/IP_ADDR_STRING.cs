// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct IP_ADDR_STRING
{
    [NativeTypeName("struct _IP_ADDR_STRING *")]
    public IP_ADDR_STRING* Next;

    [NativeTypeName("IP_ADDRESS_STRING")]
    public IP_MASK_STRING IpAddress;

    public IP_MASK_STRING IpMask;

    [NativeTypeName("DWORD")]
    public uint Context;
}
