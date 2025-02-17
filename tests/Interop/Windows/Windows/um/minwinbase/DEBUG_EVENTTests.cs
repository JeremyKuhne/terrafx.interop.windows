// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DEBUG_EVENT" /> struct.</summary>
public static unsafe partial class DEBUG_EVENTTests
{
    /// <summary>Validates that the <see cref="DEBUG_EVENT" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DEBUG_EVENT>(), Is.EqualTo(sizeof(DEBUG_EVENT)));
    }

    /// <summary>Validates that the <see cref="DEBUG_EVENT" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DEBUG_EVENT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DEBUG_EVENT" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DEBUG_EVENT), Is.EqualTo(176));
        }
        else
        {
            Assert.That(sizeof(DEBUG_EVENT), Is.EqualTo(96));
        }
    }
}
