// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WS_POLICY_CONSTRAINTS" /> struct.</summary>
public static unsafe partial class WS_POLICY_CONSTRAINTSTests
{
    /// <summary>Validates that the <see cref="WS_POLICY_CONSTRAINTS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WS_POLICY_CONSTRAINTS>(), Is.EqualTo(sizeof(WS_POLICY_CONSTRAINTS)));
    }

    /// <summary>Validates that the <see cref="WS_POLICY_CONSTRAINTS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WS_POLICY_CONSTRAINTS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WS_POLICY_CONSTRAINTS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WS_POLICY_CONSTRAINTS), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(WS_POLICY_CONSTRAINTS), Is.EqualTo(24));
        }
    }
}
