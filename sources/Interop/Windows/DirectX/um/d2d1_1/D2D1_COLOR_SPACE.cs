// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_COLOR_SPACE.xml' path='doc/member[@name="D2D1_COLOR_SPACE"]/*' />
public enum D2D1_COLOR_SPACE : uint
{
    /// <include file='D2D1_COLOR_SPACE.xml' path='doc/member[@name="D2D1_COLOR_SPACE.D2D1_COLOR_SPACE_CUSTOM"]/*' />
    D2D1_COLOR_SPACE_CUSTOM = 0,

    /// <include file='D2D1_COLOR_SPACE.xml' path='doc/member[@name="D2D1_COLOR_SPACE.D2D1_COLOR_SPACE_SRGB"]/*' />
    D2D1_COLOR_SPACE_SRGB = 1,

    /// <include file='D2D1_COLOR_SPACE.xml' path='doc/member[@name="D2D1_COLOR_SPACE.D2D1_COLOR_SPACE_SCRGB"]/*' />
    D2D1_COLOR_SPACE_SCRGB = 2,

    /// <include file='D2D1_COLOR_SPACE.xml' path='doc/member[@name="D2D1_COLOR_SPACE.D2D1_COLOR_SPACE_FORCE_DWORD"]/*' />
    D2D1_COLOR_SPACE_FORCE_DWORD = 0xffffffff,
}
