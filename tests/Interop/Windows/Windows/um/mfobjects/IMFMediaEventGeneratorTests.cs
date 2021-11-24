// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMFMediaEventGenerator" /> struct.</summary>
public static unsafe partial class IMFMediaEventGeneratorTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFMediaEventGenerator" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFMediaEventGenerator).GUID, Is.EqualTo(IID_IMFMediaEventGenerator));
    }

    /// <summary>Validates that the <see cref="IMFMediaEventGenerator" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFMediaEventGenerator>(), Is.EqualTo(sizeof(IMFMediaEventGenerator)));
    }

    /// <summary>Validates that the <see cref="IMFMediaEventGenerator" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFMediaEventGenerator).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMFMediaEventGenerator" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFMediaEventGenerator), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFMediaEventGenerator), Is.EqualTo(4));
        }
    }
}
