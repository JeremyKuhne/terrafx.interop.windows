// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SCRUB_PARITY_EXTENT" /> struct.</summary>
public static unsafe partial class SCRUB_PARITY_EXTENTTests
{
    /// <summary>Validates that the <see cref="SCRUB_PARITY_EXTENT" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SCRUB_PARITY_EXTENT>(), Is.EqualTo(sizeof(SCRUB_PARITY_EXTENT)));
    }

    /// <summary>Validates that the <see cref="SCRUB_PARITY_EXTENT" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SCRUB_PARITY_EXTENT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SCRUB_PARITY_EXTENT" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SCRUB_PARITY_EXTENT), Is.EqualTo(16));
    }
}
