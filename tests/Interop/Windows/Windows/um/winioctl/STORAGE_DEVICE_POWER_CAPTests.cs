// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="STORAGE_DEVICE_POWER_CAP" /> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class STORAGE_DEVICE_POWER_CAPTests
{
    /// <summary>Validates that the <see cref="STORAGE_DEVICE_POWER_CAP" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STORAGE_DEVICE_POWER_CAP>(), Is.EqualTo(sizeof(STORAGE_DEVICE_POWER_CAP)));
    }

    /// <summary>Validates that the <see cref="STORAGE_DEVICE_POWER_CAP" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_DEVICE_POWER_CAP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="STORAGE_DEVICE_POWER_CAP" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_DEVICE_POWER_CAP), Is.EqualTo(24));
    }
}
