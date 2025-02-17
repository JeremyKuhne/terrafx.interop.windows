// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

public partial struct D3D11_DEPTH_STENCILOP_DESC
{
    public static ref readonly D3D11_DEPTH_STENCILOP_DESC DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                    0x01, 0x00, 0x00, 0x00,
                    0x01, 0x00, 0x00, 0x00,
                    0x01, 0x00, 0x00, 0x00,
                    0x08, 0x00, 0x00, 0x00
                };

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D11_DEPTH_STENCILOP_DESC>());
            return ref Unsafe.As<byte, D3D11_DEPTH_STENCILOP_DESC>(ref MemoryMarshal.GetReference(data));
        }
    }
}
