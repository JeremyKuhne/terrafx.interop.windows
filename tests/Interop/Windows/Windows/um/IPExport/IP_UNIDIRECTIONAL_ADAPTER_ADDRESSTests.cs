// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IP_UNIDIRECTIONAL_ADAPTER_ADDRESS" /> struct.</summary>
public static unsafe partial class IP_UNIDIRECTIONAL_ADAPTER_ADDRESSTests
{
    /// <summary>Validates that the <see cref="IP_UNIDIRECTIONAL_ADAPTER_ADDRESS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IP_UNIDIRECTIONAL_ADAPTER_ADDRESS>(), Is.EqualTo(sizeof(IP_UNIDIRECTIONAL_ADAPTER_ADDRESS)));
    }

    /// <summary>Validates that the <see cref="IP_UNIDIRECTIONAL_ADAPTER_ADDRESS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IP_UNIDIRECTIONAL_ADAPTER_ADDRESS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IP_UNIDIRECTIONAL_ADAPTER_ADDRESS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IP_UNIDIRECTIONAL_ADAPTER_ADDRESS), Is.EqualTo(8));
    }
}
