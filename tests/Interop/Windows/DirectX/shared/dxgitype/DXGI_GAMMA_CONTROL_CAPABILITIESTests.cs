// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="DXGI_GAMMA_CONTROL_CAPABILITIES" /> struct.</summary>
public static unsafe partial class DXGI_GAMMA_CONTROL_CAPABILITIESTests
{
    /// <summary>Validates that the <see cref="DXGI_GAMMA_CONTROL_CAPABILITIES" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DXGI_GAMMA_CONTROL_CAPABILITIES>(), Is.EqualTo(sizeof(DXGI_GAMMA_CONTROL_CAPABILITIES)));
    }

    /// <summary>Validates that the <see cref="DXGI_GAMMA_CONTROL_CAPABILITIES" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DXGI_GAMMA_CONTROL_CAPABILITIES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DXGI_GAMMA_CONTROL_CAPABILITIES" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DXGI_GAMMA_CONTROL_CAPABILITIES), Is.EqualTo(4116));
    }
}
