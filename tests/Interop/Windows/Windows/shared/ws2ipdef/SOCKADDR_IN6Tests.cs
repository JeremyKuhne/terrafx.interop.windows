// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SOCKADDR_IN6" /> struct.</summary>
public static unsafe partial class SOCKADDR_IN6Tests
{
    /// <summary>Validates that the <see cref="SOCKADDR_IN6" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SOCKADDR_IN6>(), Is.EqualTo(sizeof(SOCKADDR_IN6)));
    }

    /// <summary>Validates that the <see cref="SOCKADDR_IN6" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SOCKADDR_IN6).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SOCKADDR_IN6" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SOCKADDR_IN6), Is.EqualTo(28));
    }
}
