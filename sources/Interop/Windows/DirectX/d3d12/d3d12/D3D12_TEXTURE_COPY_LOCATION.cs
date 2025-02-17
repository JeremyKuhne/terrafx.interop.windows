// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_TEXTURE_COPY_LOCATION.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_LOCATION"]/*' />
public unsafe partial struct D3D12_TEXTURE_COPY_LOCATION
{
    /// <include file='D3D12_TEXTURE_COPY_LOCATION.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_LOCATION.pResource"]/*' />
    public ID3D12Resource* pResource;

    /// <include file='D3D12_TEXTURE_COPY_LOCATION.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_LOCATION.Type"]/*' />
    public D3D12_TEXTURE_COPY_TYPE Type;

    /// <include file='D3D12_TEXTURE_COPY_LOCATION.xml' path='doc/member[@name="D3D12_TEXTURE_COPY_LOCATION.Anonymous"]/*' />
    [NativeTypeName("D3D12_TEXTURE_COPY_LOCATION::(anonymous union at ./d3d12.h:2941:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.PlacedFootprint"]/*' />
    [UnscopedRef]
    public ref D3D12_PLACED_SUBRESOURCE_FOOTPRINT PlacedFootprint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.PlacedFootprint;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SubresourceIndex"]/*' />
    [UnscopedRef]
    public ref uint SubresourceIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.SubresourceIndex;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.PlacedFootprint"]/*' />
        [FieldOffset(0)]
        public D3D12_PLACED_SUBRESOURCE_FOOTPRINT PlacedFootprint;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SubresourceIndex"]/*' />
        [FieldOffset(0)]
        public uint SubresourceIndex;
    }
}
