// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_INDIRECT_ARGUMENT_DESC.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_DESC"]/*' />
public partial struct D3D12_INDIRECT_ARGUMENT_DESC
{
    /// <include file='D3D12_INDIRECT_ARGUMENT_DESC.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_DESC.Type"]/*' />
    public D3D12_INDIRECT_ARGUMENT_TYPE Type;

    /// <include file='D3D12_INDIRECT_ARGUMENT_DESC.xml' path='doc/member[@name="D3D12_INDIRECT_ARGUMENT_DESC.Anonymous"]/*' />
    [NativeTypeName("D3D12_INDIRECT_ARGUMENT_DESC::(anonymous union at ./d3d12.h:4135:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VertexBuffer"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._VertexBuffer_e__Struct VertexBuffer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.VertexBuffer;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Constant"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._Constant_e__Struct Constant
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Constant;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ConstantBufferView"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._ConstantBufferView_e__Struct ConstantBufferView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ConstantBufferView;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ShaderResourceView"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._ShaderResourceView_e__Struct ShaderResourceView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ShaderResourceView;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UnorderedAccessView"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._UnorderedAccessView_e__Struct UnorderedAccessView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.UnorderedAccessView;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.VertexBuffer"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at ./d3d12.h:4137:9)")]
        public _VertexBuffer_e__Struct VertexBuffer;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Constant"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at ./d3d12.h:4141:9)")]
        public _Constant_e__Struct Constant;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ConstantBufferView"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at ./d3d12.h:4147:9)")]
        public _ConstantBufferView_e__Struct ConstantBufferView;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ShaderResourceView"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at ./d3d12.h:4151:9)")]
        public _ShaderResourceView_e__Struct ShaderResourceView;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.UnorderedAccessView"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at ./d3d12.h:4155:9)")]
        public _UnorderedAccessView_e__Struct UnorderedAccessView;

        /// <include file='_VertexBuffer_e__Struct.xml' path='doc/member[@name="_VertexBuffer_e__Struct"]/*' />
        public partial struct _VertexBuffer_e__Struct
        {
            /// <include file='_VertexBuffer_e__Struct.xml' path='doc/member[@name="_VertexBuffer_e__Struct.Slot"]/*' />
            public uint Slot;
        }

        /// <include file='_Constant_e__Struct.xml' path='doc/member[@name="_Constant_e__Struct"]/*' />
        public partial struct _Constant_e__Struct
        {
            /// <include file='_Constant_e__Struct.xml' path='doc/member[@name="_Constant_e__Struct.RootParameterIndex"]/*' />
            public uint RootParameterIndex;

            /// <include file='_Constant_e__Struct.xml' path='doc/member[@name="_Constant_e__Struct.DestOffsetIn32BitValues"]/*' />
            public uint DestOffsetIn32BitValues;

            /// <include file='_Constant_e__Struct.xml' path='doc/member[@name="_Constant_e__Struct.Num32BitValuesToSet"]/*' />
            public uint Num32BitValuesToSet;
        }

        /// <include file='_ConstantBufferView_e__Struct.xml' path='doc/member[@name="_ConstantBufferView_e__Struct"]/*' />
        public partial struct _ConstantBufferView_e__Struct
        {
            /// <include file='_ConstantBufferView_e__Struct.xml' path='doc/member[@name="_ConstantBufferView_e__Struct.RootParameterIndex"]/*' />
            public uint RootParameterIndex;
        }

        /// <include file='_ShaderResourceView_e__Struct.xml' path='doc/member[@name="_ShaderResourceView_e__Struct"]/*' />
        public partial struct _ShaderResourceView_e__Struct
        {
            /// <include file='_ShaderResourceView_e__Struct.xml' path='doc/member[@name="_ShaderResourceView_e__Struct.RootParameterIndex"]/*' />
            public uint RootParameterIndex;
        }

        /// <include file='_UnorderedAccessView_e__Struct.xml' path='doc/member[@name="_UnorderedAccessView_e__Struct"]/*' />
        public partial struct _UnorderedAccessView_e__Struct
        {
            /// <include file='_UnorderedAccessView_e__Struct.xml' path='doc/member[@name="_UnorderedAccessView_e__Struct.RootParameterIndex"]/*' />
            public uint RootParameterIndex;
        }
    }
}
