// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_TILE_SHAPE
    {
        [NativeTypeName("UINT")]
        public uint WidthInTexels;

        [NativeTypeName("UINT")]
        public uint HeightInTexels;

        [NativeTypeName("UINT")]
        public uint DepthInTexels;
    }
}
