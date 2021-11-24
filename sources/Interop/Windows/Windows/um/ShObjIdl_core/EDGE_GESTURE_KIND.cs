// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum EDGE_GESTURE_KIND
{
    EGK_TOUCH = 0,
    EGK_KEYBOARD = (EGK_TOUCH + 1),
    EGK_MOUSE = (EGK_KEYBOARD + 1),
}
