// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="XAUDIO2_VOICE_SENDS" /> struct.</summary>
public static unsafe partial class XAUDIO2_VOICE_SENDSTests
{
    /// <summary>Validates that the <see cref="XAUDIO2_VOICE_SENDS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XAUDIO2_VOICE_SENDS>(), Is.EqualTo(sizeof(XAUDIO2_VOICE_SENDS)));
    }

    /// <summary>Validates that the <see cref="XAUDIO2_VOICE_SENDS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XAUDIO2_VOICE_SENDS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="XAUDIO2_VOICE_SENDS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(XAUDIO2_VOICE_SENDS), Is.EqualTo(12));
        }
        else
        {
            Assert.That(sizeof(XAUDIO2_VOICE_SENDS), Is.EqualTo(8));
        }
    }
}
