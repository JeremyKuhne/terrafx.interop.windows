// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct MINIDUMP_THREAD_EX
    {
        [NativeTypeName("ULONG32")]
        public uint ThreadId;

        [NativeTypeName("ULONG32")]
        public uint SuspendCount;

        [NativeTypeName("ULONG32")]
        public uint PriorityClass;

        [NativeTypeName("ULONG32")]
        public uint Priority;

        [NativeTypeName("ULONG64")]
        public ulong Teb;

        public MINIDUMP_MEMORY_DESCRIPTOR Stack;

        public MINIDUMP_LOCATION_DESCRIPTOR ThreadContext;

        public MINIDUMP_MEMORY_DESCRIPTOR BackingStore;
    }
}
