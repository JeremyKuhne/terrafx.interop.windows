// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CERT_BASIC_CONSTRAINTS_INFO" /> struct.</summary>
public static unsafe partial class CERT_BASIC_CONSTRAINTS_INFOTests
{
    /// <summary>Validates that the <see cref="CERT_BASIC_CONSTRAINTS_INFO" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CERT_BASIC_CONSTRAINTS_INFO>(), Is.EqualTo(sizeof(CERT_BASIC_CONSTRAINTS_INFO)));
    }

    /// <summary>Validates that the <see cref="CERT_BASIC_CONSTRAINTS_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CERT_BASIC_CONSTRAINTS_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CERT_BASIC_CONSTRAINTS_INFO" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CERT_BASIC_CONSTRAINTS_INFO), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(CERT_BASIC_CONSTRAINTS_INFO), Is.EqualTo(28));
        }
    }
}
