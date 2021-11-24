// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum FINDTEXT_FLAGS
{
    FINDTEXT_BACKWARDS = 0x1,
    FINDTEXT_WHOLEWORD = 0x2,
    FINDTEXT_MATCHCASE = 0x4,
    FINDTEXT_RAW = 0x20000,
    FINDTEXT_MATCHREPEATEDWHITESPACE = 0x40000,
    FINDTEXT_MATCHDIAC = 0x20000000,
    FINDTEXT_MATCHKASHIDA = 0x40000000,
    FINDTEXT_MATCHALEFHAMZA = unchecked((int)(0x80000000)),
    FINDTEXT_FLAGS_Max = 2147483647,
}
