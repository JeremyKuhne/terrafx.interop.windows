// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("C6545BF0-E76B-11D0-BD52-00A0C911CE86")]
[NativeTypeName("struct IAMDevMemoryAllocator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAMDevMemoryAllocator : IAMDevMemoryAllocator.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMDevMemoryAllocator*, Guid*, void**, int>)(lpVtbl[0]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAMDevMemoryAllocator*, uint>)(lpVtbl[1]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMDevMemoryAllocator*, uint>)(lpVtbl[2]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetInfo([NativeTypeName("DWORD *")] uint* pdwcbTotalFree, [NativeTypeName("DWORD *")] uint* pdwcbLargestFree, [NativeTypeName("DWORD *")] uint* pdwcbTotalMemory, [NativeTypeName("DWORD *")] uint* pdwcbMinimumChunk)
    {
        return ((delegate* unmanaged<IAMDevMemoryAllocator*, uint*, uint*, uint*, uint*, int>)(lpVtbl[3]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), pdwcbTotalFree, pdwcbLargestFree, pdwcbTotalMemory, pdwcbMinimumChunk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CheckMemory([NativeTypeName("const BYTE *")] byte* pBuffer)
    {
        return ((delegate* unmanaged<IAMDevMemoryAllocator*, byte*, int>)(lpVtbl[4]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), pBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Alloc(byte** ppBuffer, [NativeTypeName("DWORD *")] uint* pdwcbBuffer)
    {
        return ((delegate* unmanaged<IAMDevMemoryAllocator*, byte**, uint*, int>)(lpVtbl[5]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), ppBuffer, pdwcbBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Free(byte* pBuffer)
    {
        return ((delegate* unmanaged<IAMDevMemoryAllocator*, byte*, int>)(lpVtbl[6]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), pBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDevMemoryObject(IUnknown** ppUnkInnner, IUnknown* pUnkOuter)
    {
        return ((delegate* unmanaged<IAMDevMemoryAllocator*, IUnknown**, IUnknown*, int>)(lpVtbl[7]))((IAMDevMemoryAllocator*)Unsafe.AsPointer(ref this), ppUnkInnner, pUnkOuter);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetInfo([NativeTypeName("DWORD *")] uint* pdwcbTotalFree, [NativeTypeName("DWORD *")] uint* pdwcbLargestFree, [NativeTypeName("DWORD *")] uint* pdwcbTotalMemory, [NativeTypeName("DWORD *")] uint* pdwcbMinimumChunk);

        [VtblIndex(4)]
        HRESULT CheckMemory([NativeTypeName("const BYTE *")] byte* pBuffer);

        [VtblIndex(5)]
        HRESULT Alloc(byte** ppBuffer, [NativeTypeName("DWORD *")] uint* pdwcbBuffer);

        [VtblIndex(6)]
        HRESULT Free(byte* pBuffer);

        [VtblIndex(7)]
        HRESULT GetDevMemoryObject(IUnknown** ppUnkInnner, IUnknown* pUnkOuter);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAMDevMemoryAllocator*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAMDevMemoryAllocator*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAMDevMemoryAllocator*, uint> Release;

        [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAMDevMemoryAllocator*, uint*, uint*, uint*, uint*, int> GetInfo;

        [NativeTypeName("HRESULT (const BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAMDevMemoryAllocator*, byte*, int> CheckMemory;

        [NativeTypeName("HRESULT (BYTE **, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAMDevMemoryAllocator*, byte**, uint*, int> Alloc;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAMDevMemoryAllocator*, byte*, int> Free;

        [NativeTypeName("HRESULT (IUnknown **, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAMDevMemoryAllocator*, IUnknown**, IUnknown*, int> GetDevMemoryObject;
    }
}
