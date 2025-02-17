// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/inaddr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IN_ADDR" /> struct.</summary>
public static unsafe partial class IN_ADDRTests
{
    /// <summary>Validates that the <see cref="IN_ADDR" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IN_ADDR>(), Is.EqualTo(sizeof(IN_ADDR)));
    }

    /// <summary>Validates that the <see cref="IN_ADDR" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IN_ADDR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IN_ADDR" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IN_ADDR), Is.EqualTo(4));
    }
}
