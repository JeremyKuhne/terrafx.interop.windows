// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="STORAGE_COUNTERS" /> struct.</summary>
public static unsafe partial class STORAGE_COUNTERSTests
{
    /// <summary>Validates that the <see cref="STORAGE_COUNTERS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STORAGE_COUNTERS>(), Is.EqualTo(sizeof(STORAGE_COUNTERS)));
    }

    /// <summary>Validates that the <see cref="STORAGE_COUNTERS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_COUNTERS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="STORAGE_COUNTERS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_COUNTERS), Is.EqualTo(32));
    }
}
