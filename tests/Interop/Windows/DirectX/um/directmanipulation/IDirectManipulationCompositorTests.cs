// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDirectManipulationCompositor" /> struct.</summary>
[SupportedOSPlatform("windows8.0")]
public static unsafe partial class IDirectManipulationCompositorTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDirectManipulationCompositor" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirectManipulationCompositor).GUID, Is.EqualTo(IID_IDirectManipulationCompositor));
    }

    /// <summary>Validates that the <see cref="IDirectManipulationCompositor" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDirectManipulationCompositor>(), Is.EqualTo(sizeof(IDirectManipulationCompositor)));
    }

    /// <summary>Validates that the <see cref="IDirectManipulationCompositor" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDirectManipulationCompositor).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDirectManipulationCompositor" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDirectManipulationCompositor), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDirectManipulationCompositor), Is.EqualTo(4));
        }
    }
}
