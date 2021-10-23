// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PSAPI_WORKING_SET_INFORMATION" /> struct.</summary>
    public static unsafe partial class PSAPI_WORKING_SET_INFORMATIONTests
    {
        /// <summary>Validates that the <see cref="PSAPI_WORKING_SET_INFORMATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PSAPI_WORKING_SET_INFORMATION>(), Is.EqualTo(sizeof(PSAPI_WORKING_SET_INFORMATION)));
        }

        /// <summary>Validates that the <see cref="PSAPI_WORKING_SET_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PSAPI_WORKING_SET_INFORMATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PSAPI_WORKING_SET_INFORMATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PSAPI_WORKING_SET_INFORMATION), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(PSAPI_WORKING_SET_INFORMATION), Is.EqualTo(12));
            }
        }
    }
}
