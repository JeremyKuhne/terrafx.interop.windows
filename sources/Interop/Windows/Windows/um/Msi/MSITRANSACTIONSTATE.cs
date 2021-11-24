// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum MSITRANSACTIONSTATE
{
    MSITRANSACTIONSTATE_ROLLBACK = 0x00000000,
    MSITRANSACTIONSTATE_COMMIT = 0x00000001,
}
