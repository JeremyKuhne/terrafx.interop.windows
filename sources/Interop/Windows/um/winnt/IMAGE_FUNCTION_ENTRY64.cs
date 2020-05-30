// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct IMAGE_FUNCTION_ENTRY64
    {
        [NativeTypeName("ULONGLONG")]
        public ulong StartingAddress;

        [NativeTypeName("ULONGLONG")]
        public ulong EndingAddress;

        [NativeTypeName("_IMAGE_FUNCTION_ENTRY64::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:19009:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit, Pack = 4)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong EndOfPrologue;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong UnwindInfoAddress;
        }
    }
}
