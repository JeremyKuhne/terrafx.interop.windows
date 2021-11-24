// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDWriteTextAnalysisSink1" /> struct.</summary>
public static unsafe partial class IDWriteTextAnalysisSink1Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDWriteTextAnalysisSink1" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDWriteTextAnalysisSink1).GUID, Is.EqualTo(IID_IDWriteTextAnalysisSink1));
    }

    /// <summary>Validates that the <see cref="IDWriteTextAnalysisSink1" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDWriteTextAnalysisSink1>(), Is.EqualTo(sizeof(IDWriteTextAnalysisSink1)));
    }

    /// <summary>Validates that the <see cref="IDWriteTextAnalysisSink1" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDWriteTextAnalysisSink1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IDWriteTextAnalysisSink1" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDWriteTextAnalysisSink1), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDWriteTextAnalysisSink1), Is.EqualTo(4));
        }
    }
}
