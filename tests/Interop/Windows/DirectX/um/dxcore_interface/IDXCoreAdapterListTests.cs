// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDXCoreAdapterList" /> struct.</summary>
[SupportedOSPlatform("windows10.0.19041.0")]
public static unsafe partial class IDXCoreAdapterListTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXCoreAdapterList" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDXCoreAdapterList).GUID, Is.EqualTo(IID_IDXCoreAdapterList));
    }

    /// <summary>Validates that the <see cref="IDXCoreAdapterList" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDXCoreAdapterList>(), Is.EqualTo(sizeof(IDXCoreAdapterList)));
    }

    /// <summary>Validates that the <see cref="IDXCoreAdapterList" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDXCoreAdapterList).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDXCoreAdapterList" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDXCoreAdapterList), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDXCoreAdapterList), Is.EqualTo(4));
        }
    }
}
