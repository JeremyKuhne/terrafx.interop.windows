// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMessageFilter" /> struct.</summary>
public static unsafe partial class IMessageFilterTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMessageFilter" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMessageFilter).GUID, Is.EqualTo(IID_IMessageFilter));
    }

    /// <summary>Validates that the <see cref="IMessageFilter" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMessageFilter>(), Is.EqualTo(sizeof(IMessageFilter)));
    }

    /// <summary>Validates that the <see cref="IMessageFilter" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMessageFilter).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMessageFilter" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMessageFilter), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMessageFilter), Is.EqualTo(4));
        }
    }
}
