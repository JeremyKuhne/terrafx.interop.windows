// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RAYTRACING_GEOMETRY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_DESC"]/*' />
public partial struct D3D12_RAYTRACING_GEOMETRY_DESC
{
    /// <include file='D3D12_RAYTRACING_GEOMETRY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_DESC.Type"]/*' />
    public D3D12_RAYTRACING_GEOMETRY_TYPE Type;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_DESC.Flags"]/*' />
    public D3D12_RAYTRACING_GEOMETRY_FLAGS Flags;

    /// <include file='D3D12_RAYTRACING_GEOMETRY_DESC.xml' path='doc/member[@name="D3D12_RAYTRACING_GEOMETRY_DESC.Anonymous"]/*' />
    [NativeTypeName("D3D12_RAYTRACING_GEOMETRY_DESC::(anonymous union at ./d3d12.h:13295:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Triangles"]/*' />
    [UnscopedRef]
    public ref D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC Triangles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Triangles;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AABBs"]/*' />
    [UnscopedRef]
    public ref D3D12_RAYTRACING_GEOMETRY_AABBS_DESC AABBs
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.AABBs;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Triangles"]/*' />
        [FieldOffset(0)]
        public D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC Triangles;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.AABBs"]/*' />
        [FieldOffset(0)]
        public D3D12_RAYTRACING_GEOMETRY_AABBS_DESC AABBs;
    }
}
