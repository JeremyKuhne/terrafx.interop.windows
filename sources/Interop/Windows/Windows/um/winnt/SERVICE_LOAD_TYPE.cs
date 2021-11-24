// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum SERVICE_LOAD_TYPE
{
    BootLoad = 0x00000000,
    SystemLoad = 0x00000001,
    AutoLoad = 0x00000002,
    DemandLoad = 0x00000003,
    DisableLoad = 0x00000004,
}
