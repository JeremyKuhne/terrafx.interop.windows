// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="DXGI_ADAPTER_DESC2" /> struct.</summary>
public static unsafe partial class DXGI_ADAPTER_DESC2Tests
{
    /// <summary>Validates that the <see cref="DXGI_ADAPTER_DESC2" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXGI_ADAPTER_DESC2>(), Is.EqualTo(sizeof(DXGI_ADAPTER_DESC2)));
    }

    /// <summary>Validates that the <see cref="DXGI_ADAPTER_DESC2" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXGI_ADAPTER_DESC2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DXGI_ADAPTER_DESC2" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DXGI_ADAPTER_DESC2), Is.EqualTo(320));
        }
        else
        {
            Assert.That(sizeof(DXGI_ADAPTER_DESC2), Is.EqualTo(304));
        }
    }
}
