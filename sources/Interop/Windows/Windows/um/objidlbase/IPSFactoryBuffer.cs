// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("D5F569D0-593B-101A-B569-08002B2DBF7A")]
[NativeTypeName("struct IPSFactoryBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPSFactoryBuffer : IPSFactoryBuffer.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPSFactoryBuffer*, Guid*, void**, int>)(lpVtbl[0]))((IPSFactoryBuffer*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPSFactoryBuffer*, uint>)(lpVtbl[1]))((IPSFactoryBuffer*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPSFactoryBuffer*, uint>)(lpVtbl[2]))((IPSFactoryBuffer*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateProxy(IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, IRpcProxyBuffer** ppProxy, void** ppv)
    {
        return ((delegate* unmanaged<IPSFactoryBuffer*, IUnknown*, Guid*, IRpcProxyBuffer**, void**, int>)(lpVtbl[3]))((IPSFactoryBuffer*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppProxy, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateStub([NativeTypeName("const IID &")] Guid* riid, IUnknown* pUnkServer, IRpcStubBuffer** ppStub)
    {
        return ((delegate* unmanaged<IPSFactoryBuffer*, Guid*, IUnknown*, IRpcStubBuffer**, int>)(lpVtbl[4]))((IPSFactoryBuffer*)Unsafe.AsPointer(ref this), riid, pUnkServer, ppStub);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateProxy(IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, IRpcProxyBuffer** ppProxy, void** ppv);

        [VtblIndex(4)]
        HRESULT CreateStub([NativeTypeName("const IID &")] Guid* riid, IUnknown* pUnkServer, IRpcStubBuffer** ppStub);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IPSFactoryBuffer*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IPSFactoryBuffer*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IPSFactoryBuffer*, uint> Release;

        [NativeTypeName("HRESULT (IUnknown *, const IID &, IRpcProxyBuffer **, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IPSFactoryBuffer*, IUnknown*, Guid*, IRpcProxyBuffer**, void**, int> CreateProxy;

        [NativeTypeName("HRESULT (const IID &, IUnknown *, IRpcStubBuffer **) __attribute__((stdcall))")]
        public delegate* unmanaged<IPSFactoryBuffer*, Guid*, IUnknown*, IRpcStubBuffer**, int> CreateStub;
    }
}
