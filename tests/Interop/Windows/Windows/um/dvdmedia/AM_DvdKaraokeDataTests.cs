// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="AM_DvdKaraokeData" /> struct.</summary>
public static unsafe partial class AM_DvdKaraokeDataTests
{
    /// <summary>Validates that the <see cref="AM_DvdKaraokeData" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AM_DvdKaraokeData>(), Is.EqualTo(sizeof(AM_DvdKaraokeData)));
    }

    /// <summary>Validates that the <see cref="AM_DvdKaraokeData" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AM_DvdKaraokeData).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AM_DvdKaraokeData" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AM_DvdKaraokeData), Is.EqualTo(8));
    }
}
