// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ISearchFolderItemFactory" /> struct.</summary>
public static unsafe partial class ISearchFolderItemFactoryTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISearchFolderItemFactory" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISearchFolderItemFactory).GUID, Is.EqualTo(IID_ISearchFolderItemFactory));
    }

    /// <summary>Validates that the <see cref="ISearchFolderItemFactory" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISearchFolderItemFactory>(), Is.EqualTo(sizeof(ISearchFolderItemFactory)));
    }

    /// <summary>Validates that the <see cref="ISearchFolderItemFactory" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISearchFolderItemFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISearchFolderItemFactory" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISearchFolderItemFactory), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISearchFolderItemFactory), Is.EqualTo(4));
        }
    }
}
