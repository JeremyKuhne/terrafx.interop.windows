// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public partial struct D3D10_EFFECT_DESC
{
    public BOOL IsChildEffect;

    public uint ConstantBuffers;

    public uint SharedConstantBuffers;

    public uint GlobalVariables;

    public uint SharedGlobalVariables;

    public uint Techniques;
}
