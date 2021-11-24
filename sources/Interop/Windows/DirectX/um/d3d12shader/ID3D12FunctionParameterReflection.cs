// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("EC25F42D-7006-4F2B-B33E-02CC3375733F")]
public unsafe partial struct ID3D12FunctionParameterReflection : ID3D12FunctionParameterReflection.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT GetDesc(D3D12_PARAMETER_DESC* pDesc)
    {
        return ((delegate* unmanaged<ID3D12FunctionParameterReflection*, D3D12_PARAMETER_DESC*, int>)(lpVtbl[0]))((ID3D12FunctionParameterReflection*)Unsafe.AsPointer(ref this), pDesc);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        HRESULT GetDesc(D3D12_PARAMETER_DESC* pDesc);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (D3D12_PARAMETER_DESC *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ID3D12FunctionParameterReflection*, D3D12_PARAMETER_DESC*, int> GetDesc;
    }
}
