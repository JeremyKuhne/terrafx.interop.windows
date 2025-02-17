// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DRIVE_LAYOUT_INFORMATION.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION"]/*' />
public partial struct DRIVE_LAYOUT_INFORMATION
{
    /// <include file='DRIVE_LAYOUT_INFORMATION.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION.PartitionCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint PartitionCount;

    /// <include file='DRIVE_LAYOUT_INFORMATION.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION.Signature"]/*' />
    [NativeTypeName("DWORD")]
    public uint Signature;

    /// <include file='DRIVE_LAYOUT_INFORMATION.xml' path='doc/member[@name="DRIVE_LAYOUT_INFORMATION.PartitionEntry"]/*' />
    [NativeTypeName("PARTITION_INFORMATION[1]")]
    public _PartitionEntry_e__FixedBuffer PartitionEntry;

    /// <include file='_PartitionEntry_e__FixedBuffer.xml' path='doc/member[@name="_PartitionEntry_e__FixedBuffer"]/*' />
    public partial struct _PartitionEntry_e__FixedBuffer
    {
        public PARTITION_INFORMATION e0;

        [UnscopedRef]
        public ref PARTITION_INFORMATION this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<PARTITION_INFORMATION> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
