// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="AUTHENTICATEINFO" /> struct.</summary>
public static unsafe partial class AUTHENTICATEINFOTests
{
    /// <summary>Validates that the <see cref="AUTHENTICATEINFO" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AUTHENTICATEINFO>(), Is.EqualTo(sizeof(AUTHENTICATEINFO)));
    }

    /// <summary>Validates that the <see cref="AUTHENTICATEINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AUTHENTICATEINFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AUTHENTICATEINFO" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AUTHENTICATEINFO), Is.EqualTo(8));
    }
}
