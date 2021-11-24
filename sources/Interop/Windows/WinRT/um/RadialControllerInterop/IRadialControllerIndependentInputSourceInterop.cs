// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RadialControllerInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[Guid("3D577EFF-4CEE-11E6-B535-001BDC06AB3B")]
[NativeTypeName("struct IRadialControllerIndependentInputSourceInterop : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRadialControllerIndependentInputSourceInterop : IRadialControllerIndependentInputSourceInterop.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, Guid*, void**, int>)(lpVtbl[0]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, uint>)(lpVtbl[1]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, uint>)(lpVtbl[2]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, uint*, Guid**, int>)(lpVtbl[3]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, HSTRING*, int>)(lpVtbl[4]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this), className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, TrustLevel*, int>)(lpVtbl[5]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this), trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateForWindow(HWND hwnd, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, HWND, Guid*, void**, int>)(lpVtbl[6]))((IRadialControllerIndependentInputSourceInterop*)Unsafe.AsPointer(ref this), hwnd, riid, ppv);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateForWindow(HWND hwnd, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, uint> Release;

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HWND, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IRadialControllerIndependentInputSourceInterop*, HWND, Guid*, void**, int> CreateForWindow;
    }
}
