// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IVMRImagePresenterExclModeConfig" /> struct.</summary>
public static unsafe partial class IVMRImagePresenterExclModeConfigTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IVMRImagePresenterExclModeConfig" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IVMRImagePresenterExclModeConfig).GUID, Is.EqualTo(IID_IVMRImagePresenterExclModeConfig));
    }

    /// <summary>Validates that the <see cref="IVMRImagePresenterExclModeConfig" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IVMRImagePresenterExclModeConfig>(), Is.EqualTo(sizeof(IVMRImagePresenterExclModeConfig)));
    }

    /// <summary>Validates that the <see cref="IVMRImagePresenterExclModeConfig" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IVMRImagePresenterExclModeConfig).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IVMRImagePresenterExclModeConfig" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IVMRImagePresenterExclModeConfig), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IVMRImagePresenterExclModeConfig), Is.EqualTo(4));
        }
    }
}
