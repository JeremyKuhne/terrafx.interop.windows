// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="D3D12_HEAP_PROPERTIES" /> struct.</summary>
public static unsafe partial class D3D12_HEAP_PROPERTIESTests
{
    /// <summary>Validates that the <see cref="D3D12_HEAP_PROPERTIES" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12_HEAP_PROPERTIES>(), Is.EqualTo(sizeof(D3D12_HEAP_PROPERTIES)));
    }

    /// <summary>Validates that the <see cref="D3D12_HEAP_PROPERTIES" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_HEAP_PROPERTIES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="D3D12_HEAP_PROPERTIES" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D12_HEAP_PROPERTIES), Is.EqualTo(20));
    }
}
