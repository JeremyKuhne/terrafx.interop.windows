// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    [return: NativeTypeName("BOOL")]
    public unsafe delegate int PFN_CERT_STORE_PROV_READ_CTL([NativeTypeName("HCERTSTOREPROV")] void* hStoreProv, [NativeTypeName("PCCTL_CONTEXT")] CTL_CONTEXT* pStoreCtlContext, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PCCTL_CONTEXT *")] CTL_CONTEXT** ppProvCtlContext);
}
