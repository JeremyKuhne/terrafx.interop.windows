// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MFASYNCRESULT" /> struct.</summary>
public static unsafe partial class MFASYNCRESULTTests
{
    /// <summary>Validates that the <see cref="MFASYNCRESULT" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFASYNCRESULT>(), Is.EqualTo(sizeof(MFASYNCRESULT)));
    }

    /// <summary>Validates that the <see cref="MFASYNCRESULT" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFASYNCRESULT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MFASYNCRESULT" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MFASYNCRESULT), Is.EqualTo(64));
        }
        else
        {
            Assert.That(sizeof(MFASYNCRESULT), Is.EqualTo(40));
        }
    }
}
