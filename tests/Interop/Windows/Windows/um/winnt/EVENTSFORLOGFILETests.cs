// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="EVENTSFORLOGFILE" /> struct.</summary>
public static unsafe partial class EVENTSFORLOGFILETests
{
    /// <summary>Validates that the <see cref="EVENTSFORLOGFILE" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<EVENTSFORLOGFILE>(), Is.EqualTo(sizeof(EVENTSFORLOGFILE)));
    }

    /// <summary>Validates that the <see cref="EVENTSFORLOGFILE" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(EVENTSFORLOGFILE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="EVENTSFORLOGFILE" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(EVENTSFORLOGFILE), Is.EqualTo(576));
    }
}
