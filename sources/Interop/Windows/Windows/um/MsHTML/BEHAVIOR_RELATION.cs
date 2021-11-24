// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum BEHAVIOR_RELATION
{
    BEHAVIOR_FIRSTRELATION = 0,
    BEHAVIOR_SAMEELEMENT = 0,
    BEHAVIOR_PARENT = 1,
    BEHAVIOR_CHILD = 2,
    BEHAVIOR_SIBLING = 3,
    BEHAVIOR_LASTRELATION = 3,
    BEHAVIOR_RELATION_Max = 2147483647,
}
