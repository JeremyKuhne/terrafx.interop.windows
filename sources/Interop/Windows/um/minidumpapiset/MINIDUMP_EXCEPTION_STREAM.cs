// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MINIDUMP_EXCEPTION_STREAM
    {
        [NativeTypeName("ULONG32")]
        public uint ThreadId;

        [NativeTypeName("ULONG32")]
        public uint __alignment;

        public MINIDUMP_EXCEPTION ExceptionRecord;

        public MINIDUMP_LOCATION_DESCRIPTOR ThreadContext;
    }
}
