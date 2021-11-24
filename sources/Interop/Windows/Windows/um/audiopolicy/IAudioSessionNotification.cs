// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("641DD20B-4D41-49CC-ABA3-174B9477BB08")]
[NativeTypeName("struct IAudioSessionNotification : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioSessionNotification : IAudioSessionNotification.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioSessionNotification*, Guid*, void**, int>)(lpVtbl[0]))((IAudioSessionNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioSessionNotification*, uint>)(lpVtbl[1]))((IAudioSessionNotification*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioSessionNotification*, uint>)(lpVtbl[2]))((IAudioSessionNotification*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnSessionCreated(IAudioSessionControl* NewSession)
    {
        return ((delegate* unmanaged<IAudioSessionNotification*, IAudioSessionControl*, int>)(lpVtbl[3]))((IAudioSessionNotification*)Unsafe.AsPointer(ref this), NewSession);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnSessionCreated(IAudioSessionControl* NewSession);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioSessionNotification*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioSessionNotification*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioSessionNotification*, uint> Release;

        [NativeTypeName("HRESULT (IAudioSessionControl *) __attribute__((stdcall))")]
        public delegate* unmanaged<IAudioSessionNotification*, IAudioSessionControl*, int> OnSessionCreated;
    }
}
