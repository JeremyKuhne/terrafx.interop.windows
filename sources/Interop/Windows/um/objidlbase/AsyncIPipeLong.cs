// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdlbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DB2F3ACD-2F86-11D1-8E04-00C04FB9989A")]
    public unsafe partial struct AsyncIPipeLong
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(AsyncIPipeLong* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(AsyncIPipeLong* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(AsyncIPipeLong* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Begin_Pull(AsyncIPipeLong* pThis, [NativeTypeName("ULONG")] uint cRequest);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Finish_Pull(AsyncIPipeLong* pThis, [NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG *")] uint* pcReturned);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Begin_Push(AsyncIPipeLong* pThis, [NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG")] uint cSent);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Finish_Push(AsyncIPipeLong* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((AsyncIPipeLong*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((AsyncIPipeLong*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((AsyncIPipeLong*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin_Pull([NativeTypeName("ULONG")] uint cRequest)
        {
            return Marshal.GetDelegateForFunctionPointer<_Begin_Pull>(lpVtbl->Begin_Pull)((AsyncIPipeLong*)Unsafe.AsPointer(ref this), cRequest);
        }

        [return: NativeTypeName("HRESULT")]
        public int Finish_Pull([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG *")] uint* pcReturned)
        {
            return Marshal.GetDelegateForFunctionPointer<_Finish_Pull>(lpVtbl->Finish_Pull)((AsyncIPipeLong*)Unsafe.AsPointer(ref this), buf, pcReturned);
        }

        [return: NativeTypeName("HRESULT")]
        public int Begin_Push([NativeTypeName("LONG *")] int* buf, [NativeTypeName("ULONG")] uint cSent)
        {
            return Marshal.GetDelegateForFunctionPointer<_Begin_Push>(lpVtbl->Begin_Push)((AsyncIPipeLong*)Unsafe.AsPointer(ref this), buf, cSent);
        }

        [return: NativeTypeName("HRESULT")]
        public int Finish_Push()
        {
            return Marshal.GetDelegateForFunctionPointer<_Finish_Push>(lpVtbl->Finish_Push)((AsyncIPipeLong*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public IntPtr Begin_Pull;

            [NativeTypeName("HRESULT (LONG *, ULONG *) __attribute__((stdcall))")]
            public IntPtr Finish_Pull;

            [NativeTypeName("HRESULT (LONG *, ULONG) __attribute__((stdcall))")]
            public IntPtr Begin_Push;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Finish_Push;
        }
    }
}
