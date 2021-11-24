// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct WS_CERTIFICATE_VALIDATION_CALLBACK_CONTEXT
{
    [NativeTypeName("WS_CERTIFICATE_VALIDATION_CALLBACK")]
    public delegate* unmanaged<CERT_CONTEXT*, void*, HRESULT> callback;

    public void* state;
}
