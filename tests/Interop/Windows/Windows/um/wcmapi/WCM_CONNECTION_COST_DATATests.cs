// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WCM_CONNECTION_COST_DATA" /> struct.</summary>
[SupportedOSPlatform("windows8.0")]
public static unsafe partial class WCM_CONNECTION_COST_DATATests
{
    /// <summary>Validates that the <see cref="WCM_CONNECTION_COST_DATA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WCM_CONNECTION_COST_DATA>(), Is.EqualTo(sizeof(WCM_CONNECTION_COST_DATA)));
    }

    /// <summary>Validates that the <see cref="WCM_CONNECTION_COST_DATA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WCM_CONNECTION_COST_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WCM_CONNECTION_COST_DATA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WCM_CONNECTION_COST_DATA), Is.EqualTo(8));
    }
}
