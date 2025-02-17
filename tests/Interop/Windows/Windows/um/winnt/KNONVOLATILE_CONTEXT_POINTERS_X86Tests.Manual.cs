// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="KNONVOLATILE_CONTEXT_POINTERS_X86" /> struct.</summary>
public static unsafe partial class KNONVOLATILE_CONTEXT_POINTERS_X86Tests
{
    /// <summary>Validates that the <see cref="KNONVOLATILE_CONTEXT_POINTERS_X86" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<KNONVOLATILE_CONTEXT_POINTERS_X86>(), Is.EqualTo(sizeof(KNONVOLATILE_CONTEXT_POINTERS_X86)));
    }

    /// <summary>Validates that the <see cref="KNONVOLATILE_CONTEXT_POINTERS_X86" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KNONVOLATILE_CONTEXT_POINTERS_X86).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="KNONVOLATILE_CONTEXT_POINTERS_X86" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(KNONVOLATILE_CONTEXT_POINTERS_X86), Is.EqualTo(4));
    }
}
