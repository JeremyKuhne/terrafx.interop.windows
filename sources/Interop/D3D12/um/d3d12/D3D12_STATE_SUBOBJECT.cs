// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_STATE_SUBOBJECT
    {
        public D3D12_STATE_SUBOBJECT_TYPE Type;

        [NativeTypeName("const void *")]
        public void* pDesc;
    }
}
