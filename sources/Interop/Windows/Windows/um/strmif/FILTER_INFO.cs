// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='FILTER_INFO.xml' path='doc/member[@name="FILTER_INFO"]/*' />
public unsafe partial struct FILTER_INFO
{
    /// <include file='FILTER_INFO.xml' path='doc/member[@name="FILTER_INFO.achName"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort achName[128];

    /// <include file='FILTER_INFO.xml' path='doc/member[@name="FILTER_INFO.pGraph"]/*' />
    public IFilterGraph* pGraph;
}
