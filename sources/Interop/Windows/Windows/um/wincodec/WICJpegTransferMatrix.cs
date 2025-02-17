// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WICJpegTransferMatrix.xml' path='doc/member[@name="WICJpegTransferMatrix"]/*' />
public enum WICJpegTransferMatrix : uint
{
    /// <include file='WICJpegTransferMatrix.xml' path='doc/member[@name="WICJpegTransferMatrix.WICJpegTransferMatrixIdentity"]/*' />
    WICJpegTransferMatrixIdentity = 0,

    /// <include file='WICJpegTransferMatrix.xml' path='doc/member[@name="WICJpegTransferMatrix.WICJpegTransferMatrixBT601"]/*' />
    WICJpegTransferMatrixBT601 = 0x1,

    /// <include file='WICJpegTransferMatrix.xml' path='doc/member[@name="WICJpegTransferMatrix.WICJpegTransferMatrix_FORCE_DWORD"]/*' />
    WICJpegTransferMatrix_FORCE_DWORD = 0x7fffffff,
}
