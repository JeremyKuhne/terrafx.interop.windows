// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/useractivityinterop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="IUserActivitySourceHostInterop" /> struct.</summary>
public static unsafe partial class IUserActivitySourceHostInteropTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IUserActivitySourceHostInterop" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IUserActivitySourceHostInterop).GUID, Is.EqualTo(IID_IUserActivitySourceHostInterop));
    }

    /// <summary>Validates that the <see cref="IUserActivitySourceHostInterop" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IUserActivitySourceHostInterop>(), Is.EqualTo(sizeof(IUserActivitySourceHostInterop)));
    }

    /// <summary>Validates that the <see cref="IUserActivitySourceHostInterop" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IUserActivitySourceHostInterop).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IUserActivitySourceHostInterop" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IUserActivitySourceHostInterop), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IUserActivitySourceHostInterop), Is.EqualTo(4));
        }
    }
}
