// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="AccClientDocMgr" /> struct.</summary>
public static unsafe partial class AccClientDocMgrTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="AccClientDocMgr" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(AccClientDocMgr).GUID, Is.EqualTo(IID_AccClientDocMgr));
    }

    /// <summary>Validates that the <see cref="AccClientDocMgr" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AccClientDocMgr>(), Is.EqualTo(sizeof(AccClientDocMgr)));
    }

    /// <summary>Validates that the <see cref="AccClientDocMgr" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AccClientDocMgr).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AccClientDocMgr" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AccClientDocMgr), Is.EqualTo(1));
    }
}
