// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Xinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="XINPUT_VIBRATION" /> struct.</summary>
public static unsafe partial class XINPUT_VIBRATIONTests
{
    /// <summary>Validates that the <see cref="XINPUT_VIBRATION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XINPUT_VIBRATION>(), Is.EqualTo(sizeof(XINPUT_VIBRATION)));
    }

    /// <summary>Validates that the <see cref="XINPUT_VIBRATION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XINPUT_VIBRATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="XINPUT_VIBRATION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(XINPUT_VIBRATION), Is.EqualTo(4));
    }
}
