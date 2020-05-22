// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum D2D1_TEMPERATUREANDTINT_PROP : uint
    {
        D2D1_TEMPERATUREANDTINT_PROP_TEMPERATURE = 0,
        D2D1_TEMPERATUREANDTINT_PROP_TINT = 1,
        D2D1_TEMPERATUREANDTINT_PROP_FORCE_DWORD = 0xffffffff,
    }
}
