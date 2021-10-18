// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Msi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SCRIPTFLAGS
    {
        SCRIPTFLAGS_CACHEINFO = 0x00000001,
        SCRIPTFLAGS_SHORTCUTS = 0x00000004,
        SCRIPTFLAGS_MACHINEASSIGN = 0x00000008,
        SCRIPTFLAGS_REGDATA_CNFGINFO = 0x00000020,
        SCRIPTFLAGS_VALIDATE_TRANSFORMS_LIST = 0x00000040,
        SCRIPTFLAGS_REGDATA_CLASSINFO = 0x00000080,
        SCRIPTFLAGS_REGDATA_EXTENSIONINFO = 0x00000100,
        SCRIPTFLAGS_REGDATA_APPINFO = SCRIPTFLAGS_REGDATA_CLASSINFO | SCRIPTFLAGS_REGDATA_EXTENSIONINFO,
        SCRIPTFLAGS_REGDATA = SCRIPTFLAGS_REGDATA_APPINFO | SCRIPTFLAGS_REGDATA_CNFGINFO,
    }
}
