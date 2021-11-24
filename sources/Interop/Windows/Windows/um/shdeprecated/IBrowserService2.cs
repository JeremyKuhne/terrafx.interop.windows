// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("68BD21CC-438B-11D2-A560-00A0C92DBFE8")]
[NativeTypeName("struct IBrowserService2 : IBrowserService")]
[NativeInheritance("IBrowserService")]
public unsafe partial struct IBrowserService2 : IBrowserService2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBrowserService2*, Guid*, void**, int>)(lpVtbl[0]))((IBrowserService2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBrowserService2*, uint>)(lpVtbl[1]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBrowserService2*, uint>)(lpVtbl[2]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetParentSite(IOleInPlaceSite** ppipsite)
    {
        return ((delegate* unmanaged<IBrowserService2*, IOleInPlaceSite**, int>)(lpVtbl[3]))((IBrowserService2*)Unsafe.AsPointer(ref this), ppipsite);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTitle(IShellView* psv, [NativeTypeName("LPCWSTR")] ushort* pszName)
    {
        return ((delegate* unmanaged<IBrowserService2*, IShellView*, ushort*, int>)(lpVtbl[4]))((IBrowserService2*)Unsafe.AsPointer(ref this), psv, pszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTitle(IShellView* psv, [NativeTypeName("LPWSTR")] ushort* pszName, [NativeTypeName("DWORD")] uint cchName)
    {
        return ((delegate* unmanaged<IBrowserService2*, IShellView*, ushort*, uint, int>)(lpVtbl[5]))((IBrowserService2*)Unsafe.AsPointer(ref this), psv, pszName, cchName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetOleObject(IOleObject** ppobjv)
    {
        return ((delegate* unmanaged<IBrowserService2*, IOleObject**, int>)(lpVtbl[6]))((IBrowserService2*)Unsafe.AsPointer(ref this), ppobjv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTravelLog(ITravelLog** pptl)
    {
        return ((delegate* unmanaged<IBrowserService2*, ITravelLog**, int>)(lpVtbl[7]))((IBrowserService2*)Unsafe.AsPointer(ref this), pptl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ShowControlWindow(uint id, BOOL fShow)
    {
        return ((delegate* unmanaged<IBrowserService2*, uint, BOOL, int>)(lpVtbl[8]))((IBrowserService2*)Unsafe.AsPointer(ref this), id, fShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsControlWindowShown(uint id, BOOL* pfShown)
    {
        return ((delegate* unmanaged<IBrowserService2*, uint, BOOL*, int>)(lpVtbl[9]))((IBrowserService2*)Unsafe.AsPointer(ref this), id, pfShown);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT IEGetDisplayName([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("LPWSTR")] ushort* pwszName, uint uFlags)
    {
        return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, ushort*, uint, int>)(lpVtbl[10]))((IBrowserService2*)Unsafe.AsPointer(ref this), pidl, pwszName, uFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT IEParseDisplayName(uint uiCP, [NativeTypeName("LPCWSTR")] ushort* pwszPath, [NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidlOut)
    {
        return ((delegate* unmanaged<IBrowserService2*, uint, ushort*, ITEMIDLIST**, int>)(lpVtbl[11]))((IBrowserService2*)Unsafe.AsPointer(ref this), uiCP, pwszPath, ppidlOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DisplayParseError(HRESULT hres, [NativeTypeName("LPCWSTR")] ushort* pwszPath)
    {
        return ((delegate* unmanaged<IBrowserService2*, HRESULT, ushort*, int>)(lpVtbl[12]))((IBrowserService2*)Unsafe.AsPointer(ref this), hres, pwszPath);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT NavigateToPidl([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfHLNF)
    {
        return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, uint, int>)(lpVtbl[13]))((IBrowserService2*)Unsafe.AsPointer(ref this), pidl, grfHLNF);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetNavigateState(BNSTATE bnstate)
    {
        return ((delegate* unmanaged<IBrowserService2*, BNSTATE, int>)(lpVtbl[14]))((IBrowserService2*)Unsafe.AsPointer(ref this), bnstate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetNavigateState(BNSTATE* pbnstate)
    {
        return ((delegate* unmanaged<IBrowserService2*, BNSTATE*, int>)(lpVtbl[15]))((IBrowserService2*)Unsafe.AsPointer(ref this), pbnstate);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT NotifyRedirect(IShellView* psv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, BOOL* pfDidBrowse)
    {
        return ((delegate* unmanaged<IBrowserService2*, IShellView*, ITEMIDLIST*, BOOL*, int>)(lpVtbl[16]))((IBrowserService2*)Unsafe.AsPointer(ref this), psv, pidl, pfDidBrowse);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT UpdateWindowList()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[17]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT UpdateBackForwardState()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[18]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SetFlags([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwFlagMask)
    {
        return ((delegate* unmanaged<IBrowserService2*, uint, uint, int>)(lpVtbl[19]))((IBrowserService2*)Unsafe.AsPointer(ref this), dwFlags, dwFlagMask);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IBrowserService2*, uint*, int>)(lpVtbl[20]))((IBrowserService2*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT CanNavigateNow()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[21]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetPidl([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST**, int>)(lpVtbl[22]))((IBrowserService2*)Unsafe.AsPointer(ref this), ppidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT SetReferrer([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, int>)(lpVtbl[23]))((IBrowserService2*)Unsafe.AsPointer(ref this), pidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    [return: NativeTypeName("DWORD")]
    public uint GetBrowserIndex()
    {
        return ((delegate* unmanaged<IBrowserService2*, uint>)(lpVtbl[24]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetBrowserByIndex([NativeTypeName("DWORD")] uint dwID, IUnknown** ppunk)
    {
        return ((delegate* unmanaged<IBrowserService2*, uint, IUnknown**, int>)(lpVtbl[25]))((IBrowserService2*)Unsafe.AsPointer(ref this), dwID, ppunk);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetHistoryObject(IOleObject** ppole, IStream** pstm, IBindCtx** ppbc)
    {
        return ((delegate* unmanaged<IBrowserService2*, IOleObject**, IStream**, IBindCtx**, int>)(lpVtbl[26]))((IBrowserService2*)Unsafe.AsPointer(ref this), ppole, pstm, ppbc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT SetHistoryObject(IOleObject* pole, BOOL fIsLocalAnchor)
    {
        return ((delegate* unmanaged<IBrowserService2*, IOleObject*, BOOL, int>)(lpVtbl[27]))((IBrowserService2*)Unsafe.AsPointer(ref this), pole, fIsLocalAnchor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT CacheOLEServer(IOleObject* pole)
    {
        return ((delegate* unmanaged<IBrowserService2*, IOleObject*, int>)(lpVtbl[28]))((IBrowserService2*)Unsafe.AsPointer(ref this), pole);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetSetCodePage(VARIANT* pvarIn, VARIANT* pvarOut)
    {
        return ((delegate* unmanaged<IBrowserService2*, VARIANT*, VARIANT*, int>)(lpVtbl[29]))((IBrowserService2*)Unsafe.AsPointer(ref this), pvarIn, pvarOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT OnHttpEquiv(IShellView* psv, BOOL fDone, VARIANT* pvarargIn, VARIANT* pvarargOut)
    {
        return ((delegate* unmanaged<IBrowserService2*, IShellView*, BOOL, VARIANT*, VARIANT*, int>)(lpVtbl[30]))((IBrowserService2*)Unsafe.AsPointer(ref this), psv, fDone, pvarargIn, pvarargOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetPalette(HPALETTE* hpal)
    {
        return ((delegate* unmanaged<IBrowserService2*, HPALETTE*, int>)(lpVtbl[31]))((IBrowserService2*)Unsafe.AsPointer(ref this), hpal);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT RegisterWindow(BOOL fForceRegister, int swc)
    {
        return ((delegate* unmanaged<IBrowserService2*, BOOL, int, int>)(lpVtbl[32]))((IBrowserService2*)Unsafe.AsPointer(ref this), fForceRegister, swc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public LRESULT WndProcBS(HWND hwnd, uint uMsg, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<IBrowserService2*, HWND, uint, WPARAM, LPARAM, nint>)(lpVtbl[33]))((IBrowserService2*)Unsafe.AsPointer(ref this), hwnd, uMsg, wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT SetAsDefFolderSettings()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[34]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetViewRect(RECT* prc)
    {
        return ((delegate* unmanaged<IBrowserService2*, RECT*, int>)(lpVtbl[35]))((IBrowserService2*)Unsafe.AsPointer(ref this), prc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT OnSize(WPARAM wParam)
    {
        return ((delegate* unmanaged<IBrowserService2*, WPARAM, int>)(lpVtbl[36]))((IBrowserService2*)Unsafe.AsPointer(ref this), wParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT OnCreate([NativeTypeName("struct tagCREATESTRUCTW *")] CREATESTRUCTW* pcs)
    {
        return ((delegate* unmanaged<IBrowserService2*, CREATESTRUCTW*, int>)(lpVtbl[37]))((IBrowserService2*)Unsafe.AsPointer(ref this), pcs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public LRESULT OnCommand(WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<IBrowserService2*, WPARAM, LPARAM, nint>)(lpVtbl[38]))((IBrowserService2*)Unsafe.AsPointer(ref this), wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT OnDestroy()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[39]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public LRESULT OnNotify([NativeTypeName("struct tagNMHDR *")] NMHDR* pnm)
    {
        return ((delegate* unmanaged<IBrowserService2*, NMHDR*, nint>)(lpVtbl[40]))((IBrowserService2*)Unsafe.AsPointer(ref this), pnm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT OnSetFocus()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[41]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT OnFrameWindowActivateBS(BOOL fActive)
    {
        return ((delegate* unmanaged<IBrowserService2*, BOOL, int>)(lpVtbl[42]))((IBrowserService2*)Unsafe.AsPointer(ref this), fActive);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT ReleaseShellView()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[43]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT ActivatePendingView()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[44]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT CreateViewWindow(IShellView* psvNew, IShellView* psvOld, [NativeTypeName("LPRECT")] RECT* prcView, HWND* phwnd)
    {
        return ((delegate* unmanaged<IBrowserService2*, IShellView*, IShellView*, RECT*, HWND*, int>)(lpVtbl[45]))((IBrowserService2*)Unsafe.AsPointer(ref this), psvNew, psvOld, prcView, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT CreateBrowserPropSheetExt([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IBrowserService2*, Guid*, void**, int>)(lpVtbl[46]))((IBrowserService2*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT GetViewWindow(HWND* phwndView)
    {
        return ((delegate* unmanaged<IBrowserService2*, HWND*, int>)(lpVtbl[47]))((IBrowserService2*)Unsafe.AsPointer(ref this), phwndView);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT GetBaseBrowserData([NativeTypeName("LPCBASEBROWSERDATA *")] BASEBROWSERDATA** pbbd)
    {
        return ((delegate* unmanaged<IBrowserService2*, BASEBROWSERDATA**, int>)(lpVtbl[48]))((IBrowserService2*)Unsafe.AsPointer(ref this), pbbd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    [return: NativeTypeName("LPBASEBROWSERDATA")]
    public BASEBROWSERDATA* PutBaseBrowserData()
    {
        return ((delegate* unmanaged<IBrowserService2*, BASEBROWSERDATA*>)(lpVtbl[49]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT InitializeTravelLog(ITravelLog* ptl, [NativeTypeName("DWORD")] uint dw)
    {
        return ((delegate* unmanaged<IBrowserService2*, ITravelLog*, uint, int>)(lpVtbl[50]))((IBrowserService2*)Unsafe.AsPointer(ref this), ptl, dw);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT SetTopBrowser()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[51]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT Offline(int iCmd)
    {
        return ((delegate* unmanaged<IBrowserService2*, int, int>)(lpVtbl[52]))((IBrowserService2*)Unsafe.AsPointer(ref this), iCmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT AllowViewResize(BOOL f)
    {
        return ((delegate* unmanaged<IBrowserService2*, BOOL, int>)(lpVtbl[53]))((IBrowserService2*)Unsafe.AsPointer(ref this), f);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT SetActivateState(uint u)
    {
        return ((delegate* unmanaged<IBrowserService2*, uint, int>)(lpVtbl[54]))((IBrowserService2*)Unsafe.AsPointer(ref this), u);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT UpdateSecureLockIcon(int eSecureLock)
    {
        return ((delegate* unmanaged<IBrowserService2*, int, int>)(lpVtbl[55]))((IBrowserService2*)Unsafe.AsPointer(ref this), eSecureLock);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(56)]
    public HRESULT InitializeDownloadManager()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[56]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(57)]
    public HRESULT InitializeTransitionSite()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[57]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(58)]
    public HRESULT _Initialize(HWND hwnd, IUnknown* pauto)
    {
        return ((delegate* unmanaged<IBrowserService2*, HWND, IUnknown*, int>)(lpVtbl[58]))((IBrowserService2*)Unsafe.AsPointer(ref this), hwnd, pauto);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(59)]
    public HRESULT _CancelPendingNavigationAsync()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[59]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(60)]
    public HRESULT _CancelPendingView()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[60]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(61)]
    public HRESULT _MaySaveChanges()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[61]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(62)]
    public HRESULT _PauseOrResumeView(BOOL fPaused)
    {
        return ((delegate* unmanaged<IBrowserService2*, BOOL, int>)(lpVtbl[62]))((IBrowserService2*)Unsafe.AsPointer(ref this), fPaused);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(63)]
    public HRESULT _DisableModeless()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[63]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(64)]
    public HRESULT _NavigateToPidl([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, uint, uint, int>)(lpVtbl[64]))((IBrowserService2*)Unsafe.AsPointer(ref this), pidl, grfHLNF, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(65)]
    public HRESULT _TryShell2Rename(IShellView* psv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlNew)
    {
        return ((delegate* unmanaged<IBrowserService2*, IShellView*, ITEMIDLIST*, int>)(lpVtbl[65]))((IBrowserService2*)Unsafe.AsPointer(ref this), psv, pidlNew);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(66)]
    public HRESULT _SwitchActivationNow()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[66]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(67)]
    public HRESULT _ExecChildren(IUnknown* punkBar, BOOL fBroadcast, [NativeTypeName("const GUID *")] Guid* pguidCmdGroup, [NativeTypeName("DWORD")] uint nCmdID, [NativeTypeName("DWORD")] uint nCmdexecopt, [NativeTypeName("VARIANTARG *")] VARIANT* pvarargIn, [NativeTypeName("VARIANTARG *")] VARIANT* pvarargOut)
    {
        return ((delegate* unmanaged<IBrowserService2*, IUnknown*, BOOL, Guid*, uint, uint, VARIANT*, VARIANT*, int>)(lpVtbl[67]))((IBrowserService2*)Unsafe.AsPointer(ref this), punkBar, fBroadcast, pguidCmdGroup, nCmdID, nCmdexecopt, pvarargIn, pvarargOut);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(68)]
    public HRESULT _SendChildren(HWND hwndBar, BOOL fBroadcast, uint uMsg, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<IBrowserService2*, HWND, BOOL, uint, WPARAM, LPARAM, int>)(lpVtbl[68]))((IBrowserService2*)Unsafe.AsPointer(ref this), hwndBar, fBroadcast, uMsg, wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(69)]
    public HRESULT GetFolderSetData([NativeTypeName("struct tagFolderSetData *")] FOLDERSETDATA* pfsd)
    {
        return ((delegate* unmanaged<IBrowserService2*, FOLDERSETDATA*, int>)(lpVtbl[69]))((IBrowserService2*)Unsafe.AsPointer(ref this), pfsd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(70)]
    public HRESULT _OnFocusChange(uint itb)
    {
        return ((delegate* unmanaged<IBrowserService2*, uint, int>)(lpVtbl[70]))((IBrowserService2*)Unsafe.AsPointer(ref this), itb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(71)]
    public HRESULT v_ShowHideChildWindows(BOOL fChildOnly)
    {
        return ((delegate* unmanaged<IBrowserService2*, BOOL, int>)(lpVtbl[71]))((IBrowserService2*)Unsafe.AsPointer(ref this), fChildOnly);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(72)]
    public uint _get_itbLastFocus()
    {
        return ((delegate* unmanaged<IBrowserService2*, uint>)(lpVtbl[72]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(73)]
    public HRESULT _put_itbLastFocus(uint itbLastFocus)
    {
        return ((delegate* unmanaged<IBrowserService2*, uint, int>)(lpVtbl[73]))((IBrowserService2*)Unsafe.AsPointer(ref this), itbLastFocus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(74)]
    public HRESULT _UIActivateView(uint uState)
    {
        return ((delegate* unmanaged<IBrowserService2*, uint, int>)(lpVtbl[74]))((IBrowserService2*)Unsafe.AsPointer(ref this), uState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(75)]
    public HRESULT _GetViewBorderRect(RECT* prc)
    {
        return ((delegate* unmanaged<IBrowserService2*, RECT*, int>)(lpVtbl[75]))((IBrowserService2*)Unsafe.AsPointer(ref this), prc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(76)]
    public HRESULT _UpdateViewRectSize()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[76]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(77)]
    public HRESULT _ResizeNextBorder(uint itb)
    {
        return ((delegate* unmanaged<IBrowserService2*, uint, int>)(lpVtbl[77]))((IBrowserService2*)Unsafe.AsPointer(ref this), itb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(78)]
    public HRESULT _ResizeView()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[78]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(79)]
    public HRESULT _GetEffectiveClientArea([NativeTypeName("LPRECT")] RECT* lprectBorder, HMONITOR hmon)
    {
        return ((delegate* unmanaged<IBrowserService2*, RECT*, HMONITOR, int>)(lpVtbl[79]))((IBrowserService2*)Unsafe.AsPointer(ref this), lprectBorder, hmon);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(80)]
    public IStream* v_GetViewStream([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("LPCWSTR")] ushort* pwszName)
    {
        return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, uint, ushort*, IStream*>)(lpVtbl[80]))((IBrowserService2*)Unsafe.AsPointer(ref this), pidl, grfMode, pwszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(81)]
    public LRESULT ForwardViewMsg(uint uMsg, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<IBrowserService2*, uint, WPARAM, LPARAM, nint>)(lpVtbl[81]))((IBrowserService2*)Unsafe.AsPointer(ref this), uMsg, wParam, lParam);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(82)]
    public HRESULT SetAcceleratorMenu(HACCEL hacc)
    {
        return ((delegate* unmanaged<IBrowserService2*, HACCEL, int>)(lpVtbl[82]))((IBrowserService2*)Unsafe.AsPointer(ref this), hacc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(83)]
    public int _GetToolbarCount()
    {
        return ((delegate* unmanaged<IBrowserService2*, int>)(lpVtbl[83]))((IBrowserService2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(84)]
    [return: NativeTypeName("LPTOOLBARITEM")]
    public TOOLBARITEM* _GetToolbarItem(int itb)
    {
        return ((delegate* unmanaged<IBrowserService2*, int, TOOLBARITEM*>)(lpVtbl[84]))((IBrowserService2*)Unsafe.AsPointer(ref this), itb);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(85)]
    public HRESULT _SaveToolbars(IStream* pstm)
    {
        return ((delegate* unmanaged<IBrowserService2*, IStream*, int>)(lpVtbl[85]))((IBrowserService2*)Unsafe.AsPointer(ref this), pstm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(86)]
    public HRESULT _LoadToolbars(IStream* pstm)
    {
        return ((delegate* unmanaged<IBrowserService2*, IStream*, int>)(lpVtbl[86]))((IBrowserService2*)Unsafe.AsPointer(ref this), pstm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(87)]
    public HRESULT _CloseAndReleaseToolbars(BOOL fClose)
    {
        return ((delegate* unmanaged<IBrowserService2*, BOOL, int>)(lpVtbl[87]))((IBrowserService2*)Unsafe.AsPointer(ref this), fClose);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(88)]
    public HRESULT v_MayGetNextToolbarFocus([NativeTypeName("LPMSG")] MSG* lpMsg, uint itbNext, int citb, [NativeTypeName("LPTOOLBARITEM *")] TOOLBARITEM** pptbi, HWND* phwnd)
    {
        return ((delegate* unmanaged<IBrowserService2*, MSG*, uint, int, TOOLBARITEM**, HWND*, int>)(lpVtbl[88]))((IBrowserService2*)Unsafe.AsPointer(ref this), lpMsg, itbNext, citb, pptbi, phwnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(89)]
    public HRESULT _ResizeNextBorderHelper(uint itb, BOOL bUseHmonitor)
    {
        return ((delegate* unmanaged<IBrowserService2*, uint, BOOL, int>)(lpVtbl[89]))((IBrowserService2*)Unsafe.AsPointer(ref this), itb, bUseHmonitor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(90)]
    public uint _FindTBar(IUnknown* punkSrc)
    {
        return ((delegate* unmanaged<IBrowserService2*, IUnknown*, uint>)(lpVtbl[90]))((IBrowserService2*)Unsafe.AsPointer(ref this), punkSrc);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(91)]
    public HRESULT _SetFocus([NativeTypeName("LPTOOLBARITEM")] TOOLBARITEM* ptbi, HWND hwnd, [NativeTypeName("LPMSG")] MSG* lpMsg)
    {
        return ((delegate* unmanaged<IBrowserService2*, TOOLBARITEM*, HWND, MSG*, int>)(lpVtbl[91]))((IBrowserService2*)Unsafe.AsPointer(ref this), ptbi, hwnd, lpMsg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(92)]
    public HRESULT v_MayTranslateAccelerator(MSG* pmsg)
    {
        return ((delegate* unmanaged<IBrowserService2*, MSG*, int>)(lpVtbl[92]))((IBrowserService2*)Unsafe.AsPointer(ref this), pmsg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(93)]
    public HRESULT _GetBorderDWHelper(IUnknown* punkSrc, [NativeTypeName("LPRECT")] RECT* lprectBorder, BOOL bUseHmonitor)
    {
        return ((delegate* unmanaged<IBrowserService2*, IUnknown*, RECT*, BOOL, int>)(lpVtbl[93]))((IBrowserService2*)Unsafe.AsPointer(ref this), punkSrc, lprectBorder, bUseHmonitor);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(94)]
    public HRESULT v_CheckZoneCrossing([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, int>)(lpVtbl[94]))((IBrowserService2*)Unsafe.AsPointer(ref this), pidl);
    }

    public interface Interface : IBrowserService.Interface
    {
        [VtblIndex(33)]
        LRESULT WndProcBS(HWND hwnd, uint uMsg, WPARAM wParam, LPARAM lParam);

        [VtblIndex(34)]
        HRESULT SetAsDefFolderSettings();

        [VtblIndex(35)]
        HRESULT GetViewRect(RECT* prc);

        [VtblIndex(36)]
        HRESULT OnSize(WPARAM wParam);

        [VtblIndex(37)]
        HRESULT OnCreate([NativeTypeName("struct tagCREATESTRUCTW *")] CREATESTRUCTW* pcs);

        [VtblIndex(38)]
        LRESULT OnCommand(WPARAM wParam, LPARAM lParam);

        [VtblIndex(39)]
        HRESULT OnDestroy();

        [VtblIndex(40)]
        LRESULT OnNotify([NativeTypeName("struct tagNMHDR *")] NMHDR* pnm);

        [VtblIndex(41)]
        HRESULT OnSetFocus();

        [VtblIndex(42)]
        HRESULT OnFrameWindowActivateBS(BOOL fActive);

        [VtblIndex(43)]
        HRESULT ReleaseShellView();

        [VtblIndex(44)]
        HRESULT ActivatePendingView();

        [VtblIndex(45)]
        HRESULT CreateViewWindow(IShellView* psvNew, IShellView* psvOld, [NativeTypeName("LPRECT")] RECT* prcView, HWND* phwnd);

        [VtblIndex(46)]
        HRESULT CreateBrowserPropSheetExt([NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(47)]
        HRESULT GetViewWindow(HWND* phwndView);

        [VtblIndex(48)]
        HRESULT GetBaseBrowserData([NativeTypeName("LPCBASEBROWSERDATA *")] BASEBROWSERDATA** pbbd);

        [VtblIndex(49)]
        [return: NativeTypeName("LPBASEBROWSERDATA")]
        BASEBROWSERDATA* PutBaseBrowserData();

        [VtblIndex(50)]
        HRESULT InitializeTravelLog(ITravelLog* ptl, [NativeTypeName("DWORD")] uint dw);

        [VtblIndex(51)]
        HRESULT SetTopBrowser();

        [VtblIndex(52)]
        HRESULT Offline(int iCmd);

        [VtblIndex(53)]
        HRESULT AllowViewResize(BOOL f);

        [VtblIndex(54)]
        HRESULT SetActivateState(uint u);

        [VtblIndex(55)]
        HRESULT UpdateSecureLockIcon(int eSecureLock);

        [VtblIndex(56)]
        HRESULT InitializeDownloadManager();

        [VtblIndex(57)]
        HRESULT InitializeTransitionSite();

        [VtblIndex(58)]
        HRESULT _Initialize(HWND hwnd, IUnknown* pauto);

        [VtblIndex(59)]
        HRESULT _CancelPendingNavigationAsync();

        [VtblIndex(60)]
        HRESULT _CancelPendingView();

        [VtblIndex(61)]
        HRESULT _MaySaveChanges();

        [VtblIndex(62)]
        HRESULT _PauseOrResumeView(BOOL fPaused);

        [VtblIndex(63)]
        HRESULT _DisableModeless();

        [VtblIndex(64)]
        HRESULT _NavigateToPidl([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfHLNF, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(65)]
        HRESULT _TryShell2Rename(IShellView* psv, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidlNew);

        [VtblIndex(66)]
        HRESULT _SwitchActivationNow();

        [VtblIndex(67)]
        HRESULT _ExecChildren(IUnknown* punkBar, BOOL fBroadcast, [NativeTypeName("const GUID *")] Guid* pguidCmdGroup, [NativeTypeName("DWORD")] uint nCmdID, [NativeTypeName("DWORD")] uint nCmdexecopt, [NativeTypeName("VARIANTARG *")] VARIANT* pvarargIn, [NativeTypeName("VARIANTARG *")] VARIANT* pvarargOut);

        [VtblIndex(68)]
        HRESULT _SendChildren(HWND hwndBar, BOOL fBroadcast, uint uMsg, WPARAM wParam, LPARAM lParam);

        [VtblIndex(69)]
        HRESULT GetFolderSetData([NativeTypeName("struct tagFolderSetData *")] FOLDERSETDATA* pfsd);

        [VtblIndex(70)]
        HRESULT _OnFocusChange(uint itb);

        [VtblIndex(71)]
        HRESULT v_ShowHideChildWindows(BOOL fChildOnly);

        [VtblIndex(72)]
        uint _get_itbLastFocus();

        [VtblIndex(73)]
        HRESULT _put_itbLastFocus(uint itbLastFocus);

        [VtblIndex(74)]
        HRESULT _UIActivateView(uint uState);

        [VtblIndex(75)]
        HRESULT _GetViewBorderRect(RECT* prc);

        [VtblIndex(76)]
        HRESULT _UpdateViewRectSize();

        [VtblIndex(77)]
        HRESULT _ResizeNextBorder(uint itb);

        [VtblIndex(78)]
        HRESULT _ResizeView();

        [VtblIndex(79)]
        HRESULT _GetEffectiveClientArea([NativeTypeName("LPRECT")] RECT* lprectBorder, HMONITOR hmon);

        [VtblIndex(80)]
        IStream* v_GetViewStream([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("LPCWSTR")] ushort* pwszName);

        [VtblIndex(81)]
        LRESULT ForwardViewMsg(uint uMsg, WPARAM wParam, LPARAM lParam);

        [VtblIndex(82)]
        HRESULT SetAcceleratorMenu(HACCEL hacc);

        [VtblIndex(83)]
        int _GetToolbarCount();

        [VtblIndex(84)]
        [return: NativeTypeName("LPTOOLBARITEM")]
        TOOLBARITEM* _GetToolbarItem(int itb);

        [VtblIndex(85)]
        HRESULT _SaveToolbars(IStream* pstm);

        [VtblIndex(86)]
        HRESULT _LoadToolbars(IStream* pstm);

        [VtblIndex(87)]
        HRESULT _CloseAndReleaseToolbars(BOOL fClose);

        [VtblIndex(88)]
        HRESULT v_MayGetNextToolbarFocus([NativeTypeName("LPMSG")] MSG* lpMsg, uint itbNext, int citb, [NativeTypeName("LPTOOLBARITEM *")] TOOLBARITEM** pptbi, HWND* phwnd);

        [VtblIndex(89)]
        HRESULT _ResizeNextBorderHelper(uint itb, BOOL bUseHmonitor);

        [VtblIndex(90)]
        uint _FindTBar(IUnknown* punkSrc);

        [VtblIndex(91)]
        HRESULT _SetFocus([NativeTypeName("LPTOOLBARITEM")] TOOLBARITEM* ptbi, HWND hwnd, [NativeTypeName("LPMSG")] MSG* lpMsg);

        [VtblIndex(92)]
        HRESULT v_MayTranslateAccelerator(MSG* pmsg);

        [VtblIndex(93)]
        HRESULT _GetBorderDWHelper(IUnknown* punkSrc, [NativeTypeName("LPRECT")] RECT* lprectBorder, BOOL bUseHmonitor);

        [VtblIndex(94)]
        HRESULT v_CheckZoneCrossing([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint> Release;

        [NativeTypeName("HRESULT (IOleInPlaceSite **) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IOleInPlaceSite**, int> GetParentSite;

        [NativeTypeName("HRESULT (IShellView *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IShellView*, ushort*, int> SetTitle;

        [NativeTypeName("HRESULT (IShellView *, LPWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IShellView*, ushort*, uint, int> GetTitle;

        [NativeTypeName("HRESULT (IOleObject **) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IOleObject**, int> GetOleObject;

        [NativeTypeName("HRESULT (ITravelLog **) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, ITravelLog**, int> GetTravelLog;

        [NativeTypeName("HRESULT (UINT, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint, BOOL, int> ShowControlWindow;

        [NativeTypeName("HRESULT (UINT, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint, BOOL*, int> IsControlWindowShown;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, LPWSTR, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, ushort*, uint, int> IEGetDisplayName;

        [NativeTypeName("HRESULT (UINT, LPCWSTR, LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint, ushort*, ITEMIDLIST**, int> IEParseDisplayName;

        [NativeTypeName("HRESULT (HRESULT, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, HRESULT, ushort*, int> DisplayParseError;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, uint, int> NavigateToPidl;

        [NativeTypeName("HRESULT (BNSTATE) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, BNSTATE, int> SetNavigateState;

        [NativeTypeName("HRESULT (BNSTATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, BNSTATE*, int> GetNavigateState;

        [NativeTypeName("HRESULT (IShellView *, LPCITEMIDLIST, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IShellView*, ITEMIDLIST*, BOOL*, int> NotifyRedirect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> UpdateWindowList;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> UpdateBackForwardState;

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint, uint, int> SetFlags;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint*, int> GetFlags;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> CanNavigateNow;

        [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, ITEMIDLIST**, int> GetPidl;

        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, int> SetReferrer;

        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint> GetBrowserIndex;

        [NativeTypeName("HRESULT (DWORD, IUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint, IUnknown**, int> GetBrowserByIndex;

        [NativeTypeName("HRESULT (IOleObject **, IStream **, IBindCtx **) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IOleObject**, IStream**, IBindCtx**, int> GetHistoryObject;

        [NativeTypeName("HRESULT (IOleObject *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IOleObject*, BOOL, int> SetHistoryObject;

        [NativeTypeName("HRESULT (IOleObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IOleObject*, int> CacheOLEServer;

        [NativeTypeName("HRESULT (VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, VARIANT*, VARIANT*, int> GetSetCodePage;

        [NativeTypeName("HRESULT (IShellView *, BOOL, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IShellView*, BOOL, VARIANT*, VARIANT*, int> OnHttpEquiv;

        [NativeTypeName("HRESULT (HPALETTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, HPALETTE*, int> GetPalette;

        [NativeTypeName("HRESULT (BOOL, int) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, BOOL, int, int> RegisterWindow;

        [NativeTypeName("LRESULT (HWND, UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, HWND, uint, WPARAM, LPARAM, nint> WndProcBS;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> SetAsDefFolderSettings;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, RECT*, int> GetViewRect;

        [NativeTypeName("HRESULT (WPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, WPARAM, int> OnSize;

        [NativeTypeName("HRESULT (struct tagCREATESTRUCTW *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, CREATESTRUCTW*, int> OnCreate;

        [NativeTypeName("LRESULT (WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, WPARAM, LPARAM, nint> OnCommand;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> OnDestroy;

        [NativeTypeName("LRESULT (struct tagNMHDR *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, NMHDR*, nint> OnNotify;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> OnSetFocus;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, BOOL, int> OnFrameWindowActivateBS;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> ReleaseShellView;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> ActivatePendingView;

        [NativeTypeName("HRESULT (IShellView *, IShellView *, LPRECT, HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IShellView*, IShellView*, RECT*, HWND*, int> CreateViewWindow;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, Guid*, void**, int> CreateBrowserPropSheetExt;

        [NativeTypeName("HRESULT (HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, HWND*, int> GetViewWindow;

        [NativeTypeName("HRESULT (LPCBASEBROWSERDATA *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, BASEBROWSERDATA**, int> GetBaseBrowserData;

        [NativeTypeName("LPBASEBROWSERDATA () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, BASEBROWSERDATA*> PutBaseBrowserData;

        [NativeTypeName("HRESULT (ITravelLog *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, ITravelLog*, uint, int> InitializeTravelLog;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> SetTopBrowser;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int, int> Offline;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, BOOL, int> AllowViewResize;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint, int> SetActivateState;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int, int> UpdateSecureLockIcon;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> InitializeDownloadManager;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> InitializeTransitionSite;

        [NativeTypeName("HRESULT (HWND, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, HWND, IUnknown*, int> _Initialize;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> _CancelPendingNavigationAsync;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> _CancelPendingView;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> _MaySaveChanges;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, BOOL, int> _PauseOrResumeView;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> _DisableModeless;

        [NativeTypeName("HRESULT (LPCITEMIDLIST, DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, uint, uint, int> _NavigateToPidl;

        [NativeTypeName("HRESULT (IShellView *, LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IShellView*, ITEMIDLIST*, int> _TryShell2Rename;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> _SwitchActivationNow;

        [NativeTypeName("HRESULT (IUnknown *, BOOL, const GUID *, DWORD, DWORD, VARIANTARG *, VARIANTARG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IUnknown*, BOOL, Guid*, uint, uint, VARIANT*, VARIANT*, int> _ExecChildren;

        [NativeTypeName("HRESULT (HWND, BOOL, UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, HWND, BOOL, uint, WPARAM, LPARAM, int> _SendChildren;

        [NativeTypeName("HRESULT (struct tagFolderSetData *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, FOLDERSETDATA*, int> GetFolderSetData;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint, int> _OnFocusChange;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, BOOL, int> v_ShowHideChildWindows;

        [NativeTypeName("UINT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint> _get_itbLastFocus;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint, int> _put_itbLastFocus;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint, int> _UIActivateView;

        [NativeTypeName("HRESULT (RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, RECT*, int> _GetViewBorderRect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> _UpdateViewRectSize;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint, int> _ResizeNextBorder;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> _ResizeView;

        [NativeTypeName("HRESULT (LPRECT, HMONITOR) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, RECT*, HMONITOR, int> _GetEffectiveClientArea;

        [NativeTypeName("IStream *(LPCITEMIDLIST, DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, uint, ushort*, IStream*> v_GetViewStream;

        [NativeTypeName("LRESULT (UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint, WPARAM, LPARAM, nint> ForwardViewMsg;

        [NativeTypeName("HRESULT (HACCEL) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, HACCEL, int> SetAcceleratorMenu;

        [NativeTypeName("int () __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int> _GetToolbarCount;

        [NativeTypeName("LPTOOLBARITEM (int) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, int, TOOLBARITEM*> _GetToolbarItem;

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IStream*, int> _SaveToolbars;

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IStream*, int> _LoadToolbars;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, BOOL, int> _CloseAndReleaseToolbars;

        [NativeTypeName("HRESULT (LPMSG, UINT, int, LPTOOLBARITEM *, HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, MSG*, uint, int, TOOLBARITEM**, HWND*, int> v_MayGetNextToolbarFocus;

        [NativeTypeName("HRESULT (UINT, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, uint, BOOL, int> _ResizeNextBorderHelper;

        [NativeTypeName("UINT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IUnknown*, uint> _FindTBar;

        [NativeTypeName("HRESULT (LPTOOLBARITEM, HWND, LPMSG) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, TOOLBARITEM*, HWND, MSG*, int> _SetFocus;

        [NativeTypeName("HRESULT (MSG *) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, MSG*, int> v_MayTranslateAccelerator;

        [NativeTypeName("HRESULT (IUnknown *, LPRECT, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, IUnknown*, RECT*, BOOL, int> _GetBorderDWHelper;

        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<IBrowserService2*, ITEMIDLIST*, int> v_CheckZoneCrossing;
    }
}
