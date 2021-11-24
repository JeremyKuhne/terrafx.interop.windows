// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("DF0B3D60-548F-101B-8E65-08002B2BD119")]
[NativeTypeName("struct ISupportErrorInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISupportErrorInfo : ISupportErrorInfo.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISupportErrorInfo*, Guid*, void**, int>)(lpVtbl[0]))((ISupportErrorInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISupportErrorInfo*, uint>)(lpVtbl[1]))((ISupportErrorInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISupportErrorInfo*, uint>)(lpVtbl[2]))((ISupportErrorInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InterfaceSupportsErrorInfo([NativeTypeName("const IID &")] Guid* riid)
    {
        return ((delegate* unmanaged<ISupportErrorInfo*, Guid*, int>)(lpVtbl[3]))((ISupportErrorInfo*)Unsafe.AsPointer(ref this), riid);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InterfaceSupportsErrorInfo([NativeTypeName("const IID &")] Guid* riid);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISupportErrorInfo*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISupportErrorInfo*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISupportErrorInfo*, uint> Release;

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<ISupportErrorInfo*, Guid*, int> InterfaceSupportsErrorInfo;
    }
}
