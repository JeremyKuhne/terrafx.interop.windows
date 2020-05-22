// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D2D_MATRIX_4X3_F
    {
        [NativeTypeName("D2D_MATRIX_4X3_F::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/dcommon.h:331:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("D2D_MATRIX_4X3_F::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/dcommon.h:333:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT [4][3]")]
            public fixed float m[4 * 3];

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("FLOAT")]
                public float _11;

                [NativeTypeName("FLOAT")]
                public float _12;

                [NativeTypeName("FLOAT")]
                public float _13;

                [NativeTypeName("FLOAT")]
                public float _21;

                [NativeTypeName("FLOAT")]
                public float _22;

                [NativeTypeName("FLOAT")]
                public float _23;

                [NativeTypeName("FLOAT")]
                public float _31;

                [NativeTypeName("FLOAT")]
                public float _32;

                [NativeTypeName("FLOAT")]
                public float _33;

                [NativeTypeName("FLOAT")]
                public float _41;

                [NativeTypeName("FLOAT")]
                public float _42;

                [NativeTypeName("FLOAT")]
                public float _43;
            }
        }
    }
}
