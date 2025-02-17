// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAsyncReader.xml' path='doc/member[@name="IAsyncReader"]/*' />
[Guid("56A868AA-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IAsyncReader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAsyncReader : IAsyncReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAsyncReader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAsyncReader*, Guid*, void**, int>)(lpVtbl[0]))((IAsyncReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAsyncReader*, uint>)(lpVtbl[1]))((IAsyncReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAsyncReader*, uint>)(lpVtbl[2]))((IAsyncReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAsyncReader.xml' path='doc/member[@name="IAsyncReader.RequestAllocator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RequestAllocator(IMemAllocator* pPreferred, ALLOCATOR_PROPERTIES* pProps, IMemAllocator** ppActual)
    {
        return ((delegate* unmanaged<IAsyncReader*, IMemAllocator*, ALLOCATOR_PROPERTIES*, IMemAllocator**, int>)(lpVtbl[3]))((IAsyncReader*)Unsafe.AsPointer(ref this), pPreferred, pProps, ppActual);
    }

    /// <include file='IAsyncReader.xml' path='doc/member[@name="IAsyncReader.Request"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Request(IMediaSample* pSample, [NativeTypeName("DWORD_PTR")] nuint dwUser)
    {
        return ((delegate* unmanaged<IAsyncReader*, IMediaSample*, nuint, int>)(lpVtbl[4]))((IAsyncReader*)Unsafe.AsPointer(ref this), pSample, dwUser);
    }

    /// <include file='IAsyncReader.xml' path='doc/member[@name="IAsyncReader.WaitForNext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT WaitForNext([NativeTypeName("DWORD")] uint dwTimeout, IMediaSample** ppSample, [NativeTypeName("DWORD_PTR *")] nuint* pdwUser)
    {
        return ((delegate* unmanaged<IAsyncReader*, uint, IMediaSample**, nuint*, int>)(lpVtbl[5]))((IAsyncReader*)Unsafe.AsPointer(ref this), dwTimeout, ppSample, pdwUser);
    }

    /// <include file='IAsyncReader.xml' path='doc/member[@name="IAsyncReader.SyncReadAligned"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SyncReadAligned(IMediaSample* pSample)
    {
        return ((delegate* unmanaged<IAsyncReader*, IMediaSample*, int>)(lpVtbl[6]))((IAsyncReader*)Unsafe.AsPointer(ref this), pSample);
    }

    /// <include file='IAsyncReader.xml' path='doc/member[@name="IAsyncReader.SyncRead"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SyncRead([NativeTypeName("LONGLONG")] long llPosition, [NativeTypeName("LONG")] int lLength, byte* pBuffer)
    {
        return ((delegate* unmanaged<IAsyncReader*, long, int, byte*, int>)(lpVtbl[7]))((IAsyncReader*)Unsafe.AsPointer(ref this), llPosition, lLength, pBuffer);
    }

    /// <include file='IAsyncReader.xml' path='doc/member[@name="IAsyncReader.Length"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Length([NativeTypeName("LONGLONG *")] long* pTotal, [NativeTypeName("LONGLONG *")] long* pAvailable)
    {
        return ((delegate* unmanaged<IAsyncReader*, long*, long*, int>)(lpVtbl[8]))((IAsyncReader*)Unsafe.AsPointer(ref this), pTotal, pAvailable);
    }

    /// <include file='IAsyncReader.xml' path='doc/member[@name="IAsyncReader.BeginFlush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT BeginFlush()
    {
        return ((delegate* unmanaged<IAsyncReader*, int>)(lpVtbl[9]))((IAsyncReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAsyncReader.xml' path='doc/member[@name="IAsyncReader.EndFlush"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EndFlush()
    {
        return ((delegate* unmanaged<IAsyncReader*, int>)(lpVtbl[10]))((IAsyncReader*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RequestAllocator(IMemAllocator* pPreferred, ALLOCATOR_PROPERTIES* pProps, IMemAllocator** ppActual);

        [VtblIndex(4)]
        HRESULT Request(IMediaSample* pSample, [NativeTypeName("DWORD_PTR")] nuint dwUser);

        [VtblIndex(5)]
        HRESULT WaitForNext([NativeTypeName("DWORD")] uint dwTimeout, IMediaSample** ppSample, [NativeTypeName("DWORD_PTR *")] nuint* pdwUser);

        [VtblIndex(6)]
        HRESULT SyncReadAligned(IMediaSample* pSample);

        [VtblIndex(7)]
        HRESULT SyncRead([NativeTypeName("LONGLONG")] long llPosition, [NativeTypeName("LONG")] int lLength, byte* pBuffer);

        [VtblIndex(8)]
        HRESULT Length([NativeTypeName("LONGLONG *")] long* pTotal, [NativeTypeName("LONGLONG *")] long* pAvailable);

        [VtblIndex(9)]
        HRESULT BeginFlush();

        [VtblIndex(10)]
        HRESULT EndFlush();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IMemAllocator *, ALLOCATOR_PROPERTIES *, IMemAllocator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMemAllocator*, ALLOCATOR_PROPERTIES*, IMemAllocator**, int> RequestAllocator;

        [NativeTypeName("HRESULT (IMediaSample *, DWORD_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMediaSample*, nuint, int> Request;

        [NativeTypeName("HRESULT (DWORD, IMediaSample **, DWORD_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IMediaSample**, nuint*, int> WaitForNext;

        [NativeTypeName("HRESULT (IMediaSample *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMediaSample*, int> SyncReadAligned;

        [NativeTypeName("HRESULT (LONGLONG, LONG, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int, byte*, int> SyncRead;

        [NativeTypeName("HRESULT (LONGLONG *, LONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, long*, int> Length;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> BeginFlush;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EndFlush;
    }
}
