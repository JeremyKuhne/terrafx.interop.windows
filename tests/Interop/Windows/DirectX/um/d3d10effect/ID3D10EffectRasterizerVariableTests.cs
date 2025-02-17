// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="ID3D10EffectRasterizerVariable" /> struct.</summary>
public static unsafe partial class ID3D10EffectRasterizerVariableTests
{
    /// <summary>Validates that the <see cref="ID3D10EffectRasterizerVariable" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID3D10EffectRasterizerVariable>(), Is.EqualTo(sizeof(ID3D10EffectRasterizerVariable)));
    }

    /// <summary>Validates that the <see cref="ID3D10EffectRasterizerVariable" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3D10EffectRasterizerVariable).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ID3D10EffectRasterizerVariable" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3D10EffectRasterizerVariable), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3D10EffectRasterizerVariable), Is.EqualTo(4));
        }
    }
}
