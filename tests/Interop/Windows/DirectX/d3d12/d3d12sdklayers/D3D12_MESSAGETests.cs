// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12sdklayers.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="D3D12_MESSAGE" /> struct.</summary>
public static unsafe partial class D3D12_MESSAGETests
{
    /// <summary>Validates that the <see cref="D3D12_MESSAGE" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12_MESSAGE>(), Is.EqualTo(sizeof(D3D12_MESSAGE)));
    }

    /// <summary>Validates that the <see cref="D3D12_MESSAGE" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_MESSAGE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="D3D12_MESSAGE" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D3D12_MESSAGE), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(D3D12_MESSAGE), Is.EqualTo(20));
        }
    }
}
