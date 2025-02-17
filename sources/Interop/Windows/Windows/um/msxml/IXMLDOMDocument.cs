// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument"]/*' />
[Guid("2933BF81-7B36-11D2-B20E-00C04F983E60")]
[NativeTypeName("struct IXMLDOMDocument : IXMLDOMNode")]
[NativeInheritance("IXMLDOMNode")]
public unsafe partial struct IXMLDOMDocument : IXMLDOMDocument.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXMLDOMDocument));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, uint>)(lpVtbl[1]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, uint>)(lpVtbl[2]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, uint*, int>)(lpVtbl[3]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_nodeName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_nodeName([NativeTypeName("BSTR *")] ushort** name)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[7]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_nodeValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_nodeValue(VARIANT* value)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT*, int>)(lpVtbl[8]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref="IXMLDOMNode.put_nodeValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_nodeValue(VARIANT value)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[9]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_nodeType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_nodeType(DOMNodeType* type)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, DOMNodeType*, int>)(lpVtbl[10]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), type);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_parentNode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_parentNode(IXMLDOMNode** parent)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[11]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), parent);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_childNodes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_childNodes(IXMLDOMNodeList** childList)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNodeList**, int>)(lpVtbl[12]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), childList);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_firstChild" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_firstChild(IXMLDOMNode** firstChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), firstChild);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_lastChild" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_lastChild(IXMLDOMNode** lastChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), lastChild);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_previousSibling" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_previousSibling(IXMLDOMNode** previousSibling)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[15]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), previousSibling);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_nextSibling" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_nextSibling(IXMLDOMNode** nextSibling)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[16]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nextSibling);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_attributes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_attributes(IXMLDOMNamedNodeMap** attributeMap)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNamedNodeMap**, int>)(lpVtbl[17]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), attributeMap);
    }

    /// <inheritdoc cref="IXMLDOMNode.insertBefore" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT insertBefore(IXMLDOMNode* newChild, VARIANT refChild, IXMLDOMNode** outNewChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int>)(lpVtbl[18]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
    }

    /// <inheritdoc cref="IXMLDOMNode.replaceChild" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT replaceChild(IXMLDOMNode* newChild, IXMLDOMNode* oldChild, IXMLDOMNode** outOldChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[19]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
    }

    /// <inheritdoc cref="IXMLDOMNode.removeChild" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT removeChild(IXMLDOMNode* childNode, IXMLDOMNode** oldChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[20]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), childNode, oldChild);
    }

    /// <inheritdoc cref="IXMLDOMNode.appendChild" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT appendChild(IXMLDOMNode* newChild, IXMLDOMNode** outNewChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[21]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), newChild, outNewChild);
    }

    /// <inheritdoc cref="IXMLDOMNode.hasChildNodes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[22]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), hasChild);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_ownerDocument" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_ownerDocument(IXMLDOMDocument** XMLDOMDocument)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMDocument**, int>)(lpVtbl[23]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), XMLDOMDocument);
    }

    /// <inheritdoc cref="IXMLDOMNode.cloneNode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, IXMLDOMNode** cloneRoot)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, short, IXMLDOMNode**, int>)(lpVtbl[24]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), deep, cloneRoot);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_nodeTypeString" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[25]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nodeType);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_text" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_text([NativeTypeName("BSTR *")] ushort** text)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[26]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), text);
    }

    /// <inheritdoc cref="IXMLDOMNode.put_text" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT put_text([NativeTypeName("BSTR")] ushort* text)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, int>)(lpVtbl[27]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), text);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_specified" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[28]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isSpecified);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_definition" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT get_definition(IXMLDOMNode** definitionNode)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode**, int>)(lpVtbl[29]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), definitionNode);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_nodeTypedValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT get_nodeTypedValue(VARIANT* typedValue)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT*, int>)(lpVtbl[30]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), typedValue);
    }

    /// <inheritdoc cref="IXMLDOMNode.put_nodeTypedValue" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT put_nodeTypedValue(VARIANT typedValue)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[31]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), typedValue);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_dataType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT get_dataType(VARIANT* dataTypeName)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT*, int>)(lpVtbl[32]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dataTypeName);
    }

    /// <inheritdoc cref="IXMLDOMNode.put_dataType" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, int>)(lpVtbl[33]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), dataTypeName);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_xml" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[34]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), xmlString);
    }

    /// <inheritdoc cref="IXMLDOMNode.transformNode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT transformNode(IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode*, ushort**, int>)(lpVtbl[35]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
    }

    /// <inheritdoc cref="IXMLDOMNode.selectNodes" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT selectNodes([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNodeList** resultList)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[36]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), queryString, resultList);
    }

    /// <inheritdoc cref="IXMLDOMNode.selectSingleNode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, IXMLDOMNode** resultNode)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMNode**, int>)(lpVtbl[37]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), queryString, resultNode);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_parsed" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[38]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isParsed);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_namespaceURI" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[39]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), namespaceURI);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_prefix" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[40]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), prefixString);
    }

    /// <inheritdoc cref="IXMLDOMNode.get_baseName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[41]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), nameString);
    }

    /// <inheritdoc cref="IXMLDOMNode.transformNodeToObject" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT transformNodeToObject(IXMLDOMNode* stylesheet, VARIANT outputObject)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMNode*, VARIANT, int>)(lpVtbl[42]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.get_doctype"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT get_doctype(IXMLDOMDocumentType** documentType)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMDocumentType**, int>)(lpVtbl[43]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), documentType);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.get_implementation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT get_implementation(IXMLDOMImplementation** impl)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMImplementation**, int>)(lpVtbl[44]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), impl);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.get_documentElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT get_documentElement(IXMLDOMElement** DOMElement)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMElement**, int>)(lpVtbl[45]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), DOMElement);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.putref_documentElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT putref_documentElement(IXMLDOMElement* DOMElement)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMElement*, int>)(lpVtbl[46]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), DOMElement);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.createElement"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT createElement([NativeTypeName("BSTR")] ushort* tagName, IXMLDOMElement** element)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMElement**, int>)(lpVtbl[47]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), tagName, element);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.createDocumentFragment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT createDocumentFragment(IXMLDOMDocumentFragment** docFrag)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMDocumentFragment**, int>)(lpVtbl[48]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), docFrag);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.createTextNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT createTextNode([NativeTypeName("BSTR")] ushort* data, IXMLDOMText** text)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMText**, int>)(lpVtbl[49]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, text);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.createComment"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT createComment([NativeTypeName("BSTR")] ushort* data, IXMLDOMComment** comment)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMComment**, int>)(lpVtbl[50]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, comment);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.createCDATASection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT createCDATASection([NativeTypeName("BSTR")] ushort* data, IXMLDOMCDATASection** cdata)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMCDATASection**, int>)(lpVtbl[51]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), data, cdata);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.createProcessingInstruction"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT createProcessingInstruction([NativeTypeName("BSTR")] ushort* target, [NativeTypeName("BSTR")] ushort* data, IXMLDOMProcessingInstruction** pi)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, ushort*, IXMLDOMProcessingInstruction**, int>)(lpVtbl[52]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), target, data, pi);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.createAttribute"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT createAttribute([NativeTypeName("BSTR")] ushort* name, IXMLDOMAttribute** attribute)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMAttribute**, int>)(lpVtbl[53]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name, attribute);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.createEntityReference"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT createEntityReference([NativeTypeName("BSTR")] ushort* name, IXMLDOMEntityReference** entityRef)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMEntityReference**, int>)(lpVtbl[54]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), name, entityRef);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.getElementsByTagName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT getElementsByTagName([NativeTypeName("BSTR")] ushort* tagName, IXMLDOMNodeList** resultList)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[55]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), tagName, resultList);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.createNode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT createNode(VARIANT Type, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* namespaceURI, IXMLDOMNode** node)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, ushort*, ushort*, IXMLDOMNode**, int>)(lpVtbl[56]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), Type, name, namespaceURI, node);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.nodeFromID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT nodeFromID([NativeTypeName("BSTR")] ushort* idString, IXMLDOMNode** node)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, IXMLDOMNode**, int>)(lpVtbl[57]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), idString, node);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.load"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT load(VARIANT xmlSource, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, short*, int>)(lpVtbl[58]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), xmlSource, isSuccessful);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.get_readyState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT get_readyState([NativeTypeName("long *")] int* value)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, int*, int>)(lpVtbl[59]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.get_parseError"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT get_parseError(IXMLDOMParseError** errorObj)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, IXMLDOMParseError**, int>)(lpVtbl[60]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), errorObj);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.get_url"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT get_url([NativeTypeName("BSTR *")] ushort** urlString)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort**, int>)(lpVtbl[61]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), urlString);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.get_async"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT get_async([NativeTypeName("VARIANT_BOOL *")] short* isAsync)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[62]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isAsync);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.put_async"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT put_async([NativeTypeName("VARIANT_BOOL")] short isAsync)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, short, int>)(lpVtbl[63]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isAsync);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.abort"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT abort()
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, int>)(lpVtbl[64]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.loadXML"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT loadXML([NativeTypeName("BSTR")] ushort* bstrXML, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, ushort*, short*, int>)(lpVtbl[65]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), bstrXML, isSuccessful);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.save"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT save(VARIANT destination)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[66]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), destination);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.get_validateOnParse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT get_validateOnParse([NativeTypeName("VARIANT_BOOL *")] short* isValidating)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[67]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isValidating);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.put_validateOnParse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT put_validateOnParse([NativeTypeName("VARIANT_BOOL")] short isValidating)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, short, int>)(lpVtbl[68]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isValidating);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.get_resolveExternals"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT get_resolveExternals([NativeTypeName("VARIANT_BOOL *")] short* isResolving)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[69]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isResolving);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.put_resolveExternals"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT put_resolveExternals([NativeTypeName("VARIANT_BOOL")] short isResolving)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, short, int>)(lpVtbl[70]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isResolving);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.get_preserveWhiteSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT get_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL *")] short* isPreserving)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, short*, int>)(lpVtbl[71]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isPreserving);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.put_preserveWhiteSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public HRESULT put_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL")] short isPreserving)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, short, int>)(lpVtbl[72]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), isPreserving);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.put_onreadystatechange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT put_onreadystatechange(VARIANT readystatechangeSink)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[73]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), readystatechangeSink);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.put_ondataavailable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT put_ondataavailable(VARIANT ondataavailableSink)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[74]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), ondataavailableSink);
    }

    /// <include file='IXMLDOMDocument.xml' path='doc/member[@name="IXMLDOMDocument.put_ontransformnode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT put_ontransformnode(VARIANT ontransformnodeSink)
    {
        return ((delegate* unmanaged<IXMLDOMDocument*, VARIANT, int>)(lpVtbl[75]))((IXMLDOMDocument*)Unsafe.AsPointer(ref this), ontransformnodeSink);
    }

    public interface Interface : IXMLDOMNode.Interface
    {
        [VtblIndex(43)]
        HRESULT get_doctype(IXMLDOMDocumentType** documentType);

        [VtblIndex(44)]
        HRESULT get_implementation(IXMLDOMImplementation** impl);

        [VtblIndex(45)]
        HRESULT get_documentElement(IXMLDOMElement** DOMElement);

        [VtblIndex(46)]
        HRESULT putref_documentElement(IXMLDOMElement* DOMElement);

        [VtblIndex(47)]
        HRESULT createElement([NativeTypeName("BSTR")] ushort* tagName, IXMLDOMElement** element);

        [VtblIndex(48)]
        HRESULT createDocumentFragment(IXMLDOMDocumentFragment** docFrag);

        [VtblIndex(49)]
        HRESULT createTextNode([NativeTypeName("BSTR")] ushort* data, IXMLDOMText** text);

        [VtblIndex(50)]
        HRESULT createComment([NativeTypeName("BSTR")] ushort* data, IXMLDOMComment** comment);

        [VtblIndex(51)]
        HRESULT createCDATASection([NativeTypeName("BSTR")] ushort* data, IXMLDOMCDATASection** cdata);

        [VtblIndex(52)]
        HRESULT createProcessingInstruction([NativeTypeName("BSTR")] ushort* target, [NativeTypeName("BSTR")] ushort* data, IXMLDOMProcessingInstruction** pi);

        [VtblIndex(53)]
        HRESULT createAttribute([NativeTypeName("BSTR")] ushort* name, IXMLDOMAttribute** attribute);

        [VtblIndex(54)]
        HRESULT createEntityReference([NativeTypeName("BSTR")] ushort* name, IXMLDOMEntityReference** entityRef);

        [VtblIndex(55)]
        HRESULT getElementsByTagName([NativeTypeName("BSTR")] ushort* tagName, IXMLDOMNodeList** resultList);

        [VtblIndex(56)]
        HRESULT createNode(VARIANT Type, [NativeTypeName("BSTR")] ushort* name, [NativeTypeName("BSTR")] ushort* namespaceURI, IXMLDOMNode** node);

        [VtblIndex(57)]
        HRESULT nodeFromID([NativeTypeName("BSTR")] ushort* idString, IXMLDOMNode** node);

        [VtblIndex(58)]
        HRESULT load(VARIANT xmlSource, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful);

        [VtblIndex(59)]
        HRESULT get_readyState([NativeTypeName("long *")] int* value);

        [VtblIndex(60)]
        HRESULT get_parseError(IXMLDOMParseError** errorObj);

        [VtblIndex(61)]
        HRESULT get_url([NativeTypeName("BSTR *")] ushort** urlString);

        [VtblIndex(62)]
        HRESULT get_async([NativeTypeName("VARIANT_BOOL *")] short* isAsync);

        [VtblIndex(63)]
        HRESULT put_async([NativeTypeName("VARIANT_BOOL")] short isAsync);

        [VtblIndex(64)]
        HRESULT abort();

        [VtblIndex(65)]
        HRESULT loadXML([NativeTypeName("BSTR")] ushort* bstrXML, [NativeTypeName("VARIANT_BOOL *")] short* isSuccessful);

        [VtblIndex(66)]
        HRESULT save(VARIANT destination);

        [VtblIndex(67)]
        HRESULT get_validateOnParse([NativeTypeName("VARIANT_BOOL *")] short* isValidating);

        [VtblIndex(68)]
        HRESULT put_validateOnParse([NativeTypeName("VARIANT_BOOL")] short isValidating);

        [VtblIndex(69)]
        HRESULT get_resolveExternals([NativeTypeName("VARIANT_BOOL *")] short* isResolving);

        [VtblIndex(70)]
        HRESULT put_resolveExternals([NativeTypeName("VARIANT_BOOL")] short isResolving);

        [VtblIndex(71)]
        HRESULT get_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL *")] short* isPreserving);

        [VtblIndex(72)]
        HRESULT put_preserveWhiteSpace([NativeTypeName("VARIANT_BOOL")] short isPreserving);

        [VtblIndex(73)]
        HRESULT put_onreadystatechange(VARIANT readystatechangeSink);

        [VtblIndex(74)]
        HRESULT put_ondataavailable(VARIANT ondataavailableSink);

        [VtblIndex(75)]
        HRESULT put_ontransformnode(VARIANT ontransformnodeSink);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_nodeName;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_nodeValue;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_nodeValue;

        [NativeTypeName("HRESULT (DOMNodeType *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DOMNodeType*, int> get_nodeType;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode**, int> get_parentNode;

        [NativeTypeName("HRESULT (IXMLDOMNodeList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNodeList**, int> get_childNodes;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode**, int> get_firstChild;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode**, int> get_lastChild;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode**, int> get_previousSibling;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode**, int> get_nextSibling;

        [NativeTypeName("HRESULT (IXMLDOMNamedNodeMap **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNamedNodeMap**, int> get_attributes;

        [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int> insertBefore;

        [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int> replaceChild;

        [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> removeChild;

        [NativeTypeName("HRESULT (IXMLDOMNode *, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, IXMLDOMNode**, int> appendChild;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> hasChildNodes;

        [NativeTypeName("HRESULT (IXMLDOMDocument **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMDocument**, int> get_ownerDocument;

        [NativeTypeName("HRESULT (VARIANT_BOOL, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, IXMLDOMNode**, int> cloneNode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_nodeTypeString;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_text;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_text;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_specified;

        [NativeTypeName("HRESULT (IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode**, int> get_definition;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_nodeTypedValue;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_nodeTypedValue;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_dataType;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_dataType;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_xml;

        [NativeTypeName("HRESULT (IXMLDOMNode *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, ushort**, int> transformNode;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMNodeList**, int> selectNodes;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMNode**, int> selectSingleNode;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_parsed;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_namespaceURI;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_prefix;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_baseName;

        [NativeTypeName("HRESULT (IXMLDOMNode *, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMNode*, VARIANT, int> transformNodeToObject;

        [NativeTypeName("HRESULT (IXMLDOMDocumentType **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMDocumentType**, int> get_doctype;

        [NativeTypeName("HRESULT (IXMLDOMImplementation **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMImplementation**, int> get_implementation;

        [NativeTypeName("HRESULT (IXMLDOMElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMElement**, int> get_documentElement;

        [NativeTypeName("HRESULT (IXMLDOMElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMElement*, int> putref_documentElement;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMElement**, int> createElement;

        [NativeTypeName("HRESULT (IXMLDOMDocumentFragment **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMDocumentFragment**, int> createDocumentFragment;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMText **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMText**, int> createTextNode;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMComment **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMComment**, int> createComment;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMCDATASection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMCDATASection**, int> createCDATASection;

        [NativeTypeName("HRESULT (BSTR, BSTR, IXMLDOMProcessingInstruction **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, IXMLDOMProcessingInstruction**, int> createProcessingInstruction;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMAttribute **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMAttribute**, int> createAttribute;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMEntityReference **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMEntityReference**, int> createEntityReference;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMNodeList **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMNodeList**, int> getElementsByTagName;

        [NativeTypeName("HRESULT (VARIANT, BSTR, BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, ushort*, ushort*, IXMLDOMNode**, int> createNode;

        [NativeTypeName("HRESULT (BSTR, IXMLDOMNode **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IXMLDOMNode**, int> nodeFromID;

        [NativeTypeName("HRESULT (VARIANT, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, short*, int> load;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_readyState;

        [NativeTypeName("HRESULT (IXMLDOMParseError **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IXMLDOMParseError**, int> get_parseError;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_url;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_async;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_async;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> abort;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> loadXML;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> save;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_validateOnParse;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_validateOnParse;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_resolveExternals;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_resolveExternals;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_preserveWhiteSpace;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_preserveWhiteSpace;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_onreadystatechange;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ondataavailable;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_ontransformnode;
    }
}
