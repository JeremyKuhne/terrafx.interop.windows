// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dcommon.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY"]/*' />
public enum D3D_PRIMITIVE_TOPOLOGY
{
    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_UNDEFINED"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_UNDEFINED = 0,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_POINTLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_POINTLIST = 1,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_LINELIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_LINELIST = 2,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_LINESTRIP"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_LINESTRIP = 3,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST = 4,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP = 5,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_LINELIST_ADJ"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_LINELIST_ADJ = 10,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ = 11,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ = 12,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ = 13,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST = 33,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST = 34,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST = 35,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST = 36,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST = 37,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST = 38,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST = 39,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST = 40,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST = 41,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST = 42,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST = 43,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST = 44,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST = 45,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST = 46,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST = 47,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST = 48,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST = 49,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST = 50,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST = 51,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST = 52,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST = 53,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST = 54,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST = 55,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST = 56,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST = 57,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST = 58,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST = 59,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST = 60,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST = 61,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST = 62,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST = 63,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST"]/*' />
    D3D_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST = 64,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_UNDEFINED"]/*' />
    D3D10_PRIMITIVE_TOPOLOGY_UNDEFINED = D3D_PRIMITIVE_TOPOLOGY_UNDEFINED,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_POINTLIST"]/*' />
    D3D10_PRIMITIVE_TOPOLOGY_POINTLIST = D3D_PRIMITIVE_TOPOLOGY_POINTLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_LINELIST"]/*' />
    D3D10_PRIMITIVE_TOPOLOGY_LINELIST = D3D_PRIMITIVE_TOPOLOGY_LINELIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP"]/*' />
    D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP = D3D_PRIMITIVE_TOPOLOGY_LINESTRIP,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST"]/*' />
    D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST = D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP"]/*' />
    D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP = D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_LINELIST_ADJ"]/*' />
    D3D10_PRIMITIVE_TOPOLOGY_LINELIST_ADJ = D3D_PRIMITIVE_TOPOLOGY_LINELIST_ADJ,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ"]/*' />
    D3D10_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ = D3D_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ"]/*' />
    D3D10_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ = D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ"]/*' />
    D3D10_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ = D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_UNDEFINED"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_UNDEFINED = D3D_PRIMITIVE_TOPOLOGY_UNDEFINED,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_POINTLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_POINTLIST = D3D_PRIMITIVE_TOPOLOGY_POINTLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_LINELIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_LINELIST = D3D_PRIMITIVE_TOPOLOGY_LINELIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP = D3D_PRIMITIVE_TOPOLOGY_LINESTRIP,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST = D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP = D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_LINELIST_ADJ"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_LINELIST_ADJ = D3D_PRIMITIVE_TOPOLOGY_LINELIST_ADJ,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ = D3D_PRIMITIVE_TOPOLOGY_LINESTRIP_ADJ,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ = D3D_PRIMITIVE_TOPOLOGY_TRIANGLELIST_ADJ,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ = D3D_PRIMITIVE_TOPOLOGY_TRIANGLESTRIP_ADJ,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_1_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_2_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_3_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_4_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_5_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_6_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_7_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_8_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_9_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_10_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_11_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_12_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_13_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_14_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_15_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_16_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_17_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_18_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_19_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_20_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_21_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_22_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_23_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_24_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_25_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_26_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_27_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_28_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_29_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_30_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_31_CONTROL_POINT_PATCHLIST,

    /// <include file='D3D_PRIMITIVE_TOPOLOGY.xml' path='doc/member[@name="D3D_PRIMITIVE_TOPOLOGY.D3D11_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST"]/*' />
    D3D11_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST = D3D_PRIMITIVE_TOPOLOGY_32_CONTROL_POINT_PATCHLIST,
}
