// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMFContentDecryptionModuleAccess" /> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class IMFContentDecryptionModuleAccessTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFContentDecryptionModuleAccess" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFContentDecryptionModuleAccess).GUID, Is.EqualTo(IID_IMFContentDecryptionModuleAccess));
    }

    /// <summary>Validates that the <see cref="IMFContentDecryptionModuleAccess" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFContentDecryptionModuleAccess>(), Is.EqualTo(sizeof(IMFContentDecryptionModuleAccess)));
    }

    /// <summary>Validates that the <see cref="IMFContentDecryptionModuleAccess" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFContentDecryptionModuleAccess).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMFContentDecryptionModuleAccess" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFContentDecryptionModuleAccess), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFContentDecryptionModuleAccess), Is.EqualTo(4));
        }
    }
}
