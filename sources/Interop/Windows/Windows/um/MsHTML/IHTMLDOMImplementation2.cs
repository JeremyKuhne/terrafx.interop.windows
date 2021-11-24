// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("3051073C-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDOMImplementation2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDOMImplementation2 : IHTMLDOMImplementation2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLDOMImplementation2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2*, uint>)(lpVtbl[1]))((IHTMLDOMImplementation2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2*, uint>)(lpVtbl[2]))((IHTMLDOMImplementation2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2*, uint*, int>)(lpVtbl[3]))((IHTMLDOMImplementation2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLDOMImplementation2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLDOMImplementation2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLDOMImplementation2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT createDocumentType([NativeTypeName("BSTR")] ushort* bstrQualifiedName, VARIANT* pvarPublicId, VARIANT* pvarSystemId, IDOMDocumentType** newDocumentType)
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2*, ushort*, VARIANT*, VARIANT*, IDOMDocumentType**, int>)(lpVtbl[7]))((IHTMLDOMImplementation2*)Unsafe.AsPointer(ref this), bstrQualifiedName, pvarPublicId, pvarSystemId, newDocumentType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT createDocument(VARIANT* pvarNS, VARIANT* pvarTagName, IDOMDocumentType* pDocumentType, IHTMLDocument7** ppnewDocument)
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2*, VARIANT*, VARIANT*, IDOMDocumentType*, IHTMLDocument7**, int>)(lpVtbl[8]))((IHTMLDOMImplementation2*)Unsafe.AsPointer(ref this), pvarNS, pvarTagName, pDocumentType, ppnewDocument);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT createHTMLDocument([NativeTypeName("BSTR")] ushort* bstrTitle, IHTMLDocument7** ppnewDocument)
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2*, ushort*, IHTMLDocument7**, int>)(lpVtbl[9]))((IHTMLDOMImplementation2*)Unsafe.AsPointer(ref this), bstrTitle, ppnewDocument);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT hasFeature([NativeTypeName("BSTR")] ushort* bstrfeature, VARIANT version, [NativeTypeName("VARIANT_BOOL *")] short* pfHasFeature)
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2*, ushort*, VARIANT, short*, int>)(lpVtbl[10]))((IHTMLDOMImplementation2*)Unsafe.AsPointer(ref this), bstrfeature, version, pfHasFeature);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT createDocumentType([NativeTypeName("BSTR")] ushort* bstrQualifiedName, VARIANT* pvarPublicId, VARIANT* pvarSystemId, IDOMDocumentType** newDocumentType);

        [VtblIndex(8)]
        HRESULT createDocument(VARIANT* pvarNS, VARIANT* pvarTagName, IDOMDocumentType* pDocumentType, IHTMLDocument7** ppnewDocument);

        [VtblIndex(9)]
        HRESULT createHTMLDocument([NativeTypeName("BSTR")] ushort* bstrTitle, IHTMLDocument7** ppnewDocument);

        [VtblIndex(10)]
        HRESULT hasFeature([NativeTypeName("BSTR")] ushort* bstrfeature, VARIANT version, [NativeTypeName("VARIANT_BOOL *")] short* pfHasFeature);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLDOMImplementation2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLDOMImplementation2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLDOMImplementation2*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLDOMImplementation2*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLDOMImplementation2*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLDOMImplementation2*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLDOMImplementation2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (BSTR, VARIANT *, VARIANT *, IDOMDocumentType **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLDOMImplementation2*, ushort*, VARIANT*, VARIANT*, IDOMDocumentType**, int> createDocumentType;

        [NativeTypeName("HRESULT (VARIANT *, VARIANT *, IDOMDocumentType *, IHTMLDocument7 **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLDOMImplementation2*, VARIANT*, VARIANT*, IDOMDocumentType*, IHTMLDocument7**, int> createDocument;

        [NativeTypeName("HRESULT (BSTR, IHTMLDocument7 **) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLDOMImplementation2*, ushort*, IHTMLDocument7**, int> createHTMLDocument;

        [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IHTMLDOMImplementation2*, ushort*, VARIANT, short*, int> hasFeature;
    }
}
