// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IP_ADDR_STRING" /> struct.</summary>
public static unsafe partial class IP_ADDR_STRINGTests
{
    /// <summary>Validates that the <see cref="IP_ADDR_STRING" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IP_ADDR_STRING>(), Is.EqualTo(sizeof(IP_ADDR_STRING)));
    }

    /// <summary>Validates that the <see cref="IP_ADDR_STRING" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IP_ADDR_STRING).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IP_ADDR_STRING" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IP_ADDR_STRING), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(IP_ADDR_STRING), Is.EqualTo(40));
        }
    }
}
