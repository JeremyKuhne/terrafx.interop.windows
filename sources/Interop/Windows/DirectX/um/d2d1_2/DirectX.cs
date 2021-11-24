// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("d2d1", ExactSpelling = true)]
    [SupportedOSPlatform("windows8.1")]
    [SuppressGCTransition]
    public static extern float D2D1ComputeMaximumScaleFactor([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);
}
