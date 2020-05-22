// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum WICProgressNotification : uint
    {
        WICProgressNotificationBegin = 0x10000,
        WICProgressNotificationEnd = 0x20000,
        WICProgressNotificationFrequent = 0x40000,
        WICProgressNotificationAll = 0xffff0000,
        WICPROGRESSNOTIFICATION_FORCE_DWORD = 0x7fffffff,
    }
}
