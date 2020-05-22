// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_SUBRESOURCE_TILING
    {
        [NativeTypeName("UINT")]
        public uint WidthInTiles;

        [NativeTypeName("UINT16")]
        public ushort HeightInTiles;

        [NativeTypeName("UINT16")]
        public ushort DepthInTiles;

        [NativeTypeName("UINT")]
        public uint StartTileIndexInOverallResource;
    }
}
