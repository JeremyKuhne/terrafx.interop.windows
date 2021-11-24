// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Windows.Devices.Display.Core.Interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[Guid("64338358-366A-471B-BD56-DD8EF48E439B")]
[NativeTypeName("struct IDisplayDeviceInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDisplayDeviceInterop : IDisplayDeviceInterop.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDisplayDeviceInterop*, Guid*, void**, int>)(lpVtbl[0]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDisplayDeviceInterop*, uint>)(lpVtbl[1]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDisplayDeviceInterop*, uint>)(lpVtbl[2]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateSharedHandle(IInspectable* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pSecurityAttributes, [NativeTypeName("DWORD")] uint Access, HSTRING Name, HANDLE* pHandle)
    {
        return ((delegate* unmanaged<IDisplayDeviceInterop*, IInspectable*, SECURITY_ATTRIBUTES*, uint, HSTRING, HANDLE*, int>)(lpVtbl[3]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this), pObject, pSecurityAttributes, Access, Name, pHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OpenSharedHandle(HANDLE NTHandle, [NativeTypeName("IID")] Guid riid, void** ppvObj)
    {
        return ((delegate* unmanaged<IDisplayDeviceInterop*, HANDLE, Guid, void**, int>)(lpVtbl[4]))((IDisplayDeviceInterop*)Unsafe.AsPointer(ref this), NTHandle, riid, ppvObj);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateSharedHandle(IInspectable* pObject, [NativeTypeName("const SECURITY_ATTRIBUTES *")] SECURITY_ATTRIBUTES* pSecurityAttributes, [NativeTypeName("DWORD")] uint Access, HSTRING Name, HANDLE* pHandle);

        [VtblIndex(4)]
        HRESULT OpenSharedHandle(HANDLE NTHandle, [NativeTypeName("IID")] Guid riid, void** ppvObj);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDisplayDeviceInterop*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDisplayDeviceInterop*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDisplayDeviceInterop*, uint> Release;

        [NativeTypeName("HRESULT (IInspectable *, const SECURITY_ATTRIBUTES *, DWORD, HSTRING, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDisplayDeviceInterop*, IInspectable*, SECURITY_ATTRIBUTES*, uint, HSTRING, HANDLE*, int> CreateSharedHandle;

        [NativeTypeName("HRESULT (HANDLE, IID, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDisplayDeviceInterop*, HANDLE, Guid, void**, int> OpenSharedHandle;
    }
}
