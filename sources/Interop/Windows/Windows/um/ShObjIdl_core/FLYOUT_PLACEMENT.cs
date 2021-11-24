// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum FLYOUT_PLACEMENT
{
    FP_DEFAULT = 0,
    FP_ABOVE = (FP_DEFAULT + 1),
    FP_BELOW = (FP_ABOVE + 1),
    FP_LEFT = (FP_BELOW + 1),
    FP_RIGHT = (FP_LEFT + 1),
}
