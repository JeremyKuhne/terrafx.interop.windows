// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='GET_MEDIA_TYPES.xml' path='doc/member[@name="GET_MEDIA_TYPES"]/*' />
public partial struct GET_MEDIA_TYPES
{
    /// <include file='GET_MEDIA_TYPES.xml' path='doc/member[@name="GET_MEDIA_TYPES.DeviceType"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceType;

    /// <include file='GET_MEDIA_TYPES.xml' path='doc/member[@name="GET_MEDIA_TYPES.MediaInfoCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint MediaInfoCount;

    /// <include file='GET_MEDIA_TYPES.xml' path='doc/member[@name="GET_MEDIA_TYPES.MediaInfo"]/*' />
    [NativeTypeName("DEVICE_MEDIA_INFO[1]")]
    public _MediaInfo_e__FixedBuffer MediaInfo;

    /// <include file='_MediaInfo_e__FixedBuffer.xml' path='doc/member[@name="_MediaInfo_e__FixedBuffer"]/*' />
    public partial struct _MediaInfo_e__FixedBuffer
    {
        public DEVICE_MEDIA_INFO e0;

        [UnscopedRef]
        public ref DEVICE_MEDIA_INFO this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<DEVICE_MEDIA_INFO> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
