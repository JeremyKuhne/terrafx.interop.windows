// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum FILE_USAGE_TYPE
{
    FUT_PLAYING = 0,
    FUT_EDITING = (FUT_PLAYING + 1),
    FUT_GENERIC = (FUT_EDITING + 1),
}
