// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Gdiplus.UnitTests;

/// <summary>Provides validation of the <see cref="BlurParams" /> struct.</summary>
public static unsafe partial class BlurParamsTests
{
    /// <summary>Validates that the <see cref="BlurParams" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BlurParams>(), Is.EqualTo(sizeof(BlurParams)));
    }

    /// <summary>Validates that the <see cref="BlurParams" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BlurParams).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="BlurParams" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(BlurParams), Is.EqualTo(8));
    }
}
