// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="PPM_WMI_IDLE_STATE" /> struct.</summary>
public static unsafe partial class PPM_WMI_IDLE_STATETests
{
    /// <summary>Validates that the <see cref="PPM_WMI_IDLE_STATE" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PPM_WMI_IDLE_STATE>(), Is.EqualTo(sizeof(PPM_WMI_IDLE_STATE)));
    }

    /// <summary>Validates that the <see cref="PPM_WMI_IDLE_STATE" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PPM_WMI_IDLE_STATE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="PPM_WMI_IDLE_STATE" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PPM_WMI_IDLE_STATE), Is.EqualTo(32));
    }
}
