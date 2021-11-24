// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[SupportedOSPlatform("windows8.1")]
[Guid("F92F19D2-3ADE-45A6-A20C-F6F1EA90554B")]
[NativeTypeName("struct ISwapChainPanelNative : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISwapChainPanelNative : ISwapChainPanelNative.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISwapChainPanelNative*, Guid*, void**, int>)(lpVtbl[0]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISwapChainPanelNative*, uint>)(lpVtbl[1]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISwapChainPanelNative*, uint>)(lpVtbl[2]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetSwapChain(IDXGISwapChain* swapChain)
    {
        return ((delegate* unmanaged<ISwapChainPanelNative*, IDXGISwapChain*, int>)(lpVtbl[3]))((ISwapChainPanelNative*)Unsafe.AsPointer(ref this), swapChain);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetSwapChain(IDXGISwapChain* swapChain);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISwapChainPanelNative*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISwapChainPanelNative*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISwapChainPanelNative*, uint> Release;

        [NativeTypeName("HRESULT (IDXGISwapChain *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISwapChainPanelNative*, IDXGISwapChain*, int> SetSwapChain;
    }
}
