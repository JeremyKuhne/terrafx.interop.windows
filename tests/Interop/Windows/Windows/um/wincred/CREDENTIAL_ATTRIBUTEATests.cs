// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CREDENTIAL_ATTRIBUTEA" /> struct.</summary>
public static unsafe partial class CREDENTIAL_ATTRIBUTEATests
{
    /// <summary>Validates that the <see cref="CREDENTIAL_ATTRIBUTEA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CREDENTIAL_ATTRIBUTEA>(), Is.EqualTo(sizeof(CREDENTIAL_ATTRIBUTEA)));
    }

    /// <summary>Validates that the <see cref="CREDENTIAL_ATTRIBUTEA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CREDENTIAL_ATTRIBUTEA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CREDENTIAL_ATTRIBUTEA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CREDENTIAL_ATTRIBUTEA), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(CREDENTIAL_ATTRIBUTEA), Is.EqualTo(16));
        }
    }
}
