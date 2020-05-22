// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Winapi)]
    public unsafe delegate void PTP_WAIT_CALLBACK([NativeTypeName("PTP_CALLBACK_INSTANCE")] IntPtr Instance, [NativeTypeName("PVOID")] void* Context, [NativeTypeName("PTP_WAIT")] IntPtr Wait, [NativeTypeName("TP_WAIT_RESULT")] uint WaitResult);
}
