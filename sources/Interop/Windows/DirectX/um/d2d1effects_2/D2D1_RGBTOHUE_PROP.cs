// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_RGBTOHUE_PROP.xml' path='doc/member[@name="D2D1_RGBTOHUE_PROP"]/*' />
public enum D2D1_RGBTOHUE_PROP : uint
{
    /// <include file='D2D1_RGBTOHUE_PROP.xml' path='doc/member[@name="D2D1_RGBTOHUE_PROP.D2D1_RGBTOHUE_PROP_OUTPUT_COLOR_SPACE"]/*' />
    D2D1_RGBTOHUE_PROP_OUTPUT_COLOR_SPACE = 0,

    /// <include file='D2D1_RGBTOHUE_PROP.xml' path='doc/member[@name="D2D1_RGBTOHUE_PROP.D2D1_RGBTOHUE_PROP_FORCE_DWORD"]/*' />
    D2D1_RGBTOHUE_PROP_FORCE_DWORD = 0xffffffff,
}
