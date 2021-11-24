// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("C405A219-25A2-442E-8743-B845A2CEE93F")]
[NativeTypeName("struct ISyncMgrConflictResolveInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrConflictResolveInfo : ISyncMgrConflictResolveInfo.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, Guid*, void**, int>)(lpVtbl[0]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint>)(lpVtbl[1]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint>)(lpVtbl[2]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIterationInfo(uint* pnCurrentConflict, uint* pcConflicts, uint* pcRemainingForApplyToAll)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint*, uint*, uint*, int>)(lpVtbl[3]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), pnCurrentConflict, pcConflicts, pcRemainingForApplyToAll);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPresenterNextStep(SYNCMGR_PRESENTER_NEXT_STEP* pnPresenterNextStep)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, SYNCMGR_PRESENTER_NEXT_STEP*, int>)(lpVtbl[4]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), pnPresenterNextStep);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPresenterChoice(SYNCMGR_PRESENTER_CHOICE* pnPresenterChoice, BOOL* pfApplyToAll)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, SYNCMGR_PRESENTER_CHOICE*, BOOL*, int>)(lpVtbl[5]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), pnPresenterChoice, pfApplyToAll);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetItemChoiceCount(uint* pcChoices)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint*, int>)(lpVtbl[6]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), pcChoices);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetItemChoice(uint iChoice, uint* piChoiceIndex)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint, uint*, int>)(lpVtbl[7]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), iChoice, piChoiceIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetPresenterNextStep(SYNCMGR_PRESENTER_NEXT_STEP nPresenterNextStep)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, SYNCMGR_PRESENTER_NEXT_STEP, int>)(lpVtbl[8]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), nPresenterNextStep);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetPresenterChoice(SYNCMGR_PRESENTER_CHOICE nPresenterChoice, BOOL fApplyToAll)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, SYNCMGR_PRESENTER_CHOICE, BOOL, int>)(lpVtbl[9]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), nPresenterChoice, fApplyToAll);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetItemChoices(uint* prgiConflictItemIndexes, uint cChoices)
    {
        return ((delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint*, uint, int>)(lpVtbl[10]))((ISyncMgrConflictResolveInfo*)Unsafe.AsPointer(ref this), prgiConflictItemIndexes, cChoices);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetIterationInfo(uint* pnCurrentConflict, uint* pcConflicts, uint* pcRemainingForApplyToAll);

        [VtblIndex(4)]
        HRESULT GetPresenterNextStep(SYNCMGR_PRESENTER_NEXT_STEP* pnPresenterNextStep);

        [VtblIndex(5)]
        HRESULT GetPresenterChoice(SYNCMGR_PRESENTER_CHOICE* pnPresenterChoice, BOOL* pfApplyToAll);

        [VtblIndex(6)]
        HRESULT GetItemChoiceCount(uint* pcChoices);

        [VtblIndex(7)]
        HRESULT GetItemChoice(uint iChoice, uint* piChoiceIndex);

        [VtblIndex(8)]
        HRESULT SetPresenterNextStep(SYNCMGR_PRESENTER_NEXT_STEP nPresenterNextStep);

        [VtblIndex(9)]
        HRESULT SetPresenterChoice(SYNCMGR_PRESENTER_CHOICE nPresenterChoice, BOOL fApplyToAll);

        [VtblIndex(10)]
        HRESULT SetItemChoices(uint* prgiConflictItemIndexes, uint cChoices);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrConflictResolveInfo*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint> Release;

        [NativeTypeName("HRESULT (UINT *, UINT *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint*, uint*, uint*, int> GetIterationInfo;

        [NativeTypeName("HRESULT (SYNCMGR_PRESENTER_NEXT_STEP *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrConflictResolveInfo*, SYNCMGR_PRESENTER_NEXT_STEP*, int> GetPresenterNextStep;

        [NativeTypeName("HRESULT (SYNCMGR_PRESENTER_CHOICE *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrConflictResolveInfo*, SYNCMGR_PRESENTER_CHOICE*, BOOL*, int> GetPresenterChoice;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint*, int> GetItemChoiceCount;

        [NativeTypeName("HRESULT (UINT, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint, uint*, int> GetItemChoice;

        [NativeTypeName("HRESULT (SYNCMGR_PRESENTER_NEXT_STEP) __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrConflictResolveInfo*, SYNCMGR_PRESENTER_NEXT_STEP, int> SetPresenterNextStep;

        [NativeTypeName("HRESULT (SYNCMGR_PRESENTER_CHOICE, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrConflictResolveInfo*, SYNCMGR_PRESENTER_CHOICE, BOOL, int> SetPresenterChoice;

        [NativeTypeName("HRESULT (UINT *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<ISyncMgrConflictResolveInfo*, uint*, uint, int> SetItemChoices;
    }
}
