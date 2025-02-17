// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IContact.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IContactPropertyCollection" /> struct.</summary>
public static unsafe partial class IContactPropertyCollectionTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IContactPropertyCollection" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IContactPropertyCollection).GUID, Is.EqualTo(IID_IContactPropertyCollection));
    }

    /// <summary>Validates that the <see cref="IContactPropertyCollection" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IContactPropertyCollection>(), Is.EqualTo(sizeof(IContactPropertyCollection)));
    }

    /// <summary>Validates that the <see cref="IContactPropertyCollection" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IContactPropertyCollection).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IContactPropertyCollection" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IContactPropertyCollection), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IContactPropertyCollection), Is.EqualTo(4));
        }
    }
}
