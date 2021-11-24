// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
public enum MF_MEDIA_ENGINE_S3D_PACKING_MODE
{
    MF_MEDIA_ENGINE_S3D_PACKING_MODE_NONE = 0,
    MF_MEDIA_ENGINE_S3D_PACKING_MODE_SIDE_BY_SIDE = 1,
    MF_MEDIA_ENGINE_S3D_PACKING_MODE_TOP_BOTTOM = 2,
}
