// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IBindHost" /> struct.</summary>
public static unsafe partial class IBindHostTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IBindHost" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IBindHost).GUID, Is.EqualTo(IID_IBindHost));
    }

    /// <summary>Validates that the <see cref="IBindHost" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IBindHost>(), Is.EqualTo(sizeof(IBindHost)));
    }

    /// <summary>Validates that the <see cref="IBindHost" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IBindHost).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IBindHost" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IBindHost), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IBindHost), Is.EqualTo(4));
        }
    }
}
