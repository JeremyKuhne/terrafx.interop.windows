// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct IMAGEHLP_SYMBOL_SRC
    {
        [NativeTypeName("DWORD")]
        public uint sizeofstruct;

        [NativeTypeName("DWORD")]
        public uint type;

        [NativeTypeName("char [260]")]
        public fixed sbyte file[260];
    }
}
