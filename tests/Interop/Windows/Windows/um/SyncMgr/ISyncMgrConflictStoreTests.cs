// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ISyncMgrConflictStore" /> struct.</summary>
public static unsafe partial class ISyncMgrConflictStoreTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISyncMgrConflictStore" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISyncMgrConflictStore).GUID, Is.EqualTo(IID_ISyncMgrConflictStore));
    }

    /// <summary>Validates that the <see cref="ISyncMgrConflictStore" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISyncMgrConflictStore>(), Is.EqualTo(sizeof(ISyncMgrConflictStore)));
    }

    /// <summary>Validates that the <see cref="ISyncMgrConflictStore" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISyncMgrConflictStore).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ISyncMgrConflictStore" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISyncMgrConflictStore), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISyncMgrConflictStore), Is.EqualTo(4));
        }
    }
}
