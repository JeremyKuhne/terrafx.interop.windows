// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IContextMenu2.xml' path='doc/member[@name="IContextMenu2"]/*' />
[Guid("000214F4-0000-0000-C000-000000000046")]
[NativeTypeName("struct IContextMenu2 : IContextMenu")]
[NativeInheritance("IContextMenu")]
public unsafe partial struct IContextMenu2 : IContextMenu2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContextMenu2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContextMenu2*, Guid*, void**, int>)(lpVtbl[0]))((IContextMenu2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IContextMenu2*, uint>)(lpVtbl[1]))((IContextMenu2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContextMenu2*, uint>)(lpVtbl[2]))((IContextMenu2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IContextMenu.QueryContextMenu" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryContextMenu(HMENU hmenu, uint indexMenu, uint idCmdFirst, uint idCmdLast, uint uFlags)
    {
        return ((delegate* unmanaged<IContextMenu2*, HMENU, uint, uint, uint, uint, int>)(lpVtbl[3]))((IContextMenu2*)Unsafe.AsPointer(ref this), hmenu, indexMenu, idCmdFirst, idCmdLast, uFlags);
    }

    /// <inheritdoc cref="IContextMenu.InvokeCommand" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InvokeCommand(CMINVOKECOMMANDINFO* pici)
    {
        return ((delegate* unmanaged<IContextMenu2*, CMINVOKECOMMANDINFO*, int>)(lpVtbl[4]))((IContextMenu2*)Unsafe.AsPointer(ref this), pici);
    }

    /// <inheritdoc cref="IContextMenu.GetCommandString" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCommandString([NativeTypeName("UINT_PTR")] nuint idCmd, uint uType, uint* pReserved, [NativeTypeName("CHAR *")] sbyte* pszName, uint cchMax)
    {
        return ((delegate* unmanaged<IContextMenu2*, nuint, uint, uint*, sbyte*, uint, int>)(lpVtbl[5]))((IContextMenu2*)Unsafe.AsPointer(ref this), idCmd, uType, pReserved, pszName, cchMax);
    }

    /// <include file='IContextMenu2.xml' path='doc/member[@name="IContextMenu2.HandleMenuMsg"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT HandleMenuMsg(uint uMsg, WPARAM wParam, LPARAM lParam)
    {
        return ((delegate* unmanaged<IContextMenu2*, uint, WPARAM, LPARAM, int>)(lpVtbl[6]))((IContextMenu2*)Unsafe.AsPointer(ref this), uMsg, wParam, lParam);
    }

    public interface Interface : IContextMenu.Interface
    {
        [VtblIndex(6)]
        HRESULT HandleMenuMsg(uint uMsg, WPARAM wParam, LPARAM lParam);
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

        [NativeTypeName("HRESULT (HMENU, UINT, UINT, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMENU, uint, uint, uint, uint, int> QueryContextMenu;

        [NativeTypeName("HRESULT (CMINVOKECOMMANDINFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, CMINVOKECOMMANDINFO*, int> InvokeCommand;

        [NativeTypeName("HRESULT (UINT_PTR, UINT, UINT *, CHAR *, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, uint, uint*, sbyte*, uint, int> GetCommandString;

        [NativeTypeName("HRESULT (UINT, WPARAM, LPARAM) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, WPARAM, LPARAM, int> HandleMenuMsg;
    }
}
