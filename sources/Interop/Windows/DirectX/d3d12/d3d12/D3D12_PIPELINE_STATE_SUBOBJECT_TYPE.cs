// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE"]/*' />
public enum D3D12_PIPELINE_STATE_SUBOBJECT_TYPE
{
    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE = 0,

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VS"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VS = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_ROOT_SIGNATURE + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PS"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PS = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VS + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DS"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DS = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PS + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_HS"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_HS = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DS + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_GS"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_GS = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_HS + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CS"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CS = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_GS + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CS + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_BLEND"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_BLEND = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_STREAM_OUTPUT + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_MASK"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_MASK = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_BLEND + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_MASK + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RASTERIZER + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_INPUT_LAYOUT + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_IB_STRIP_CUT_VALUE + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_PRIMITIVE_TOPOLOGY + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_RENDER_TARGET_FORMATS + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL_FORMAT + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_NODE_MASK"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_NODE_MASK = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_SAMPLE_DESC + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CACHED_PSO"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CACHED_PSO = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_NODE_MASK + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_FLAGS"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_FLAGS = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_CACHED_PSO + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1 = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_FLAGS + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_VIEW_INSTANCING = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_DEPTH_STENCIL1 + 1),

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_AS"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_AS = 24,

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS = 25,

    /// <include file='D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_SUBOBJECT_TYPE.D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MAX_VALID"]/*' />
    D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MAX_VALID = (D3D12_PIPELINE_STATE_SUBOBJECT_TYPE_MS + 1),
}
