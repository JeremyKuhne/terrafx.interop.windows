// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

[Flags]
[SupportedOSPlatform("windows8.0")]
public enum D3D11_VIDEO_PROCESSOR_STEREO_CAPS
{
    D3D11_VIDEO_PROCESSOR_STEREO_CAPS_MONO_OFFSET = 0x1,
    D3D11_VIDEO_PROCESSOR_STEREO_CAPS_ROW_INTERLEAVED = 0x2,
    D3D11_VIDEO_PROCESSOR_STEREO_CAPS_COLUMN_INTERLEAVED = 0x4,
    D3D11_VIDEO_PROCESSOR_STEREO_CAPS_CHECKERBOARD = 0x8,
    D3D11_VIDEO_PROCESSOR_STEREO_CAPS_FLIP_MODE = 0x10,
}
