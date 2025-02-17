// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes"]/*' />
[Guid("2CD2D921-C447-44A7-A13C-4ADABFC247E3")]
[NativeTypeName("struct IMFAttributes : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFAttributes : IMFAttributes.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFAttributes));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, void**, int>)(lpVtbl[0]))((IMFAttributes*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFAttributes*, uint>)(lpVtbl[1]))((IMFAttributes*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFAttributes*, uint>)(lpVtbl[2]))((IMFAttributes*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetItem([NativeTypeName("const GUID &")] Guid* guidKey, PROPVARIANT* pValue)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, PROPVARIANT*, int>)(lpVtbl[3]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pValue);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetItemType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, MF_ATTRIBUTE_TYPE* pType)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, MF_ATTRIBUTE_TYPE*, int>)(lpVtbl[4]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pType);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.CompareItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, BOOL* pbResult)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, PROPVARIANT*, BOOL*, int>)(lpVtbl[5]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, Value, pbResult);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.Compare"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Compare(IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL* pbResult)
    {
        return ((delegate* unmanaged<IMFAttributes*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int>)(lpVtbl[6]))((IMFAttributes*)Unsafe.AsPointer(ref this), pTheirs, MatchType, pbResult);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetUINT32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, uint*, int>)(lpVtbl[7]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, punValue);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetUINT64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, ulong*, int>)(lpVtbl[8]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, punValue);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetDouble"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double* pfValue)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, double*, int>)(lpVtbl[9]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pfValue);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetGUID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, Guid* pguidValue)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, Guid*, int>)(lpVtbl[10]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pguidValue);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetStringLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, uint*, int>)(lpVtbl[11]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pcchLength);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, ushort*, uint, uint*, int>)(lpVtbl[12]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pwszValue, cchBufSize, pcchLength);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetAllocatedString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, ushort**, uint*, int>)(lpVtbl[13]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, ppwszValue, pcchLength);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetBlobSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, uint*, int>)(lpVtbl[14]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pcbBlobSize);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, byte*, uint, uint*, int>)(lpVtbl[15]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize, pcbBlobSize);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetAllocatedBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, byte**, uint*, int>)(lpVtbl[16]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, ppBuf, pcbSize);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetUnknown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, Guid*, void**, int>)(lpVtbl[17]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, riid, ppv);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.SetItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, PROPVARIANT*, int>)(lpVtbl[18]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, Value);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.DeleteItem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, int>)(lpVtbl[19]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.DeleteAllItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT DeleteAllItems()
    {
        return ((delegate* unmanaged<IMFAttributes*, int>)(lpVtbl[20]))((IMFAttributes*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.SetUINT32"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, uint, int>)(lpVtbl[21]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, unValue);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.SetUINT64"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, ulong, int>)(lpVtbl[22]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, unValue);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.SetDouble"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, double, int>)(lpVtbl[23]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, fValue);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.SetGUID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, Guid*, int>)(lpVtbl[24]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, guidValue);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.SetString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, ushort*, int>)(lpVtbl[25]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, wszValue);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.SetBlob"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, byte*, uint, int>)(lpVtbl[26]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pBuf, cbBufSize);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.SetUnknown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, IUnknown* pUnknown)
    {
        return ((delegate* unmanaged<IMFAttributes*, Guid*, IUnknown*, int>)(lpVtbl[27]))((IMFAttributes*)Unsafe.AsPointer(ref this), guidKey, pUnknown);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.LockStore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT LockStore()
    {
        return ((delegate* unmanaged<IMFAttributes*, int>)(lpVtbl[28]))((IMFAttributes*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.UnlockStore"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT UnlockStore()
    {
        return ((delegate* unmanaged<IMFAttributes*, int>)(lpVtbl[29]))((IMFAttributes*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetCount([NativeTypeName("UINT32 *")] uint* pcItems)
    {
        return ((delegate* unmanaged<IMFAttributes*, uint*, int>)(lpVtbl[30]))((IMFAttributes*)Unsafe.AsPointer(ref this), pcItems);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.GetItemByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, Guid* pguidKey, PROPVARIANT* pValue)
    {
        return ((delegate* unmanaged<IMFAttributes*, uint, Guid*, PROPVARIANT*, int>)(lpVtbl[31]))((IMFAttributes*)Unsafe.AsPointer(ref this), unIndex, pguidKey, pValue);
    }

    /// <include file='IMFAttributes.xml' path='doc/member[@name="IMFAttributes.CopyAllItems"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT CopyAllItems(IMFAttributes* pDest)
    {
        return ((delegate* unmanaged<IMFAttributes*, IMFAttributes*, int>)(lpVtbl[32]))((IMFAttributes*)Unsafe.AsPointer(ref this), pDest);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetItem([NativeTypeName("const GUID &")] Guid* guidKey, PROPVARIANT* pValue);

        [VtblIndex(4)]
        HRESULT GetItemType([NativeTypeName("const GUID &")] Guid* guidKey, MF_ATTRIBUTE_TYPE* pType);

        [VtblIndex(5)]
        HRESULT CompareItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value, BOOL* pbResult);

        [VtblIndex(6)]
        HRESULT Compare(IMFAttributes* pTheirs, MF_ATTRIBUTES_MATCH_TYPE MatchType, BOOL* pbResult);

        [VtblIndex(7)]
        HRESULT GetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* punValue);

        [VtblIndex(8)]
        HRESULT GetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64 *")] ulong* punValue);

        [VtblIndex(9)]
        HRESULT GetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double* pfValue);

        [VtblIndex(10)]
        HRESULT GetGUID([NativeTypeName("const GUID &")] Guid* guidKey, Guid* pguidValue);

        [VtblIndex(11)]
        HRESULT GetStringLength([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcchLength);

        [VtblIndex(12)]
        HRESULT GetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR")] ushort* pwszValue, [NativeTypeName("UINT32")] uint cchBufSize, [NativeTypeName("UINT32 *")] uint* pcchLength);

        [VtblIndex(13)]
        HRESULT GetAllocatedString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPWSTR *")] ushort** ppwszValue, [NativeTypeName("UINT32 *")] uint* pcchLength);

        [VtblIndex(14)]
        HRESULT GetBlobSize([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32 *")] uint* pcbBlobSize);

        [VtblIndex(15)]
        HRESULT GetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize, [NativeTypeName("UINT32 *")] uint* pcbBlobSize);

        [VtblIndex(16)]
        HRESULT GetAllocatedBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT8 **")] byte** ppBuf, [NativeTypeName("UINT32 *")] uint* pcbSize);

        [VtblIndex(17)]
        HRESULT GetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [VtblIndex(18)]
        HRESULT SetItem([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* Value);

        [VtblIndex(19)]
        HRESULT DeleteItem([NativeTypeName("const GUID &")] Guid* guidKey);

        [VtblIndex(20)]
        HRESULT DeleteAllItems();

        [VtblIndex(21)]
        HRESULT SetUINT32([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT32")] uint unValue);

        [VtblIndex(22)]
        HRESULT SetUINT64([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("UINT64")] ulong unValue);

        [VtblIndex(23)]
        HRESULT SetDouble([NativeTypeName("const GUID &")] Guid* guidKey, double fValue);

        [VtblIndex(24)]
        HRESULT SetGUID([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const GUID &")] Guid* guidValue);

        [VtblIndex(25)]
        HRESULT SetString([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("LPCWSTR")] ushort* wszValue);

        [VtblIndex(26)]
        HRESULT SetBlob([NativeTypeName("const GUID &")] Guid* guidKey, [NativeTypeName("const UINT8 *")] byte* pBuf, [NativeTypeName("UINT32")] uint cbBufSize);

        [VtblIndex(27)]
        HRESULT SetUnknown([NativeTypeName("const GUID &")] Guid* guidKey, IUnknown* pUnknown);

        [VtblIndex(28)]
        HRESULT LockStore();

        [VtblIndex(29)]
        HRESULT UnlockStore();

        [VtblIndex(30)]
        HRESULT GetCount([NativeTypeName("UINT32 *")] uint* pcItems);

        [VtblIndex(31)]
        HRESULT GetItemByIndex([NativeTypeName("UINT32")] uint unIndex, Guid* pguidKey, PROPVARIANT* pValue);

        [VtblIndex(32)]
        HRESULT CopyAllItems(IMFAttributes* pDest);
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

        [NativeTypeName("HRESULT (const GUID &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> GetItem;

        [NativeTypeName("HRESULT (const GUID &, MF_ATTRIBUTE_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, MF_ATTRIBUTE_TYPE*, int> GetItemType;

        [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, BOOL*, int> CompareItem;

        [NativeTypeName("HRESULT (IMFAttributes *, MF_ATTRIBUTES_MATCH_TYPE, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, MF_ATTRIBUTES_MATCH_TYPE, BOOL*, int> Compare;

        [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetUINT32;

        [NativeTypeName("HRESULT (const GUID &, UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ulong*, int> GetUINT64;

        [NativeTypeName("HRESULT (const GUID &, double *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, double*, int> GetDouble;

        [NativeTypeName("HRESULT (const GUID &, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> GetGUID;

        [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetStringLength;

        [NativeTypeName("HRESULT (const GUID &, LPWSTR, UINT32, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, uint, uint*, int> GetString;

        [NativeTypeName("HRESULT (const GUID &, LPWSTR *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint*, int> GetAllocatedString;

        [NativeTypeName("HRESULT (const GUID &, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetBlobSize;

        [NativeTypeName("HRESULT (const GUID &, UINT8 *, UINT32, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte*, uint, uint*, int> GetBlob;

        [NativeTypeName("HRESULT (const GUID &, UINT8 **, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte**, uint*, int> GetAllocatedBlob;

        [NativeTypeName("HRESULT (const GUID &, const IID &, LPVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> GetUnknown;

        [NativeTypeName("HRESULT (const GUID &, const PROPVARIANT &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPVARIANT*, int> SetItem;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> DeleteItem;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DeleteAllItems;

        [NativeTypeName("HRESULT (const GUID &, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, int> SetUINT32;

        [NativeTypeName("HRESULT (const GUID &, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ulong, int> SetUINT64;

        [NativeTypeName("HRESULT (const GUID &, double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, double, int> SetDouble;

        [NativeTypeName("HRESULT (const GUID &, const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, int> SetGUID;

        [NativeTypeName("HRESULT (const GUID &, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, int> SetString;

        [NativeTypeName("HRESULT (const GUID &, const UINT8 *, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, byte*, uint, int> SetBlob;

        [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetUnknown;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> LockStore;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnlockStore;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (UINT32, GUID *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, PROPVARIANT*, int> GetItemByIndex;

        [NativeTypeName("HRESULT (IMFAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAttributes*, int> CopyAllItems;
    }
}
