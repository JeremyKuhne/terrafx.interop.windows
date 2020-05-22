// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct FILTERKEYS
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("DWORD")]
        public uint iWaitMSec;

        [NativeTypeName("DWORD")]
        public uint iDelayMSec;

        [NativeTypeName("DWORD")]
        public uint iRepeatMSec;

        [NativeTypeName("DWORD")]
        public uint iBounceMSec;
    }
}
