// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("651B9AD0-0FC7-4AA9-9538-D89931010741")]
[NativeTypeName("struct IMediaObjectInPlace : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMediaObjectInPlace : IMediaObjectInPlace.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaObjectInPlace*, Guid*, void**, int>)(lpVtbl[0]))((IMediaObjectInPlace*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaObjectInPlace*, uint>)(lpVtbl[1]))((IMediaObjectInPlace*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaObjectInPlace*, uint>)(lpVtbl[2]))((IMediaObjectInPlace*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Process([NativeTypeName("ULONG")] uint ulSize, byte* pData, [NativeTypeName("REFERENCE_TIME")] long refTimeStart, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IMediaObjectInPlace*, uint, byte*, long, uint, int>)(lpVtbl[3]))((IMediaObjectInPlace*)Unsafe.AsPointer(ref this), ulSize, pData, refTimeStart, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Clone(IMediaObjectInPlace** ppMediaObject)
    {
        return ((delegate* unmanaged<IMediaObjectInPlace*, IMediaObjectInPlace**, int>)(lpVtbl[4]))((IMediaObjectInPlace*)Unsafe.AsPointer(ref this), ppMediaObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLatency([NativeTypeName("REFERENCE_TIME *")] long* pLatencyTime)
    {
        return ((delegate* unmanaged<IMediaObjectInPlace*, long*, int>)(lpVtbl[5]))((IMediaObjectInPlace*)Unsafe.AsPointer(ref this), pLatencyTime);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Process([NativeTypeName("ULONG")] uint ulSize, byte* pData, [NativeTypeName("REFERENCE_TIME")] long refTimeStart, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(4)]
        HRESULT Clone(IMediaObjectInPlace** ppMediaObject);

        [VtblIndex(5)]
        HRESULT GetLatency([NativeTypeName("REFERENCE_TIME *")] long* pLatencyTime);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMediaObjectInPlace*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMediaObjectInPlace*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMediaObjectInPlace*, uint> Release;

        [NativeTypeName("HRESULT (ULONG, BYTE *, REFERENCE_TIME, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IMediaObjectInPlace*, uint, byte*, long, uint, int> Process;

        [NativeTypeName("HRESULT (IMediaObjectInPlace **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMediaObjectInPlace*, IMediaObjectInPlace**, int> Clone;

        [NativeTypeName("HRESULT (REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<IMediaObjectInPlace*, long*, int> GetLatency;
    }
}
