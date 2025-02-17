// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SOFTKBDDATA.xml' path='doc/member[@name="SOFTKBDDATA"]/*' />
public unsafe partial struct SOFTKBDDATA
{
    /// <include file='SOFTKBDDATA.xml' path='doc/member[@name="SOFTKBDDATA.uCount"]/*' />
    public uint uCount;

    /// <include file='SOFTKBDDATA.xml' path='doc/member[@name="SOFTKBDDATA.wCode"]/*' />
    [NativeTypeName("WORD[1][256]")]
    public fixed ushort wCode[1 * 256];
}
