// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="QUOTA_LIMITS_EX" /> struct.</summary>
public static unsafe partial class QUOTA_LIMITS_EXTests
{
    /// <summary>Validates that the <see cref="QUOTA_LIMITS_EX" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<QUOTA_LIMITS_EX>(), Is.EqualTo(sizeof(QUOTA_LIMITS_EX)));
    }

    /// <summary>Validates that the <see cref="QUOTA_LIMITS_EX" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(QUOTA_LIMITS_EX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="QUOTA_LIMITS_EX" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(QUOTA_LIMITS_EX), Is.EqualTo(88));
        }
        else
        {
            Assert.That(sizeof(QUOTA_LIMITS_EX), Is.EqualTo(56));
        }
    }
}
