// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ktmtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT" /> struct.</summary>
public static unsafe partial class TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENTTests
{
    /// <summary>Validates that the <see cref="TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT>(), Is.EqualTo(sizeof(TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT)));
    }

    /// <summary>Validates that the <see cref="TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TRANSACTION_NOTIFICATION_RECOVERY_ARGUMENT), Is.EqualTo(32));
    }
}
