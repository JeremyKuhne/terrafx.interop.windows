// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SFV_SETITEMPOS" /> struct.</summary>
public static unsafe partial class SFV_SETITEMPOSTests
{
    /// <summary>Validates that the <see cref="SFV_SETITEMPOS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SFV_SETITEMPOS>(), Is.EqualTo(sizeof(SFV_SETITEMPOS)));
    }

    /// <summary>Validates that the <see cref="SFV_SETITEMPOS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SFV_SETITEMPOS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SFV_SETITEMPOS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SFV_SETITEMPOS), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(SFV_SETITEMPOS), Is.EqualTo(12));
        }
    }
}
