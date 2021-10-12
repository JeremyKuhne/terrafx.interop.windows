// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CRYPT_VERIFY_MESSAGE_PARA
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwMsgAndCertEncodingType;

        [NativeTypeName("HCRYPTPROV_LEGACY")]
        public IntPtr hCryptProv;

        [NativeTypeName("PFN_CRYPT_GET_SIGNER_CERTIFICATE")]
        public delegate* unmanaged<void*, uint, CERT_INFO*, IntPtr, CERT_CONTEXT*> pfnGetSignerCertificate;

        public void* pvGetArg;
    }
}
