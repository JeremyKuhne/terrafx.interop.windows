// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMAGE_OTHER_RUNTIME_FUNCTION_ENTRY" /> struct.</summary>
    public static unsafe partial class IMAGE_OTHER_RUNTIME_FUNCTION_ENTRYTests
    {
        /// <summary>Validates that the <see cref="IMAGE_OTHER_RUNTIME_FUNCTION_ENTRY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMAGE_OTHER_RUNTIME_FUNCTION_ENTRY>(), Is.EqualTo(sizeof(IMAGE_OTHER_RUNTIME_FUNCTION_ENTRY)));
        }

        /// <summary>Validates that the <see cref="IMAGE_OTHER_RUNTIME_FUNCTION_ENTRY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMAGE_OTHER_RUNTIME_FUNCTION_ENTRY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMAGE_OTHER_RUNTIME_FUNCTION_ENTRY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(IMAGE_OTHER_RUNTIME_FUNCTION_ENTRY), Is.EqualTo(12));
        }
    }
}
