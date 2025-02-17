// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12sdklayers.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12Debug3.xml' path='doc/member[@name="ID3D12Debug3"]/*' />
[Guid("5CF4E58F-F671-4FF1-A542-3686E3D153D1")]
[NativeTypeName("struct ID3D12Debug3 : ID3D12Debug")]
[NativeInheritance("ID3D12Debug")]
public unsafe partial struct ID3D12Debug3 : ID3D12Debug3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D12Debug3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12Debug3*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12Debug3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12Debug3*, uint>)(lpVtbl[1]))((ID3D12Debug3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12Debug3*, uint>)(lpVtbl[2]))((ID3D12Debug3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D12Debug.EnableDebugLayer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void EnableDebugLayer()
    {
        ((delegate* unmanaged<ID3D12Debug3*, void>)(lpVtbl[3]))((ID3D12Debug3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12Debug3.xml' path='doc/member[@name="ID3D12Debug3.SetEnableGPUBasedValidation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetEnableGPUBasedValidation(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug3*, BOOL, void>)(lpVtbl[4]))((ID3D12Debug3*)Unsafe.AsPointer(ref this), Enable);
    }

    /// <include file='ID3D12Debug3.xml' path='doc/member[@name="ID3D12Debug3.SetEnableSynchronizedCommandQueueValidation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void SetEnableSynchronizedCommandQueueValidation(BOOL Enable)
    {
        ((delegate* unmanaged<ID3D12Debug3*, BOOL, void>)(lpVtbl[5]))((ID3D12Debug3*)Unsafe.AsPointer(ref this), Enable);
    }

    /// <include file='ID3D12Debug3.xml' path='doc/member[@name="ID3D12Debug3.SetGPUBasedValidationFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags)
    {
        ((delegate* unmanaged<ID3D12Debug3*, D3D12_GPU_BASED_VALIDATION_FLAGS, void>)(lpVtbl[6]))((ID3D12Debug3*)Unsafe.AsPointer(ref this), Flags);
    }

    public interface Interface : ID3D12Debug.Interface
    {
        [VtblIndex(4)]
        void SetEnableGPUBasedValidation(BOOL Enable);

        [VtblIndex(5)]
        void SetEnableSynchronizedCommandQueueValidation(BOOL Enable);

        [VtblIndex(6)]
        void SetGPUBasedValidationFlags(D3D12_GPU_BASED_VALIDATION_FLAGS Flags);
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

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> EnableDebugLayer;

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetEnableGPUBasedValidation;

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, void> SetEnableSynchronizedCommandQueueValidation;

        [NativeTypeName("void (D3D12_GPU_BASED_VALIDATION_FLAGS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D12_GPU_BASED_VALIDATION_FLAGS, void> SetGPUBasedValidationFlags;
    }
}
