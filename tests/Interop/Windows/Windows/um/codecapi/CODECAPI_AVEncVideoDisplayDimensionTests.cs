// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CODECAPI_AVEncVideoDisplayDimension" /> struct.</summary>
public static unsafe partial class CODECAPI_AVEncVideoDisplayDimensionTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="CODECAPI_AVEncVideoDisplayDimension" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(CODECAPI_AVEncVideoDisplayDimension).GUID, Is.EqualTo(IID_CODECAPI_AVEncVideoDisplayDimension));
    }

    /// <summary>Validates that the <see cref="CODECAPI_AVEncVideoDisplayDimension" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CODECAPI_AVEncVideoDisplayDimension>(), Is.EqualTo(sizeof(CODECAPI_AVEncVideoDisplayDimension)));
    }

    /// <summary>Validates that the <see cref="CODECAPI_AVEncVideoDisplayDimension" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CODECAPI_AVEncVideoDisplayDimension).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CODECAPI_AVEncVideoDisplayDimension" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CODECAPI_AVEncVideoDisplayDimension), Is.EqualTo(1));
    }
}
