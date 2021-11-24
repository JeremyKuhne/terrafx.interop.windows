// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDWriteTextAnalyzer2" /> struct.</summary>
[SupportedOSPlatform("windows8.1")]
public static unsafe partial class IDWriteTextAnalyzer2Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDWriteTextAnalyzer2" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteTextAnalyzer2).GUID, Is.EqualTo(IID_IDWriteTextAnalyzer2));
    }

    /// <summary>Validates that the <see cref="IDWriteTextAnalyzer2" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteTextAnalyzer2>(), Is.EqualTo(sizeof(IDWriteTextAnalyzer2)));
    }

    /// <summary>Validates that the <see cref="IDWriteTextAnalyzer2" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteTextAnalyzer2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDWriteTextAnalyzer2" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteTextAnalyzer2), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteTextAnalyzer2), Is.EqualTo(4));
        }
    }
}
