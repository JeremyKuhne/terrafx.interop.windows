// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TAPE_SET_POSITION" /> struct.</summary>
public static unsafe partial class TAPE_SET_POSITIONTests
{
    /// <summary>Validates that the <see cref="TAPE_SET_POSITION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TAPE_SET_POSITION>(), Is.EqualTo(sizeof(TAPE_SET_POSITION)));
    }

    /// <summary>Validates that the <see cref="TAPE_SET_POSITION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TAPE_SET_POSITION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TAPE_SET_POSITION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TAPE_SET_POSITION), Is.EqualTo(24));
    }
}
