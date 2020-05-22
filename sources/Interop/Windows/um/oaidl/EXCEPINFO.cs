// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct EXCEPINFO
    {
        [NativeTypeName("WORD")]
        public ushort wCode;

        [NativeTypeName("WORD")]
        public ushort wReserved;

        [NativeTypeName("BSTR")]
        public ushort* bstrSource;

        [NativeTypeName("BSTR")]
        public ushort* bstrDescription;

        [NativeTypeName("BSTR")]
        public ushort* bstrHelpFile;

        [NativeTypeName("DWORD")]
        public uint dwHelpContext;

        [NativeTypeName("PVOID")]
        public void* pvReserved;

        [NativeTypeName("pfnDeferredFillIn")]
        public IntPtr pfnDeferredFillIn;

        [NativeTypeName("SCODE")]
        public int scode;
    }
}
