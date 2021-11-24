// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum MSITRANSACTION
{
    MSITRANSACTION_CHAIN_EMBEDDEDUI = 0x00000001,
    MSITRANSACTION_JOIN_EXISTING_EMBEDDEDUI = 0x00000002,
}
