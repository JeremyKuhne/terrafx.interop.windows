// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMAGE_DATA_DIRECTORY" /> struct.</summary>
public static unsafe partial class IMAGE_DATA_DIRECTORYTests
{
    /// <summary>Validates that the <see cref="IMAGE_DATA_DIRECTORY" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMAGE_DATA_DIRECTORY>(), Is.EqualTo(sizeof(IMAGE_DATA_DIRECTORY)));
    }

    /// <summary>Validates that the <see cref="IMAGE_DATA_DIRECTORY" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGE_DATA_DIRECTORY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMAGE_DATA_DIRECTORY" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGE_DATA_DIRECTORY), Is.EqualTo(8));
    }
}
