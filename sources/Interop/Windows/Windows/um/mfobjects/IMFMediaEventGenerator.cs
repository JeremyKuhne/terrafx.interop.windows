// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("2CD0BD52-BCD5-4B89-B62C-EADC0C031E7D")]
[NativeTypeName("struct IMFMediaEventGenerator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaEventGenerator : IMFMediaEventGenerator.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEventGenerator*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEventGenerator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEventGenerator*, uint>)(lpVtbl[1]))((IMFMediaEventGenerator*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEventGenerator*, uint>)(lpVtbl[2]))((IMFMediaEventGenerator*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaEventGenerator*, uint, IMFMediaEvent**, int>)(lpVtbl[3]))((IMFMediaEventGenerator*)Unsafe.AsPointer(ref this), dwFlags, ppEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState)
    {
        return ((delegate* unmanaged<IMFMediaEventGenerator*, IMFAsyncCallback*, IUnknown*, int>)(lpVtbl[4]))((IMFMediaEventGenerator*)Unsafe.AsPointer(ref this), pCallback, punkState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent)
    {
        return ((delegate* unmanaged<IMFMediaEventGenerator*, IMFAsyncResult*, IMFMediaEvent**, int>)(lpVtbl[5]))((IMFMediaEventGenerator*)Unsafe.AsPointer(ref this), pResult, ppEvent);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, HRESULT hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue)
    {
        return ((delegate* unmanaged<IMFMediaEventGenerator*, uint, Guid*, HRESULT, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMediaEventGenerator*)Unsafe.AsPointer(ref this), met, guidExtendedType, hrStatus, pvValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetEvent([NativeTypeName("DWORD")] uint dwFlags, IMFMediaEvent** ppEvent);

        [VtblIndex(4)]
        HRESULT BeginGetEvent(IMFAsyncCallback* pCallback, IUnknown* punkState);

        [VtblIndex(5)]
        HRESULT EndGetEvent(IMFAsyncResult* pResult, IMFMediaEvent** ppEvent);

        [VtblIndex(6)]
        HRESULT QueueEvent([NativeTypeName("MediaEventType")] uint met, [NativeTypeName("const GUID &")] Guid* guidExtendedType, HRESULT hrStatus, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvValue);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEventGenerator*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEventGenerator*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEventGenerator*, uint> Release;

        [NativeTypeName("HRESULT (DWORD, IMFMediaEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEventGenerator*, uint, IMFMediaEvent**, int> GetEvent;

        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEventGenerator*, IMFAsyncCallback*, IUnknown*, int> BeginGetEvent;

        [NativeTypeName("HRESULT (IMFAsyncResult *, IMFMediaEvent **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEventGenerator*, IMFAsyncResult*, IMFMediaEvent**, int> EndGetEvent;

        [NativeTypeName("HRESULT (MediaEventType, const GUID &, HRESULT, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaEventGenerator*, uint, Guid*, HRESULT, PROPVARIANT*, int> QueueEvent;
    }
}
