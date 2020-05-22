// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WICBitmapDitherType
    {
        WICBitmapDitherTypeNone = 0,
        WICBitmapDitherTypeSolid = 0,
        WICBitmapDitherTypeOrdered4x4 = 0x1,
        WICBitmapDitherTypeOrdered8x8 = 0x2,
        WICBitmapDitherTypeOrdered16x16 = 0x3,
        WICBitmapDitherTypeSpiral4x4 = 0x4,
        WICBitmapDitherTypeSpiral8x8 = 0x5,
        WICBitmapDitherTypeDualSpiral4x4 = 0x6,
        WICBitmapDitherTypeDualSpiral8x8 = 0x7,
        WICBitmapDitherTypeErrorDiffusion = 0x8,
        WICBITMAPDITHERTYPE_FORCE_DWORD = 0x7fffffff,
    }
}
