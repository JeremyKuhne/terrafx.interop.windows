// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IPinConnection" /> struct.</summary>
public static unsafe partial class IPinConnectionTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IPinConnection" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IPinConnection).GUID, Is.EqualTo(IID_IPinConnection));
    }

    /// <summary>Validates that the <see cref="IPinConnection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IPinConnection>(), Is.EqualTo(sizeof(IPinConnection)));
    }

    /// <summary>Validates that the <see cref="IPinConnection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IPinConnection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IPinConnection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IPinConnection), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IPinConnection), Is.EqualTo(4));
        }
    }
}
