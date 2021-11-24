// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum IMAPI_PROFILE_TYPE
{
    IMAPI_PROFILE_TYPE_INVALID = 0,
    IMAPI_PROFILE_TYPE_NON_REMOVABLE_DISK = 0x1,
    IMAPI_PROFILE_TYPE_REMOVABLE_DISK = 0x2,
    IMAPI_PROFILE_TYPE_MO_ERASABLE = 0x3,
    IMAPI_PROFILE_TYPE_MO_WRITE_ONCE = 0x4,
    IMAPI_PROFILE_TYPE_AS_MO = 0x5,
    IMAPI_PROFILE_TYPE_CDROM = 0x8,
    IMAPI_PROFILE_TYPE_CD_RECORDABLE = 0x9,
    IMAPI_PROFILE_TYPE_CD_REWRITABLE = 0xa,
    IMAPI_PROFILE_TYPE_DVDROM = 0x10,
    IMAPI_PROFILE_TYPE_DVD_DASH_RECORDABLE = 0x11,
    IMAPI_PROFILE_TYPE_DVD_RAM = 0x12,
    IMAPI_PROFILE_TYPE_DVD_DASH_REWRITABLE = 0x13,
    IMAPI_PROFILE_TYPE_DVD_DASH_RW_SEQUENTIAL = 0x14,
    IMAPI_PROFILE_TYPE_DVD_DASH_R_DUAL_SEQUENTIAL = 0x15,
    IMAPI_PROFILE_TYPE_DVD_DASH_R_DUAL_LAYER_JUMP = 0x16,
    IMAPI_PROFILE_TYPE_DVD_PLUS_RW = 0x1a,
    IMAPI_PROFILE_TYPE_DVD_PLUS_R = 0x1b,
    IMAPI_PROFILE_TYPE_DDCDROM = 0x20,
    IMAPI_PROFILE_TYPE_DDCD_RECORDABLE = 0x21,
    IMAPI_PROFILE_TYPE_DDCD_REWRITABLE = 0x22,
    IMAPI_PROFILE_TYPE_DVD_PLUS_RW_DUAL = 0x2a,
    IMAPI_PROFILE_TYPE_DVD_PLUS_R_DUAL = 0x2b,
    IMAPI_PROFILE_TYPE_BD_ROM = 0x40,
    IMAPI_PROFILE_TYPE_BD_R_SEQUENTIAL = 0x41,
    IMAPI_PROFILE_TYPE_BD_R_RANDOM_RECORDING = 0x42,
    IMAPI_PROFILE_TYPE_BD_REWRITABLE = 0x43,
    IMAPI_PROFILE_TYPE_HD_DVD_ROM = 0x50,
    IMAPI_PROFILE_TYPE_HD_DVD_RECORDABLE = 0x51,
    IMAPI_PROFILE_TYPE_HD_DVD_RAM = 0x52,
    IMAPI_PROFILE_TYPE_NON_STANDARD = 0xffff,
}
