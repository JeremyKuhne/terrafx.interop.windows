// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMAGE_DYNAMIC_RELOCATION32_V2" /> struct.</summary>
public static unsafe partial class IMAGE_DYNAMIC_RELOCATION32_V2Tests
{
    /// <summary>Validates that the <see cref="IMAGE_DYNAMIC_RELOCATION32_V2" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMAGE_DYNAMIC_RELOCATION32_V2>(), Is.EqualTo(sizeof(IMAGE_DYNAMIC_RELOCATION32_V2)));
    }

    /// <summary>Validates that the <see cref="IMAGE_DYNAMIC_RELOCATION32_V2" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMAGE_DYNAMIC_RELOCATION32_V2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMAGE_DYNAMIC_RELOCATION32_V2" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IMAGE_DYNAMIC_RELOCATION32_V2), Is.EqualTo(20));
    }
}
