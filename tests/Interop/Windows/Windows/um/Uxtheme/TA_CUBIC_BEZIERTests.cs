// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TA_CUBIC_BEZIER" /> struct.</summary>
public static unsafe partial class TA_CUBIC_BEZIERTests
{
    /// <summary>Validates that the <see cref="TA_CUBIC_BEZIER" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TA_CUBIC_BEZIER>(), Is.EqualTo(sizeof(TA_CUBIC_BEZIER)));
    }

    /// <summary>Validates that the <see cref="TA_CUBIC_BEZIER" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TA_CUBIC_BEZIER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TA_CUBIC_BEZIER" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TA_CUBIC_BEZIER), Is.EqualTo(20));
    }
}
