// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="D3D11_TILED_RESOURCE_COORDINATE" /> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class D3D11_TILED_RESOURCE_COORDINATETests
{
    /// <summary>Validates that the <see cref="D3D11_TILED_RESOURCE_COORDINATE" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D11_TILED_RESOURCE_COORDINATE>(), Is.EqualTo(sizeof(D3D11_TILED_RESOURCE_COORDINATE)));
    }

    /// <summary>Validates that the <see cref="D3D11_TILED_RESOURCE_COORDINATE" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D11_TILED_RESOURCE_COORDINATE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="D3D11_TILED_RESOURCE_COORDINATE" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D11_TILED_RESOURCE_COORDINATE), Is.EqualTo(16));
    }
}
