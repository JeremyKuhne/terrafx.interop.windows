// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SVGPathSegCurvetoCubicSmoothAbs" /> struct.</summary>
public static unsafe partial class SVGPathSegCurvetoCubicSmoothAbsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="SVGPathSegCurvetoCubicSmoothAbs" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(SVGPathSegCurvetoCubicSmoothAbs).GUID, Is.EqualTo(IID_SVGPathSegCurvetoCubicSmoothAbs));
    }

    /// <summary>Validates that the <see cref="SVGPathSegCurvetoCubicSmoothAbs" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SVGPathSegCurvetoCubicSmoothAbs>(), Is.EqualTo(sizeof(SVGPathSegCurvetoCubicSmoothAbs)));
    }

    /// <summary>Validates that the <see cref="SVGPathSegCurvetoCubicSmoothAbs" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SVGPathSegCurvetoCubicSmoothAbs).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SVGPathSegCurvetoCubicSmoothAbs" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SVGPathSegCurvetoCubicSmoothAbs), Is.EqualTo(1));
    }
}
