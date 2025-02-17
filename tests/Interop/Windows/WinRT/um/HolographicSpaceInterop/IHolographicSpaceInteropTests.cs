// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HolographicSpaceInterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="IHolographicSpaceInterop" /> struct.</summary>
[SupportedOSPlatform("windows10.0.15063.0")]
public static unsafe partial class IHolographicSpaceInteropTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IHolographicSpaceInterop" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IHolographicSpaceInterop).GUID, Is.EqualTo(IID_IHolographicSpaceInterop));
    }

    /// <summary>Validates that the <see cref="IHolographicSpaceInterop" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IHolographicSpaceInterop>(), Is.EqualTo(sizeof(IHolographicSpaceInterop)));
    }

    /// <summary>Validates that the <see cref="IHolographicSpaceInterop" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IHolographicSpaceInterop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IHolographicSpaceInterop" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IHolographicSpaceInterop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IHolographicSpaceInterop), Is.EqualTo(4));
        }
    }
}
