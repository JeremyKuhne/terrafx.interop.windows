// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMediaSample2Config" /> struct.</summary>
public static unsafe partial class IMediaSample2ConfigTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMediaSample2Config" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMediaSample2Config).GUID, Is.EqualTo(IID_IMediaSample2Config));
    }

    /// <summary>Validates that the <see cref="IMediaSample2Config" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMediaSample2Config>(), Is.EqualTo(sizeof(IMediaSample2Config)));
    }

    /// <summary>Validates that the <see cref="IMediaSample2Config" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMediaSample2Config).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMediaSample2Config" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMediaSample2Config), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMediaSample2Config), Is.EqualTo(4));
        }
    }
}
