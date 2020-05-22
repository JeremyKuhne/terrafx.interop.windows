// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PROPBAG2
    {
        [NativeTypeName("DWORD")]
        public uint dwType;

        [NativeTypeName("VARTYPE")]
        public ushort vt;

        [NativeTypeName("CLIPFORMAT")]
        public ushort cfType;

        [NativeTypeName("DWORD")]
        public uint dwHint;

        [NativeTypeName("LPOLESTR")]
        public ushort* pstrName;

        [NativeTypeName("CLSID")]
        public Guid clsid;
    }
}
