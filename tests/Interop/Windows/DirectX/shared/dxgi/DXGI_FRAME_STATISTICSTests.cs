// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="DXGI_FRAME_STATISTICS" /> struct.</summary>
public static unsafe partial class DXGI_FRAME_STATISTICSTests
{
    /// <summary>Validates that the <see cref="DXGI_FRAME_STATISTICS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXGI_FRAME_STATISTICS>(), Is.EqualTo(sizeof(DXGI_FRAME_STATISTICS)));
    }

    /// <summary>Validates that the <see cref="DXGI_FRAME_STATISTICS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXGI_FRAME_STATISTICS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DXGI_FRAME_STATISTICS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DXGI_FRAME_STATISTICS), Is.EqualTo(32));
    }
}
