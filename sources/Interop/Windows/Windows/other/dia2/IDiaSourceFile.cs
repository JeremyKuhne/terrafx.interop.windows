// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDiaSourceFile.xml' path='doc/member[@name="IDiaSourceFile"]/*' />
[Guid("A2EF5353-F5A8-4EB3-90D2-CB526ACB3CDD")]
[NativeTypeName("struct IDiaSourceFile : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaSourceFile : IDiaSourceFile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaSourceFile));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaSourceFile*, Guid*, void**, int>)(lpVtbl[0]))((IDiaSourceFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDiaSourceFile*, uint>)(lpVtbl[1]))((IDiaSourceFile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaSourceFile*, uint>)(lpVtbl[2]))((IDiaSourceFile*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDiaSourceFile.xml' path='doc/member[@name="IDiaSourceFile.get_uniqueId"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_uniqueId([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSourceFile*, uint*, int>)(lpVtbl[3]))((IDiaSourceFile*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSourceFile.xml' path='doc/member[@name="IDiaSourceFile.get_fileName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_fileName([NativeTypeName("BSTR *")] ushort** pRetVal)
    {
        return ((delegate* unmanaged<IDiaSourceFile*, ushort**, int>)(lpVtbl[4]))((IDiaSourceFile*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSourceFile.xml' path='doc/member[@name="IDiaSourceFile.get_checksumType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_checksumType([NativeTypeName("DWORD *")] uint* pRetVal)
    {
        return ((delegate* unmanaged<IDiaSourceFile*, uint*, int>)(lpVtbl[5]))((IDiaSourceFile*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSourceFile.xml' path='doc/member[@name="IDiaSourceFile.get_compilands"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_compilands(IDiaEnumSymbols** pRetVal)
    {
        return ((delegate* unmanaged<IDiaSourceFile*, IDiaEnumSymbols**, int>)(lpVtbl[6]))((IDiaSourceFile*)Unsafe.AsPointer(ref this), pRetVal);
    }

    /// <include file='IDiaSourceFile.xml' path='doc/member[@name="IDiaSourceFile.get_checksum"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_checksum([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData)
    {
        return ((delegate* unmanaged<IDiaSourceFile*, uint, uint*, byte*, int>)(lpVtbl[7]))((IDiaSourceFile*)Unsafe.AsPointer(ref this), cbData, pcbData, pbData);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_uniqueId([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(4)]
        HRESULT get_fileName([NativeTypeName("BSTR *")] ushort** pRetVal);

        [VtblIndex(5)]
        HRESULT get_checksumType([NativeTypeName("DWORD *")] uint* pRetVal);

        [VtblIndex(6)]
        HRESULT get_compilands(IDiaEnumSymbols** pRetVal);

        [VtblIndex(7)]
        HRESULT get_checksum([NativeTypeName("DWORD")] uint cbData, [NativeTypeName("DWORD *")] uint* pcbData, byte* pbData);
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_uniqueId;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_fileName;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_checksumType;

        [NativeTypeName("HRESULT (IDiaEnumSymbols **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiaEnumSymbols**, int> get_compilands;

        [NativeTypeName("HRESULT (DWORD, DWORD *, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, byte*, int> get_checksum;
    }
}
