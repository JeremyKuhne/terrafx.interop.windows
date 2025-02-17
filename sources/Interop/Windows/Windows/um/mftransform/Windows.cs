// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    [NativeTypeName("const IID")]
    public static ref readonly Guid MEDeviceStreamCreated
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xCF, 0xA1, 0x52, 0x02,
                0x40, 0x35,
                0xB4, 0x43,
                0x91,
                0x64,
                0xD7,
                0x2E,
                0xB4,
                0x05,
                0xFA,
                0x40
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFCreateTransformActivate"]/*' />
    [DllImport("mfplat", ExactSpelling = true)]
    public static extern HRESULT MFCreateTransformActivate(IMFActivate** ppActivate);
}
