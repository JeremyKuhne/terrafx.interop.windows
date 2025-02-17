// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IEnumDiscMasterFormats" /> struct.</summary>
public static unsafe partial class IEnumDiscMasterFormatsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IEnumDiscMasterFormats" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IEnumDiscMasterFormats).GUID, Is.EqualTo(IID_IEnumDiscMasterFormats));
    }

    /// <summary>Validates that the <see cref="IEnumDiscMasterFormats" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IEnumDiscMasterFormats>(), Is.EqualTo(sizeof(IEnumDiscMasterFormats)));
    }

    /// <summary>Validates that the <see cref="IEnumDiscMasterFormats" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IEnumDiscMasterFormats).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IEnumDiscMasterFormats" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IEnumDiscMasterFormats), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IEnumDiscMasterFormats), Is.EqualTo(4));
        }
    }
}
