// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("AD56F402-E162-4F25-908F-7D577CF9BDA9")]
    [NativeTypeName("struct ITfDisplayAttributeNotifySink : IUnknown")]
    public unsafe partial struct ITfDisplayAttributeNotifySink
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfDisplayAttributeNotifySink*, Guid*, void**, int>)(lpVtbl[0]))((ITfDisplayAttributeNotifySink*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfDisplayAttributeNotifySink*, uint>)(lpVtbl[1]))((ITfDisplayAttributeNotifySink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfDisplayAttributeNotifySink*, uint>)(lpVtbl[2]))((ITfDisplayAttributeNotifySink*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnUpdateInfo()
        {
            return ((delegate* unmanaged<ITfDisplayAttributeNotifySink*, int>)(lpVtbl[3]))((ITfDisplayAttributeNotifySink*)Unsafe.AsPointer(ref this));
        }
    }
}
