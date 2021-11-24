// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CURSORSHAPE" /> struct.</summary>
public static unsafe partial class CURSORSHAPETests
{
    /// <summary>Validates that the <see cref="CURSORSHAPE" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CURSORSHAPE>(), Is.EqualTo(sizeof(CURSORSHAPE)));
    }

    /// <summary>Validates that the <see cref="CURSORSHAPE" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CURSORSHAPE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CURSORSHAPE" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CURSORSHAPE), Is.EqualTo(24));
    }
}
