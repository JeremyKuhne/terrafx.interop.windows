// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DispEx.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

[Guid("A6EF9860-C720-11D0-9337-00A0C90DCAA9")]
[NativeTypeName("struct IDispatchEx : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDispatchEx : IDispatch.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDispatchEx));

    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDispatchEx*, Guid*, void**, int>)(lpVtbl[0]))((IDispatchEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDispatchEx*, uint>)(lpVtbl[1]))((IDispatchEx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDispatchEx*, uint>)(lpVtbl[2]))((IDispatchEx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDispatchEx*, uint*, int>)(lpVtbl[3]))((IDispatchEx*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IDispatchEx*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IDispatchEx*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IDispatchEx*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IDispatchEx*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IDispatchEx*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IDispatchEx*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDispID([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID *")] int* pid)
    {
        return ((delegate* unmanaged<IDispatchEx*, ushort*, uint, int*, int>)(lpVtbl[7]))((IDispatchEx*)Unsafe.AsPointer(ref this), bstrName, grfdex, pid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT InvokeEx([NativeTypeName("DISPID")] int id, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pdp, VARIANT* pvarRes, EXCEPINFO* pei, IServiceProvider* pspCaller)
    {
        return ((delegate* unmanaged<IDispatchEx*, int, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, IServiceProvider*, int>)(lpVtbl[8]))((IDispatchEx*)Unsafe.AsPointer(ref this), id, lcid, wFlags, pdp, pvarRes, pei, pspCaller);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DeleteMemberByName([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex)
    {
        return ((delegate* unmanaged<IDispatchEx*, ushort*, uint, int>)(lpVtbl[9]))((IDispatchEx*)Unsafe.AsPointer(ref this), bstrName, grfdex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DeleteMemberByDispID([NativeTypeName("DISPID")] int id)
    {
        return ((delegate* unmanaged<IDispatchEx*, int, int>)(lpVtbl[10]))((IDispatchEx*)Unsafe.AsPointer(ref this), id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMemberProperties([NativeTypeName("DISPID")] int id, [NativeTypeName("DWORD")] uint grfdexFetch, [NativeTypeName("DWORD *")] uint* pgrfdex)
    {
        return ((delegate* unmanaged<IDispatchEx*, int, uint, uint*, int>)(lpVtbl[11]))((IDispatchEx*)Unsafe.AsPointer(ref this), id, grfdexFetch, pgrfdex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetMemberName([NativeTypeName("DISPID")] int id, [NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IDispatchEx*, int, ushort**, int>)(lpVtbl[12]))((IDispatchEx*)Unsafe.AsPointer(ref this), id, pbstrName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetNextDispID([NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID")] int id, [NativeTypeName("DISPID *")] int* pid)
    {
        return ((delegate* unmanaged<IDispatchEx*, uint, int, int*, int>)(lpVtbl[13]))((IDispatchEx*)Unsafe.AsPointer(ref this), grfdex, id, pid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetNameSpaceParent(IUnknown** ppunk)
    {
        return ((delegate* unmanaged<IDispatchEx*, IUnknown**, int>)(lpVtbl[14]))((IDispatchEx*)Unsafe.AsPointer(ref this), ppunk);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT GetDispID([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID *")] int* pid);

        [VtblIndex(8)]
        HRESULT InvokeEx([NativeTypeName("DISPID")] int id, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pdp, VARIANT* pvarRes, EXCEPINFO* pei, IServiceProvider* pspCaller);

        [VtblIndex(9)]
        HRESULT DeleteMemberByName([NativeTypeName("BSTR")] ushort* bstrName, [NativeTypeName("DWORD")] uint grfdex);

        [VtblIndex(10)]
        HRESULT DeleteMemberByDispID([NativeTypeName("DISPID")] int id);

        [VtblIndex(11)]
        HRESULT GetMemberProperties([NativeTypeName("DISPID")] int id, [NativeTypeName("DWORD")] uint grfdexFetch, [NativeTypeName("DWORD *")] uint* pgrfdex);

        [VtblIndex(12)]
        HRESULT GetMemberName([NativeTypeName("DISPID")] int id, [NativeTypeName("BSTR *")] ushort** pbstrName);

        [VtblIndex(13)]
        HRESULT GetNextDispID([NativeTypeName("DWORD")] uint grfdex, [NativeTypeName("DISPID")] int id, [NativeTypeName("DISPID *")] int* pid);

        [VtblIndex(14)]
        HRESULT GetNameSpaceParent(IUnknown** ppunk);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (BSTR, DWORD, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, ushort*, uint, int*, int> GetDispID;

        [NativeTypeName("HRESULT (DISPID, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, IServiceProvider *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, int, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, IServiceProvider*, int> InvokeEx;

        [NativeTypeName("HRESULT (BSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, ushort*, uint, int> DeleteMemberByName;

        [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, int, int> DeleteMemberByDispID;

        [NativeTypeName("HRESULT (DISPID, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, int, uint, uint*, int> GetMemberProperties;

        [NativeTypeName("HRESULT (DISPID, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, int, ushort**, int> GetMemberName;

        [NativeTypeName("HRESULT (DWORD, DISPID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, uint, int, int*, int> GetNextDispID;

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDispatchEx*, IUnknown**, int> GetNameSpaceParent;
    }
}
