// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D11ClassInstance.xml' path='doc/member[@name="ID3D11ClassInstance"]/*' />
[Guid("A6CD7FAA-B0B7-4A2F-9436-8662A65797CB")]
[NativeTypeName("struct ID3D11ClassInstance : ID3D11DeviceChild")]
[NativeInheritance("ID3D11DeviceChild")]
public unsafe partial struct ID3D11ClassInstance : ID3D11ClassInstance.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D11ClassInstance));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11ClassInstance*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11ClassInstance*, uint>)(lpVtbl[1]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11ClassInstance*, uint>)(lpVtbl[2]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device** ppDevice)
    {
        ((delegate* unmanaged<ID3D11ClassInstance*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11ClassInstance*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D11ClassInstance*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D11ClassInstance*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <include file='ID3D11ClassInstance.xml' path='doc/member[@name="ID3D11ClassInstance.GetClassLinkage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetClassLinkage(ID3D11ClassLinkage** ppLinkage)
    {
        ((delegate* unmanaged<ID3D11ClassInstance*, ID3D11ClassLinkage**, void>)(lpVtbl[7]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), ppLinkage);
    }

    /// <include file='ID3D11ClassInstance.xml' path='doc/member[@name="ID3D11ClassInstance.GetDesc"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetDesc(D3D11_CLASS_INSTANCE_DESC* pDesc)
    {
        ((delegate* unmanaged<ID3D11ClassInstance*, D3D11_CLASS_INSTANCE_DESC*, void>)(lpVtbl[8]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D11ClassInstance.xml' path='doc/member[@name="ID3D11ClassInstance.GetInstanceName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void GetInstanceName([NativeTypeName("LPSTR")] sbyte* pInstanceName, [NativeTypeName("SIZE_T *")] nuint* pBufferLength)
    {
        ((delegate* unmanaged<ID3D11ClassInstance*, sbyte*, nuint*, void>)(lpVtbl[9]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), pInstanceName, pBufferLength);
    }

    /// <include file='ID3D11ClassInstance.xml' path='doc/member[@name="ID3D11ClassInstance.GetTypeName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void GetTypeName([NativeTypeName("LPSTR")] sbyte* pTypeName, [NativeTypeName("SIZE_T *")] nuint* pBufferLength)
    {
        ((delegate* unmanaged<ID3D11ClassInstance*, sbyte*, nuint*, void>)(lpVtbl[10]))((ID3D11ClassInstance*)Unsafe.AsPointer(ref this), pTypeName, pBufferLength);
    }

    public interface Interface : ID3D11DeviceChild.Interface
    {
        [VtblIndex(7)]
        void GetClassLinkage(ID3D11ClassLinkage** ppLinkage);

        [VtblIndex(8)]
        void GetDesc(D3D11_CLASS_INSTANCE_DESC* pDesc);

        [VtblIndex(9)]
        void GetInstanceName([NativeTypeName("LPSTR")] sbyte* pInstanceName, [NativeTypeName("SIZE_T *")] nuint* pBufferLength);

        [VtblIndex(10)]
        void GetTypeName([NativeTypeName("LPSTR")] sbyte* pTypeName, [NativeTypeName("SIZE_T *")] nuint* pBufferLength);
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

        [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Device**, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("void (ID3D11ClassLinkage **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11ClassLinkage**, void> GetClassLinkage;

        [NativeTypeName("void (D3D11_CLASS_INSTANCE_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_CLASS_INSTANCE_DESC*, void> GetDesc;

        [NativeTypeName("void (LPSTR, SIZE_T *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, nuint*, void> GetInstanceName;

        [NativeTypeName("void (LPSTR, SIZE_T *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, nuint*, void> GetTypeName;
    }
}
