// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IShellItemArray" /> struct.</summary>
public static unsafe partial class IShellItemArrayTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IShellItemArray" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IShellItemArray).GUID, Is.EqualTo(IID_IShellItemArray));
    }

    /// <summary>Validates that the <see cref="IShellItemArray" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IShellItemArray>(), Is.EqualTo(sizeof(IShellItemArray)));
    }

    /// <summary>Validates that the <see cref="IShellItemArray" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IShellItemArray).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IShellItemArray" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IShellItemArray), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IShellItemArray), Is.EqualTo(4));
        }
    }
}
