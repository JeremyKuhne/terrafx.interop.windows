// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("68961E68-832B-41EA-BC91-63593F3E70E3")]
[NativeTypeName("struct IMediaSample2Config : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMediaSample2Config : IMediaSample2Config.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaSample2Config*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSample2Config*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaSample2Config*, uint>)(lpVtbl[1]))((IMediaSample2Config*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaSample2Config*, uint>)(lpVtbl[2]))((IMediaSample2Config*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSurface(IUnknown** ppDirect3DSurface9)
    {
        return ((delegate* unmanaged<IMediaSample2Config*, IUnknown**, int>)(lpVtbl[3]))((IMediaSample2Config*)Unsafe.AsPointer(ref this), ppDirect3DSurface9);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSurface(IUnknown** ppDirect3DSurface9);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMediaSample2Config*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMediaSample2Config*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IMediaSample2Config*, uint> Release;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<IMediaSample2Config*, IUnknown**, int> GetSurface;
    }
}
