// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_INPUT_ELEMENT_DESC
    {
        [NativeTypeName("LPCSTR")]
        public sbyte* SemanticName;

        [NativeTypeName("UINT")]
        public uint SemanticIndex;

        public DXGI_FORMAT Format;

        [NativeTypeName("UINT")]
        public uint InputSlot;

        [NativeTypeName("UINT")]
        public uint AlignedByteOffset;

        public D3D12_INPUT_CLASSIFICATION InputSlotClass;

        [NativeTypeName("UINT")]
        public uint InstanceDataStepRate;
    }
}
