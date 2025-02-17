// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIB_UDPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_UDPROW_OWNER_MODULE"]/*' />
public unsafe partial struct MIB_UDPROW_OWNER_MODULE
{
    /// <include file='MIB_UDPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_UDPROW_OWNER_MODULE.dwLocalAddr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalAddr;

    /// <include file='MIB_UDPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_UDPROW_OWNER_MODULE.dwLocalPort"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalPort;

    /// <include file='MIB_UDPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_UDPROW_OWNER_MODULE.dwOwningPid"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOwningPid;

    /// <include file='MIB_UDPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_UDPROW_OWNER_MODULE.liCreateTimestamp"]/*' />
    public LARGE_INTEGER liCreateTimestamp;

    /// <include file='MIB_UDPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_UDPROW_OWNER_MODULE.Anonymous"]/*' />
    [NativeTypeName("_MIB_UDPROW_OWNER_MODULE::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared/udpmib.h:69:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='MIB_UDPROW_OWNER_MODULE.xml' path='doc/member[@name="MIB_UDPROW_OWNER_MODULE.OwningModuleInfo"]/*' />
    [NativeTypeName("ULONGLONG[16]")]
    public fixed ulong OwningModuleInfo[16];

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.SpecificPortBind"]/*' />
    public int SpecificPortBind
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.SpecificPortBind;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.SpecificPortBind = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwFlags"]/*' />
    [UnscopedRef]
    public ref int dwFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwFlags;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("_MIB_UDPROW_OWNER_MODULE::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/shared/udpmib.h:70:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwFlags"]/*' />
        [FieldOffset(0)]
        public int dwFlags;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public int _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.SpecificPortBind"]/*' />
            [NativeTypeName("int : 1")]
            public int SpecificPortBind
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0x1;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0x1) | (value & 0x1);
                }
            }
        }
    }
}
