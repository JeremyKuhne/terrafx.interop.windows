// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SP_DRVINFO_DATA64_V1_W" /> struct.</summary>
public static unsafe partial class SP_DRVINFO_DATA64_V1_WTests
{
    /// <summary>Validates that the <see cref="SP_DRVINFO_DATA64_V1_W" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SP_DRVINFO_DATA64_V1_W>(), Is.EqualTo(sizeof(SP_DRVINFO_DATA64_V1_W)));
    }

    /// <summary>Validates that the <see cref="SP_DRVINFO_DATA64_V1_W" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SP_DRVINFO_DATA64_V1_W).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SP_DRVINFO_DATA64_V1_W" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SP_DRVINFO_DATA64_V1_W), Is.EqualTo(1552));
        }
        else
        {
            Assert.That(sizeof(SP_DRVINFO_DATA64_V1_W), Is.EqualTo(1548));
        }
    }
}
