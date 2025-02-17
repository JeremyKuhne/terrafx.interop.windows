// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dcommon.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE"]/*' />
public enum D3D_INTERPOLATION_MODE
{
    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_UNDEFINED"]/*' />
    D3D_INTERPOLATION_UNDEFINED = 0,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_CONSTANT"]/*' />
    D3D_INTERPOLATION_CONSTANT = 1,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_LINEAR"]/*' />
    D3D_INTERPOLATION_LINEAR = 2,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_LINEAR_CENTROID"]/*' />
    D3D_INTERPOLATION_LINEAR_CENTROID = 3,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE"]/*' />
    D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE = 4,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_CENTROID"]/*' />
    D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_CENTROID = 5,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_LINEAR_SAMPLE"]/*' />
    D3D_INTERPOLATION_LINEAR_SAMPLE = 6,

    /// <include file='D3D_INTERPOLATION_MODE.xml' path='doc/member[@name="D3D_INTERPOLATION_MODE.D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_SAMPLE"]/*' />
    D3D_INTERPOLATION_LINEAR_NOPERSPECTIVE_SAMPLE = 7,
}
