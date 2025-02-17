// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SCHANNEL_CERT_HASH" /> struct.</summary>
public static unsafe partial class SCHANNEL_CERT_HASHTests
{
    /// <summary>Validates that the <see cref="SCHANNEL_CERT_HASH" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SCHANNEL_CERT_HASH>(), Is.EqualTo(sizeof(SCHANNEL_CERT_HASH)));
    }

    /// <summary>Validates that the <see cref="SCHANNEL_CERT_HASH" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SCHANNEL_CERT_HASH).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SCHANNEL_CERT_HASH" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SCHANNEL_CERT_HASH), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(SCHANNEL_CERT_HASH), Is.EqualTo(32));
        }
    }
}
