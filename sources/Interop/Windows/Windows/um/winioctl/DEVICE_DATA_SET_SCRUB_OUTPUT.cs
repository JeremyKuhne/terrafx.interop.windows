// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct DEVICE_DATA_SET_SCRUB_OUTPUT
{
    [NativeTypeName("DWORDLONG")]
    public ulong BytesProcessed;

    [NativeTypeName("DWORDLONG")]
    public ulong BytesRepaired;

    [NativeTypeName("DWORDLONG")]
    public ulong BytesFailed;
}
