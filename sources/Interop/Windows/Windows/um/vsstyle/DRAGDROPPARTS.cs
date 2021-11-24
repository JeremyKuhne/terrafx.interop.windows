// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum DRAGDROPPARTS
{
    DD_COPY = 1,
    DD_MOVE = 2,
    DD_UPDATEMETADATA = 3,
    DD_CREATELINK = 4,
    DD_WARNING = 5,
    DD_NONE = 6,
    DD_IMAGEBG = 7,
    DD_TEXTBG = 8,
}
