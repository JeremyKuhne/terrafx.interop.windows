// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDCompositionDesktopDevice" /> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IDCompositionDesktopDeviceTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDCompositionDesktopDevice" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDCompositionDesktopDevice).GUID, Is.EqualTo(IID_IDCompositionDesktopDevice));
    }

    /// <summary>Validates that the <see cref="IDCompositionDesktopDevice" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDCompositionDesktopDevice>(), Is.EqualTo(sizeof(IDCompositionDesktopDevice)));
    }

    /// <summary>Validates that the <see cref="IDCompositionDesktopDevice" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDCompositionDesktopDevice).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDCompositionDesktopDevice" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDCompositionDesktopDevice), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDCompositionDesktopDevice), Is.EqualTo(4));
        }
    }
}
