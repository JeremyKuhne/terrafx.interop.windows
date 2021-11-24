// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows10.0.22000.0")]
public partial struct AudioClientProperties
{
    [NativeTypeName("UINT32")]
    public uint cbSize;

    public BOOL bIsOffload;

    public AUDIO_STREAM_CATEGORY eCategory;

    public AUDCLNT_STREAMOPTIONS Options;
}
