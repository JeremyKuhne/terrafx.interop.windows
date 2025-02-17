// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="INTERACTION_ARGUMENTS_MANIPULATION" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class INTERACTION_ARGUMENTS_MANIPULATIONTests
{
    /// <summary>Validates that the <see cref="INTERACTION_ARGUMENTS_MANIPULATION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INTERACTION_ARGUMENTS_MANIPULATION>(), Is.EqualTo(sizeof(INTERACTION_ARGUMENTS_MANIPULATION)));
    }

    /// <summary>Validates that the <see cref="INTERACTION_ARGUMENTS_MANIPULATION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INTERACTION_ARGUMENTS_MANIPULATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="INTERACTION_ARGUMENTS_MANIPULATION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(INTERACTION_ARGUMENTS_MANIPULATION), Is.EqualTo(60));
    }
}
