// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SPRECOCONTEXTSTATUS" /> struct.</summary>
public static unsafe partial class SPRECOCONTEXTSTATUSTests
{
    /// <summary>Validates that the <see cref="SPRECOCONTEXTSTATUS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SPRECOCONTEXTSTATUS>(), Is.EqualTo(sizeof(SPRECOCONTEXTSTATUS)));
    }

    /// <summary>Validates that the <see cref="SPRECOCONTEXTSTATUS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SPRECOCONTEXTSTATUS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SPRECOCONTEXTSTATUS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SPRECOCONTEXTSTATUS), Is.EqualTo(524));
    }
}
