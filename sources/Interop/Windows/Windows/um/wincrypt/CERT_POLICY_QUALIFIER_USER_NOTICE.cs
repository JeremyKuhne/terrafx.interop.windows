// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CERT_POLICY_QUALIFIER_USER_NOTICE.xml' path='doc/member[@name="CERT_POLICY_QUALIFIER_USER_NOTICE"]/*' />
public unsafe partial struct CERT_POLICY_QUALIFIER_USER_NOTICE
{
    /// <include file='CERT_POLICY_QUALIFIER_USER_NOTICE.xml' path='doc/member[@name="CERT_POLICY_QUALIFIER_USER_NOTICE.pNoticeReference"]/*' />
    public CERT_POLICY_QUALIFIER_NOTICE_REFERENCE* pNoticeReference;

    /// <include file='CERT_POLICY_QUALIFIER_USER_NOTICE.xml' path='doc/member[@name="CERT_POLICY_QUALIFIER_USER_NOTICE.pszDisplayText"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszDisplayText;
}
