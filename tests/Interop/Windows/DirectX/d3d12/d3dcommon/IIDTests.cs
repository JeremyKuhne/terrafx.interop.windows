// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dcommon.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IID" /> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref="IID_ID3D10Blob" /> property is correct.</summary>
    [Test]
    public static void IID_ID3D10BlobTest()
    {
        Assert.That(IID_ID3D10Blob, Is.EqualTo(new Guid(0x8ba5fb08, 0x5195, 0x40e2, 0xac, 0x58, 0xd, 0x98, 0x9c, 0x3a, 0x1, 0x2)));
    }
}
