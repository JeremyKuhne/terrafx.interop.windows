// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMFMuxStreamAttributesManager" /> struct.</summary>
[SupportedOSPlatform("windows10.0.15063.0")]
public static unsafe partial class IMFMuxStreamAttributesManagerTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFMuxStreamAttributesManager" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFMuxStreamAttributesManager).GUID, Is.EqualTo(IID_IMFMuxStreamAttributesManager));
    }

    /// <summary>Validates that the <see cref="IMFMuxStreamAttributesManager" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFMuxStreamAttributesManager>(), Is.EqualTo(sizeof(IMFMuxStreamAttributesManager)));
    }

    /// <summary>Validates that the <see cref="IMFMuxStreamAttributesManager" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFMuxStreamAttributesManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMFMuxStreamAttributesManager" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFMuxStreamAttributesManager), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFMuxStreamAttributesManager), Is.EqualTo(4));
        }
    }
}
