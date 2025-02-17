// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapo.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="XAPO_PROCESS_BUFFER_PARAMETERS" /> struct.</summary>
public static unsafe partial class XAPO_PROCESS_BUFFER_PARAMETERSTests
{
    /// <summary>Validates that the <see cref="XAPO_PROCESS_BUFFER_PARAMETERS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<XAPO_PROCESS_BUFFER_PARAMETERS>(), Is.EqualTo(sizeof(XAPO_PROCESS_BUFFER_PARAMETERS)));
    }

    /// <summary>Validates that the <see cref="XAPO_PROCESS_BUFFER_PARAMETERS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(XAPO_PROCESS_BUFFER_PARAMETERS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="XAPO_PROCESS_BUFFER_PARAMETERS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(XAPO_PROCESS_BUFFER_PARAMETERS), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(XAPO_PROCESS_BUFFER_PARAMETERS), Is.EqualTo(12));
        }
    }
}
