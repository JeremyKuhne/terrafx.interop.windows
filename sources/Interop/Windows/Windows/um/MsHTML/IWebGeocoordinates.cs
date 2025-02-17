// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWebGeocoordinates.xml' path='doc/member[@name="IWebGeocoordinates"]/*' />
[Guid("305107C7-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IWebGeocoordinates : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IWebGeocoordinates : IWebGeocoordinates.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebGeocoordinates));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, Guid*, void**, int>)(lpVtbl[0]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, uint>)(lpVtbl[1]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, uint>)(lpVtbl[2]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, uint*, int>)(lpVtbl[3]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IWebGeocoordinates.xml' path='doc/member[@name="IWebGeocoordinates.get_latitude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_latitude(double* p)
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, double*, int>)(lpVtbl[7]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IWebGeocoordinates.xml' path='doc/member[@name="IWebGeocoordinates.get_longitude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_longitude(double* p)
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, double*, int>)(lpVtbl[8]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IWebGeocoordinates.xml' path='doc/member[@name="IWebGeocoordinates.get_altitude"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_altitude(VARIANT* p)
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, VARIANT*, int>)(lpVtbl[9]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IWebGeocoordinates.xml' path='doc/member[@name="IWebGeocoordinates.get_accuracy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_accuracy(double* p)
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, double*, int>)(lpVtbl[10]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IWebGeocoordinates.xml' path='doc/member[@name="IWebGeocoordinates.get_altitudeAccuracy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_altitudeAccuracy(VARIANT* p)
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, VARIANT*, int>)(lpVtbl[11]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IWebGeocoordinates.xml' path='doc/member[@name="IWebGeocoordinates.get_heading"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_heading(VARIANT* p)
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, VARIANT*, int>)(lpVtbl[12]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IWebGeocoordinates.xml' path='doc/member[@name="IWebGeocoordinates.get_speed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_speed(VARIANT* p)
    {
        return ((delegate* unmanaged<IWebGeocoordinates*, VARIANT*, int>)(lpVtbl[13]))((IWebGeocoordinates*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_latitude(double* p);

        [VtblIndex(8)]
        HRESULT get_longitude(double* p);

        [VtblIndex(9)]
        HRESULT get_altitude(VARIANT* p);

        [VtblIndex(10)]
        HRESULT get_accuracy(double* p);

        [VtblIndex(11)]
        HRESULT get_altitudeAccuracy(VARIANT* p);

        [VtblIndex(12)]
        HRESULT get_heading(VARIANT* p);

        [VtblIndex(13)]
        HRESULT get_speed(VARIANT* p);
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

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_latitude;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_longitude;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_altitude;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_accuracy;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_altitudeAccuracy;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_heading;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_speed;
    }
}
