// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IAppxBundleReader" /> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IAppxBundleReaderTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAppxBundleReader" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAppxBundleReader).GUID, Is.EqualTo(IID_IAppxBundleReader));
    }

    /// <summary>Validates that the <see cref="IAppxBundleReader" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAppxBundleReader>(), Is.EqualTo(sizeof(IAppxBundleReader)));
    }

    /// <summary>Validates that the <see cref="IAppxBundleReader" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAppxBundleReader).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IAppxBundleReader" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAppxBundleReader), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAppxBundleReader), Is.EqualTo(4));
        }
    }
}
