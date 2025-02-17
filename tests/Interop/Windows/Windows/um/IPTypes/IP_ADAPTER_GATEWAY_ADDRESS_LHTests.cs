// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IP_ADAPTER_GATEWAY_ADDRESS_LH" /> struct.</summary>
public static unsafe partial class IP_ADAPTER_GATEWAY_ADDRESS_LHTests
{
    /// <summary>Validates that the <see cref="IP_ADAPTER_GATEWAY_ADDRESS_LH" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IP_ADAPTER_GATEWAY_ADDRESS_LH>(), Is.EqualTo(sizeof(IP_ADAPTER_GATEWAY_ADDRESS_LH)));
    }

    /// <summary>Validates that the <see cref="IP_ADAPTER_GATEWAY_ADDRESS_LH" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IP_ADAPTER_GATEWAY_ADDRESS_LH).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IP_ADAPTER_GATEWAY_ADDRESS_LH" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IP_ADAPTER_GATEWAY_ADDRESS_LH), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(IP_ADAPTER_GATEWAY_ADDRESS_LH), Is.EqualTo(24));
        }
    }
}
