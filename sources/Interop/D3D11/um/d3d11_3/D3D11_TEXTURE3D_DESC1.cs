// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D11_TEXTURE3D_DESC1
    {
        [NativeTypeName("UINT")]
        public uint Width;

        [NativeTypeName("UINT")]
        public uint Height;

        [NativeTypeName("UINT")]
        public uint Depth;

        [NativeTypeName("UINT")]
        public uint MipLevels;

        public DXGI_FORMAT Format;

        public D3D11_USAGE Usage;

        [NativeTypeName("UINT")]
        public uint BindFlags;

        [NativeTypeName("UINT")]
        public uint CPUAccessFlags;

        [NativeTypeName("UINT")]
        public uint MiscFlags;

        public D3D11_TEXTURE_LAYOUT TextureLayout;
    }
}
