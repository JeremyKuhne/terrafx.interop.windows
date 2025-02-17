// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDWriteFontFace3" /> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class IDWriteFontFace3Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDWriteFontFace3" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteFontFace3).GUID, Is.EqualTo(IID_IDWriteFontFace3));
    }

    /// <summary>Validates that the <see cref="IDWriteFontFace3" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteFontFace3>(), Is.EqualTo(sizeof(IDWriteFontFace3)));
    }

    /// <summary>Validates that the <see cref="IDWriteFontFace3" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteFontFace3).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDWriteFontFace3" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteFontFace3), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteFontFace3), Is.EqualTo(4));
        }
    }
}
