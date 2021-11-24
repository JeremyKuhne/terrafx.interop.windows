// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MFT_OUTPUT_DATA_BUFFER" /> struct.</summary>
public static unsafe partial class MFT_OUTPUT_DATA_BUFFERTests
{
    /// <summary>Validates that the <see cref="MFT_OUTPUT_DATA_BUFFER" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFT_OUTPUT_DATA_BUFFER>(), Is.EqualTo(sizeof(MFT_OUTPUT_DATA_BUFFER)));
    }

    /// <summary>Validates that the <see cref="MFT_OUTPUT_DATA_BUFFER" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFT_OUTPUT_DATA_BUFFER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MFT_OUTPUT_DATA_BUFFER" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MFT_OUTPUT_DATA_BUFFER), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(MFT_OUTPUT_DATA_BUFFER), Is.EqualTo(16));
        }
    }
}
