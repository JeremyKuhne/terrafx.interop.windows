// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="DWRITE_STRIKETHROUGH" /> struct.</summary>
public static unsafe partial class DWRITE_STRIKETHROUGHTests
{
    /// <summary>Validates that the <see cref="DWRITE_STRIKETHROUGH" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DWRITE_STRIKETHROUGH>(), Is.EqualTo(sizeof(DWRITE_STRIKETHROUGH)));
    }

    /// <summary>Validates that the <see cref="DWRITE_STRIKETHROUGH" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DWRITE_STRIKETHROUGH).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DWRITE_STRIKETHROUGH" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DWRITE_STRIKETHROUGH), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(DWRITE_STRIKETHROUGH), Is.EqualTo(28));
        }
    }
}
