// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("6EF2A660-47C0-4666-B13D-CBB717F2FA2C")]
[NativeTypeName("struct IMFMediaSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaSink : IMFMediaSink.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaSink*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaSink*, uint>)(lpVtbl[1]))((IMFMediaSink*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaSink*, uint>)(lpVtbl[2]))((IMFMediaSink*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics)
    {
        return ((delegate* unmanaged<IMFMediaSink*, uint*, int>)(lpVtbl[3]))((IMFMediaSink*)Unsafe.AsPointer(ref this), pdwCharacteristics);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddStreamSink([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier, IMFMediaType* pMediaType, IMFStreamSink** ppStreamSink)
    {
        return ((delegate* unmanaged<IMFMediaSink*, uint, IMFMediaType*, IMFStreamSink**, int>)(lpVtbl[4]))((IMFMediaSink*)Unsafe.AsPointer(ref this), dwStreamSinkIdentifier, pMediaType, ppStreamSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RemoveStreamSink([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier)
    {
        return ((delegate* unmanaged<IMFMediaSink*, uint, int>)(lpVtbl[5]))((IMFMediaSink*)Unsafe.AsPointer(ref this), dwStreamSinkIdentifier);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStreamSinkCount([NativeTypeName("DWORD *")] uint* pcStreamSinkCount)
    {
        return ((delegate* unmanaged<IMFMediaSink*, uint*, int>)(lpVtbl[6]))((IMFMediaSink*)Unsafe.AsPointer(ref this), pcStreamSinkCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetStreamSinkByIndex([NativeTypeName("DWORD")] uint dwIndex, IMFStreamSink** ppStreamSink)
    {
        return ((delegate* unmanaged<IMFMediaSink*, uint, IMFStreamSink**, int>)(lpVtbl[7]))((IMFMediaSink*)Unsafe.AsPointer(ref this), dwIndex, ppStreamSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetStreamSinkById([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier, IMFStreamSink** ppStreamSink)
    {
        return ((delegate* unmanaged<IMFMediaSink*, uint, IMFStreamSink**, int>)(lpVtbl[8]))((IMFMediaSink*)Unsafe.AsPointer(ref this), dwStreamSinkIdentifier, ppStreamSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetPresentationClock(IMFPresentationClock* pPresentationClock)
    {
        return ((delegate* unmanaged<IMFMediaSink*, IMFPresentationClock*, int>)(lpVtbl[9]))((IMFMediaSink*)Unsafe.AsPointer(ref this), pPresentationClock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetPresentationClock(IMFPresentationClock** ppPresentationClock)
    {
        return ((delegate* unmanaged<IMFMediaSink*, IMFPresentationClock**, int>)(lpVtbl[10]))((IMFMediaSink*)Unsafe.AsPointer(ref this), ppPresentationClock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFMediaSink*, int>)(lpVtbl[11]))((IMFMediaSink*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCharacteristics([NativeTypeName("DWORD *")] uint* pdwCharacteristics);

        [VtblIndex(4)]
        HRESULT AddStreamSink([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier, IMFMediaType* pMediaType, IMFStreamSink** ppStreamSink);

        [VtblIndex(5)]
        HRESULT RemoveStreamSink([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier);

        [VtblIndex(6)]
        HRESULT GetStreamSinkCount([NativeTypeName("DWORD *")] uint* pcStreamSinkCount);

        [VtblIndex(7)]
        HRESULT GetStreamSinkByIndex([NativeTypeName("DWORD")] uint dwIndex, IMFStreamSink** ppStreamSink);

        [VtblIndex(8)]
        HRESULT GetStreamSinkById([NativeTypeName("DWORD")] uint dwStreamSinkIdentifier, IMFStreamSink** ppStreamSink);

        [VtblIndex(9)]
        HRESULT SetPresentationClock(IMFPresentationClock* pPresentationClock);

        [VtblIndex(10)]
        HRESULT GetPresentationClock(IMFPresentationClock** ppPresentationClock);

        [VtblIndex(11)]
        HRESULT Shutdown();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSink*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSink*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSink*, uint> Release;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSink*, uint*, int> GetCharacteristics;

        [NativeTypeName("HRESULT (DWORD, IMFMediaType *, IMFStreamSink **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSink*, uint, IMFMediaType*, IMFStreamSink**, int> AddStreamSink;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSink*, uint, int> RemoveStreamSink;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSink*, uint*, int> GetStreamSinkCount;

        [NativeTypeName("HRESULT (DWORD, IMFStreamSink **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSink*, uint, IMFStreamSink**, int> GetStreamSinkByIndex;

        [NativeTypeName("HRESULT (DWORD, IMFStreamSink **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSink*, uint, IMFStreamSink**, int> GetStreamSinkById;

        [NativeTypeName("HRESULT (IMFPresentationClock *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSink*, IMFPresentationClock*, int> SetPresentationClock;

        [NativeTypeName("HRESULT (IMFPresentationClock **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSink*, IMFPresentationClock**, int> GetPresentationClock;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IMFMediaSink*, int> Shutdown;
    }
}
