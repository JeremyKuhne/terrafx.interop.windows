// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="D3D12_ROOT_DESCRIPTOR_TABLE" /> struct.</summary>
public static unsafe partial class D3D12_ROOT_DESCRIPTOR_TABLETests
{
    /// <summary>Validates that the <see cref="D3D12_ROOT_DESCRIPTOR_TABLE" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12_ROOT_DESCRIPTOR_TABLE>(), Is.EqualTo(sizeof(D3D12_ROOT_DESCRIPTOR_TABLE)));
    }

    /// <summary>Validates that the <see cref="D3D12_ROOT_DESCRIPTOR_TABLE" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_ROOT_DESCRIPTOR_TABLE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="D3D12_ROOT_DESCRIPTOR_TABLE" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D12_ROOT_DESCRIPTOR_TABLE), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(D3D12_ROOT_DESCRIPTOR_TABLE), Is.EqualTo(8));
        }
    }
}
