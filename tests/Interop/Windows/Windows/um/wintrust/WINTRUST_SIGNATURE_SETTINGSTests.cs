// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WINTRUST_SIGNATURE_SETTINGS" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class WINTRUST_SIGNATURE_SETTINGSTests
{
    /// <summary>Validates that the <see cref="WINTRUST_SIGNATURE_SETTINGS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WINTRUST_SIGNATURE_SETTINGS>(), Is.EqualTo(sizeof(WINTRUST_SIGNATURE_SETTINGS)));
    }

    /// <summary>Validates that the <see cref="WINTRUST_SIGNATURE_SETTINGS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINTRUST_SIGNATURE_SETTINGS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WINTRUST_SIGNATURE_SETTINGS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WINTRUST_SIGNATURE_SETTINGS), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(WINTRUST_SIGNATURE_SETTINGS), Is.EqualTo(24));
        }
    }
}
