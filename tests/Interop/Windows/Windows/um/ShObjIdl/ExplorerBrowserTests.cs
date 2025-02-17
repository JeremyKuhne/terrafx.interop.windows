// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ExplorerBrowser" /> struct.</summary>
public static unsafe partial class ExplorerBrowserTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ExplorerBrowser" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ExplorerBrowser).GUID, Is.EqualTo(IID_ExplorerBrowser));
    }

    /// <summary>Validates that the <see cref="ExplorerBrowser" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ExplorerBrowser>(), Is.EqualTo(sizeof(ExplorerBrowser)));
    }

    /// <summary>Validates that the <see cref="ExplorerBrowser" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ExplorerBrowser).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ExplorerBrowser" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ExplorerBrowser), Is.EqualTo(1));
    }
}
