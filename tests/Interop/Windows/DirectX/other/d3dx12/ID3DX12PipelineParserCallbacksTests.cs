// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in the microsoft/DirectX-Graphics-Samples tag v10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="ID3DX12PipelineParserCallbacks" /> struct.</summary>
public static unsafe partial class ID3DX12PipelineParserCallbacksTests
{
    /// <summary>Validates that the <see cref="ID3DX12PipelineParserCallbacks" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ID3DX12PipelineParserCallbacks>(), Is.EqualTo(sizeof(ID3DX12PipelineParserCallbacks)));
    }

    /// <summary>Validates that the <see cref="ID3DX12PipelineParserCallbacks" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ID3DX12PipelineParserCallbacks).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ID3DX12PipelineParserCallbacks" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ID3DX12PipelineParserCallbacks), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ID3DX12PipelineParserCallbacks), Is.EqualTo(4));
        }
    }
}
