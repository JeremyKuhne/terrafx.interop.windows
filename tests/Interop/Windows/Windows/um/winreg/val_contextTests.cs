// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winreg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="val_context" /> struct.</summary>
public static unsafe partial class val_contextTests
{
    /// <summary>Validates that the <see cref="val_context" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<val_context>(), Is.EqualTo(sizeof(val_context)));
    }

    /// <summary>Validates that the <see cref="val_context" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(val_context).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="val_context" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(val_context), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(val_context), Is.EqualTo(12));
        }
    }
}
