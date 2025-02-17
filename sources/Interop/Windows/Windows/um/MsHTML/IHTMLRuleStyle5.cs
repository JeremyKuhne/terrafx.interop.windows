// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLRuleStyle5.xml' path='doc/member[@name="IHTMLRuleStyle5"]/*' />
[Guid("3050F335-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLRuleStyle5 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLRuleStyle5 : IHTMLRuleStyle5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLRuleStyle5));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, uint>)(lpVtbl[1]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, uint>)(lpVtbl[2]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, uint*, int>)(lpVtbl[3]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLRuleStyle5.xml' path='doc/member[@name="IHTMLRuleStyle5.put_msInterpolationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_msInterpolationMode([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, ushort*, int>)(lpVtbl[7]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle5.xml' path='doc/member[@name="IHTMLRuleStyle5.get_msInterpolationMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_msInterpolationMode([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, ushort**, int>)(lpVtbl[8]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle5.xml' path='doc/member[@name="IHTMLRuleStyle5.put_maxHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_maxHeight(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, VARIANT, int>)(lpVtbl[9]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle5.xml' path='doc/member[@name="IHTMLRuleStyle5.get_maxHeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_maxHeight(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, VARIANT*, int>)(lpVtbl[10]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle5.xml' path='doc/member[@name="IHTMLRuleStyle5.put_minWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_minWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, VARIANT, int>)(lpVtbl[11]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle5.xml' path='doc/member[@name="IHTMLRuleStyle5.get_minWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_minWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, VARIANT*, int>)(lpVtbl[12]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLRuleStyle5.xml' path='doc/member[@name="IHTMLRuleStyle5.put_maxWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_maxWidth(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, VARIANT, int>)(lpVtbl[13]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLRuleStyle5.xml' path='doc/member[@name="IHTMLRuleStyle5.get_maxWidth"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_maxWidth(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLRuleStyle5*, VARIANT*, int>)(lpVtbl[14]))((IHTMLRuleStyle5*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_msInterpolationMode([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(8)]
        HRESULT get_msInterpolationMode([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT put_maxHeight(VARIANT v);

        [VtblIndex(10)]
        HRESULT get_maxHeight(VARIANT* p);

        [VtblIndex(11)]
        HRESULT put_minWidth(VARIANT v);

        [VtblIndex(12)]
        HRESULT get_minWidth(VARIANT* p);

        [VtblIndex(13)]
        HRESULT put_maxWidth(VARIANT v);

        [VtblIndex(14)]
        HRESULT get_maxWidth(VARIANT* p);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_msInterpolationMode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_msInterpolationMode;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_maxHeight;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_maxHeight;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_minWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_minWidth;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_maxWidth;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_maxWidth;
    }
}
