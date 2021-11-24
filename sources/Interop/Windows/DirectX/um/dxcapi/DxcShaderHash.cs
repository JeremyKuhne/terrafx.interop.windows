// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

namespace TerraFX.Interop.DirectX;

public unsafe partial struct DxcShaderHash
{
    [NativeTypeName("UINT32")]
    public uint Flags;

    [NativeTypeName("BYTE [16]")]
    public fixed byte HashDigest[16];
}
