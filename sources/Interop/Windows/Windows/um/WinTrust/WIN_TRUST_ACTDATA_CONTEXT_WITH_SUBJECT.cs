// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public unsafe partial struct WIN_TRUST_ACTDATA_CONTEXT_WITH_SUBJECT
{
    public HANDLE hClientToken;

    public Guid* SubjectType;

    [NativeTypeName("WIN_TRUST_SUBJECT")]
    public void* Subject;
}
