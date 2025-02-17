// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/timezoneapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DYNAMIC_TIME_ZONE_INFORMATION" /> struct.</summary>
public static unsafe partial class DYNAMIC_TIME_ZONE_INFORMATIONTests
{
    /// <summary>Validates that the <see cref="DYNAMIC_TIME_ZONE_INFORMATION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DYNAMIC_TIME_ZONE_INFORMATION>(), Is.EqualTo(sizeof(DYNAMIC_TIME_ZONE_INFORMATION)));
    }

    /// <summary>Validates that the <see cref="DYNAMIC_TIME_ZONE_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DYNAMIC_TIME_ZONE_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DYNAMIC_TIME_ZONE_INFORMATION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DYNAMIC_TIME_ZONE_INFORMATION), Is.EqualTo(432));
    }
}
