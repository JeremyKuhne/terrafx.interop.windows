// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum TBPFLAG
{
    TBPF_NOPROGRESS = 0,
    TBPF_INDETERMINATE = 0x1,
    TBPF_NORMAL = 0x2,
    TBPF_ERROR = 0x4,
    TBPF_PAUSED = 0x8,
}
