// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_VIDEO_PROCESS_REFERENCE_SET
    {
        [NativeTypeName("UINT")]
        public uint NumPastFrames;

        [NativeTypeName("ID3D12Resource **")]
        public ID3D12Resource** ppPastFrames;

        [NativeTypeName("UINT *")]
        public uint* pPastSubresources;

        [NativeTypeName("UINT")]
        public uint NumFutureFrames;

        [NativeTypeName("ID3D12Resource **")]
        public ID3D12Resource** ppFutureFrames;

        [NativeTypeName("UINT *")]
        public uint* pFutureSubresources;
    }
}
