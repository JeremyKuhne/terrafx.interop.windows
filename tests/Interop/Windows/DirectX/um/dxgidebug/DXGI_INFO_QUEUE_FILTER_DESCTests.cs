// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="DXGI_INFO_QUEUE_FILTER_DESC" /> struct.</summary>
[SupportedOSPlatform("windows8.0")]
public static unsafe partial class DXGI_INFO_QUEUE_FILTER_DESCTests
{
    /// <summary>Validates that the <see cref="DXGI_INFO_QUEUE_FILTER_DESC" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXGI_INFO_QUEUE_FILTER_DESC>(), Is.EqualTo(sizeof(DXGI_INFO_QUEUE_FILTER_DESC)));
    }

    /// <summary>Validates that the <see cref="DXGI_INFO_QUEUE_FILTER_DESC" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXGI_INFO_QUEUE_FILTER_DESC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DXGI_INFO_QUEUE_FILTER_DESC" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DXGI_INFO_QUEUE_FILTER_DESC), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(DXGI_INFO_QUEUE_FILTER_DESC), Is.EqualTo(24));
        }
    }
}
