// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/DocumentSource.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

[Guid("0B31CC62-D7EC-4747-9D6E-F2537D870F2B")]
[NativeTypeName("struct IPrintPreviewPageCollection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPrintPreviewPageCollection : IPrintPreviewPageCollection.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPrintPreviewPageCollection*, Guid*, void**, int>)(lpVtbl[0]))((IPrintPreviewPageCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintPreviewPageCollection*, uint>)(lpVtbl[1]))((IPrintPreviewPageCollection*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintPreviewPageCollection*, uint>)(lpVtbl[2]))((IPrintPreviewPageCollection*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Paginate([NativeTypeName("UINT32")] uint currentJobPage, IInspectable* printTaskOptions)
    {
        return ((delegate* unmanaged<IPrintPreviewPageCollection*, uint, IInspectable*, int>)(lpVtbl[3]))((IPrintPreviewPageCollection*)Unsafe.AsPointer(ref this), currentJobPage, printTaskOptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT MakePage([NativeTypeName("UINT32")] uint desiredJobPage, float width, float height)
    {
        return ((delegate* unmanaged<IPrintPreviewPageCollection*, uint, float, float, int>)(lpVtbl[4]))((IPrintPreviewPageCollection*)Unsafe.AsPointer(ref this), desiredJobPage, width, height);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Paginate([NativeTypeName("UINT32")] uint currentJobPage, IInspectable* printTaskOptions);

        [VtblIndex(4)]
        HRESULT MakePage([NativeTypeName("UINT32")] uint desiredJobPage, float width, float height);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintPreviewPageCollection*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintPreviewPageCollection*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintPreviewPageCollection*, uint> Release;

        [NativeTypeName("HRESULT (UINT32, IInspectable *) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintPreviewPageCollection*, uint, IInspectable*, int> Paginate;

        [NativeTypeName("HRESULT (UINT32, FLOAT, FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged<IPrintPreviewPageCollection*, uint, float, float, int> MakePage;
    }
}
