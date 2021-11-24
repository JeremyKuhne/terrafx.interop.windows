// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct STORAGE_RPMB_DESCRIPTOR
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint SizeInBytes;

    [NativeTypeName("DWORD")]
    public uint MaxReliableWriteSizeInBytes;

    public STORAGE_RPMB_FRAME_TYPE FrameFormat;
}
