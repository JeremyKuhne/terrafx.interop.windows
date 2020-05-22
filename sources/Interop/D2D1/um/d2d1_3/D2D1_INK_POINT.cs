// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_INK_POINT
    {
        [NativeTypeName("FLOAT")]
        public float x;

        [NativeTypeName("FLOAT")]
        public float y;

        [NativeTypeName("FLOAT")]
        public float radius;
    }
}
