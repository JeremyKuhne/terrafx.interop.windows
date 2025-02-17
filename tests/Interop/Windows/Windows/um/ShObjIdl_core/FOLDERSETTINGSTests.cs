// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="FOLDERSETTINGS" /> struct.</summary>
public static unsafe partial class FOLDERSETTINGSTests
{
    /// <summary>Validates that the <see cref="FOLDERSETTINGS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FOLDERSETTINGS>(), Is.EqualTo(sizeof(FOLDERSETTINGS)));
    }

    /// <summary>Validates that the <see cref="FOLDERSETTINGS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FOLDERSETTINGS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="FOLDERSETTINGS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FOLDERSETTINGS), Is.EqualTo(8));
    }
}
