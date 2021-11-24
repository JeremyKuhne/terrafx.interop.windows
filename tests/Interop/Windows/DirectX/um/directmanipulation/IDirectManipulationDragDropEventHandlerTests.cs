// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDirectManipulationDragDropEventHandler" /> struct.</summary>
[SupportedOSPlatform("windows8.1")]
public static unsafe partial class IDirectManipulationDragDropEventHandlerTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDirectManipulationDragDropEventHandler" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirectManipulationDragDropEventHandler).GUID, Is.EqualTo(IID_IDirectManipulationDragDropEventHandler));
    }

    /// <summary>Validates that the <see cref="IDirectManipulationDragDropEventHandler" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDirectManipulationDragDropEventHandler>(), Is.EqualTo(sizeof(IDirectManipulationDragDropEventHandler)));
    }

    /// <summary>Validates that the <see cref="IDirectManipulationDragDropEventHandler" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDirectManipulationDragDropEventHandler).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDirectManipulationDragDropEventHandler" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDirectManipulationDragDropEventHandler), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDirectManipulationDragDropEventHandler), Is.EqualTo(4));
        }
    }
}
