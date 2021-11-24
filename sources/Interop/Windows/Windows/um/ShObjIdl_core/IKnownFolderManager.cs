// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("8BE2D872-86AA-4D47-B776-32CCA40C7018")]
[NativeTypeName("struct IKnownFolderManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IKnownFolderManager : IKnownFolderManager.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IKnownFolderManager*, Guid*, void**, int>)(lpVtbl[0]))((IKnownFolderManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IKnownFolderManager*, uint>)(lpVtbl[1]))((IKnownFolderManager*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IKnownFolderManager*, uint>)(lpVtbl[2]))((IKnownFolderManager*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FolderIdFromCsidl(int nCsidl, [NativeTypeName("KNOWNFOLDERID *")] Guid* pfid)
    {
        return ((delegate* unmanaged<IKnownFolderManager*, int, Guid*, int>)(lpVtbl[3]))((IKnownFolderManager*)Unsafe.AsPointer(ref this), nCsidl, pfid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT FolderIdToCsidl([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, int* pnCsidl)
    {
        return ((delegate* unmanaged<IKnownFolderManager*, Guid*, int*, int>)(lpVtbl[4]))((IKnownFolderManager*)Unsafe.AsPointer(ref this), rfid, pnCsidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetFolderIds([NativeTypeName("KNOWNFOLDERID **")] Guid** ppKFId, uint* pCount)
    {
        return ((delegate* unmanaged<IKnownFolderManager*, Guid**, uint*, int>)(lpVtbl[5]))((IKnownFolderManager*)Unsafe.AsPointer(ref this), ppKFId, pCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, IKnownFolder** ppkf)
    {
        return ((delegate* unmanaged<IKnownFolderManager*, Guid*, IKnownFolder**, int>)(lpVtbl[6]))((IKnownFolderManager*)Unsafe.AsPointer(ref this), rfid, ppkf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFolderByName([NativeTypeName("LPCWSTR")] ushort* pszCanonicalName, IKnownFolder** ppkf)
    {
        return ((delegate* unmanaged<IKnownFolderManager*, ushort*, IKnownFolder**, int>)(lpVtbl[7]))((IKnownFolderManager*)Unsafe.AsPointer(ref this), pszCanonicalName, ppkf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RegisterFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, [NativeTypeName("const KNOWNFOLDER_DEFINITION *")] KNOWNFOLDER_DEFINITION* pKFD)
    {
        return ((delegate* unmanaged<IKnownFolderManager*, Guid*, KNOWNFOLDER_DEFINITION*, int>)(lpVtbl[8]))((IKnownFolderManager*)Unsafe.AsPointer(ref this), rfid, pKFD);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UnregisterFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid)
    {
        return ((delegate* unmanaged<IKnownFolderManager*, Guid*, int>)(lpVtbl[9]))((IKnownFolderManager*)Unsafe.AsPointer(ref this), rfid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT FindFolderFromPath([NativeTypeName("LPCWSTR")] ushort* pszPath, FFFP_MODE mode, IKnownFolder** ppkf)
    {
        return ((delegate* unmanaged<IKnownFolderManager*, ushort*, FFFP_MODE, IKnownFolder**, int>)(lpVtbl[10]))((IKnownFolderManager*)Unsafe.AsPointer(ref this), pszPath, mode, ppkf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FindFolderFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IKnownFolder** ppkf)
    {
        return ((delegate* unmanaged<IKnownFolderManager*, ITEMIDLIST*, IKnownFolder**, int>)(lpVtbl[11]))((IKnownFolderManager*)Unsafe.AsPointer(ref this), pidl, ppkf);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Redirect([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, HWND hwnd, [NativeTypeName("KF_REDIRECT_FLAGS")] uint flags, [NativeTypeName("LPCWSTR")] ushort* pszTargetPath, uint cFolders, [NativeTypeName("const KNOWNFOLDERID *")] Guid* pExclusion, [NativeTypeName("LPWSTR *")] ushort** ppszError)
    {
        return ((delegate* unmanaged<IKnownFolderManager*, Guid*, HWND, uint, ushort*, uint, Guid*, ushort**, int>)(lpVtbl[12]))((IKnownFolderManager*)Unsafe.AsPointer(ref this), rfid, hwnd, flags, pszTargetPath, cFolders, pExclusion, ppszError);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FolderIdFromCsidl(int nCsidl, [NativeTypeName("KNOWNFOLDERID *")] Guid* pfid);

        [VtblIndex(4)]
        HRESULT FolderIdToCsidl([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, int* pnCsidl);

        [VtblIndex(5)]
        HRESULT GetFolderIds([NativeTypeName("KNOWNFOLDERID **")] Guid** ppKFId, uint* pCount);

        [VtblIndex(6)]
        HRESULT GetFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, IKnownFolder** ppkf);

        [VtblIndex(7)]
        HRESULT GetFolderByName([NativeTypeName("LPCWSTR")] ushort* pszCanonicalName, IKnownFolder** ppkf);

        [VtblIndex(8)]
        HRESULT RegisterFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, [NativeTypeName("const KNOWNFOLDER_DEFINITION *")] KNOWNFOLDER_DEFINITION* pKFD);

        [VtblIndex(9)]
        HRESULT UnregisterFolder([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid);

        [VtblIndex(10)]
        HRESULT FindFolderFromPath([NativeTypeName("LPCWSTR")] ushort* pszPath, FFFP_MODE mode, IKnownFolder** ppkf);

        [VtblIndex(11)]
        HRESULT FindFolderFromIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, IKnownFolder** ppkf);

        [VtblIndex(12)]
        HRESULT Redirect([NativeTypeName("const KNOWNFOLDERID &")] Guid* rfid, HWND hwnd, [NativeTypeName("KF_REDIRECT_FLAGS")] uint flags, [NativeTypeName("LPCWSTR")] ushort* pszTargetPath, uint cFolders, [NativeTypeName("const KNOWNFOLDERID *")] Guid* pExclusion, [NativeTypeName("LPWSTR *")] ushort** ppszError);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IKnownFolderManager*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IKnownFolderManager*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IKnownFolderManager*, uint> Release;

        [NativeTypeName("HRESULT (int, KNOWNFOLDERID *) __attribute__((stdcall))")]
        public delegate* unmanaged<IKnownFolderManager*, int, Guid*, int> FolderIdFromCsidl;

        [NativeTypeName("HRESULT (const KNOWNFOLDERID &, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<IKnownFolderManager*, Guid*, int*, int> FolderIdToCsidl;

        [NativeTypeName("HRESULT (KNOWNFOLDERID **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IKnownFolderManager*, Guid**, uint*, int> GetFolderIds;

        [NativeTypeName("HRESULT (const KNOWNFOLDERID &, IKnownFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged<IKnownFolderManager*, Guid*, IKnownFolder**, int> GetFolder;

        [NativeTypeName("HRESULT (LPCWSTR, IKnownFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged<IKnownFolderManager*, ushort*, IKnownFolder**, int> GetFolderByName;

        [NativeTypeName("HRESULT (const KNOWNFOLDERID &, const KNOWNFOLDER_DEFINITION *) __attribute__((stdcall))")]
        public delegate* unmanaged<IKnownFolderManager*, Guid*, KNOWNFOLDER_DEFINITION*, int> RegisterFolder;

        [NativeTypeName("HRESULT (const KNOWNFOLDERID &) __attribute__((stdcall))")]
        public delegate* unmanaged<IKnownFolderManager*, Guid*, int> UnregisterFolder;

        [NativeTypeName("HRESULT (LPCWSTR, FFFP_MODE, IKnownFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged<IKnownFolderManager*, ushort*, FFFP_MODE, IKnownFolder**, int> FindFolderFromPath;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, IKnownFolder **) __attribute__((stdcall))")]
        public delegate* unmanaged<IKnownFolderManager*, ITEMIDLIST*, IKnownFolder**, int> FindFolderFromIDList;

        [NativeTypeName("HRESULT (const KNOWNFOLDERID &, HWND, KF_REDIRECT_FLAGS, LPCWSTR, UINT, const KNOWNFOLDERID *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IKnownFolderManager*, Guid*, HWND, uint, ushort*, uint, Guid*, ushort**, int> Redirect;
    }
}
