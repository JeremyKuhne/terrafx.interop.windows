// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="CRYPT_DECRYPT_MESSAGE_PARA" /> struct.</summary>
public static unsafe partial class CRYPT_DECRYPT_MESSAGE_PARATests
{
    /// <summary>Validates that the <see cref="CRYPT_DECRYPT_MESSAGE_PARA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CRYPT_DECRYPT_MESSAGE_PARA>(), Is.EqualTo(sizeof(CRYPT_DECRYPT_MESSAGE_PARA)));
    }

    /// <summary>Validates that the <see cref="CRYPT_DECRYPT_MESSAGE_PARA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CRYPT_DECRYPT_MESSAGE_PARA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="CRYPT_DECRYPT_MESSAGE_PARA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(CRYPT_DECRYPT_MESSAGE_PARA), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(CRYPT_DECRYPT_MESSAGE_PARA), Is.EqualTo(16));
        }
    }
}
