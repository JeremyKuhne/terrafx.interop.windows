// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TRANSACTIONMANAGER_BASIC_INFORMATION" /> struct.</summary>
public static unsafe partial class TRANSACTIONMANAGER_BASIC_INFORMATIONTests
{
    /// <summary>Validates that the <see cref="TRANSACTIONMANAGER_BASIC_INFORMATION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TRANSACTIONMANAGER_BASIC_INFORMATION>(), Is.EqualTo(sizeof(TRANSACTIONMANAGER_BASIC_INFORMATION)));
    }

    /// <summary>Validates that the <see cref="TRANSACTIONMANAGER_BASIC_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TRANSACTIONMANAGER_BASIC_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TRANSACTIONMANAGER_BASIC_INFORMATION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TRANSACTIONMANAGER_BASIC_INFORMATION), Is.EqualTo(24));
    }
}
