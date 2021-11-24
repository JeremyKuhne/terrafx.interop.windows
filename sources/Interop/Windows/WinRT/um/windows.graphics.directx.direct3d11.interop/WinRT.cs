// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.graphics.directx.direct3d11.interop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;

public static unsafe partial class WinRT
{
    [DllImport("d3d11", ExactSpelling = true)]
    public static extern HRESULT CreateDirect3D11DeviceFromDXGIDevice(IDXGIDevice* dxgiDevice, IInspectable** graphicsDevice);

    [DllImport("d3d11", ExactSpelling = true)]
    public static extern HRESULT CreateDirect3D11SurfaceFromDXGISurface(IDXGISurface* dgxiSurface, IInspectable** graphicsSurface);
}
