// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WbemContext" /> struct.</summary>
public static unsafe partial class WbemContextTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="WbemContext" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(WbemContext).GUID, Is.EqualTo(IID_WbemContext));
    }

    /// <summary>Validates that the <see cref="WbemContext" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WbemContext>(), Is.EqualTo(sizeof(WbemContext)));
    }

    /// <summary>Validates that the <see cref="WbemContext" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WbemContext).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WbemContext" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WbemContext), Is.EqualTo(1));
    }
}
