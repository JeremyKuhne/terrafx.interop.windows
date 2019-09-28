// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct FLASHWINFO
    {
        [NativeTypeName("UINT")]
        public uint cbSize;

        [NativeTypeName("HWND")]
        public IntPtr hwnd;

        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [NativeTypeName("UINT")]
        public uint uCount;

        [NativeTypeName("DWORD")]
        public uint dwTimeout;
    }
}
