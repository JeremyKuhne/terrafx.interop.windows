// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMFMediaEngineTransferSource" /> struct.</summary>
public static unsafe partial class IMFMediaEngineTransferSourceTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFMediaEngineTransferSource" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFMediaEngineTransferSource).GUID, Is.EqualTo(IID_IMFMediaEngineTransferSource));
    }

    /// <summary>Validates that the <see cref="IMFMediaEngineTransferSource" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFMediaEngineTransferSource>(), Is.EqualTo(sizeof(IMFMediaEngineTransferSource)));
    }

    /// <summary>Validates that the <see cref="IMFMediaEngineTransferSource" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFMediaEngineTransferSource).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMFMediaEngineTransferSource" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFMediaEngineTransferSource), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFMediaEngineTransferSource), Is.EqualTo(4));
        }
    }
}
