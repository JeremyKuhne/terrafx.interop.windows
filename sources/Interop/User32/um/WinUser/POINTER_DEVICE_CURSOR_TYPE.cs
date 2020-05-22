// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum POINTER_DEVICE_CURSOR_TYPE : uint
    {
        POINTER_DEVICE_CURSOR_TYPE_UNKNOWN = 0x00000000,
        POINTER_DEVICE_CURSOR_TYPE_TIP = 0x00000001,
        POINTER_DEVICE_CURSOR_TYPE_ERASER = 0x00000002,
        POINTER_DEVICE_CURSOR_TYPE_MAX = 0xFFFFFFFF,
    }
}
