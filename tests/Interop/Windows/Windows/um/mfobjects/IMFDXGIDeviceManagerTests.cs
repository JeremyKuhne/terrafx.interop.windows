// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMFDXGIDeviceManager" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IMFDXGIDeviceManagerTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFDXGIDeviceManager" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFDXGIDeviceManager).GUID, Is.EqualTo(IID_IMFDXGIDeviceManager));
    }

    /// <summary>Validates that the <see cref="IMFDXGIDeviceManager" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFDXGIDeviceManager>(), Is.EqualTo(sizeof(IMFDXGIDeviceManager)));
    }

    /// <summary>Validates that the <see cref="IMFDXGIDeviceManager" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFDXGIDeviceManager).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMFDXGIDeviceManager" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFDXGIDeviceManager), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFDXGIDeviceManager), Is.EqualTo(4));
        }
    }
}
