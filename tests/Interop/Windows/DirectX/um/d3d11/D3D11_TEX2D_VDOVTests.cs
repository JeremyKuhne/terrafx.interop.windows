// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="D3D11_TEX2D_VDOV" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class D3D11_TEX2D_VDOVTests
{
    /// <summary>Validates that the <see cref="D3D11_TEX2D_VDOV" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D11_TEX2D_VDOV>(), Is.EqualTo(sizeof(D3D11_TEX2D_VDOV)));
    }

    /// <summary>Validates that the <see cref="D3D11_TEX2D_VDOV" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D11_TEX2D_VDOV).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="D3D11_TEX2D_VDOV" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D11_TEX2D_VDOV), Is.EqualTo(4));
    }
}
