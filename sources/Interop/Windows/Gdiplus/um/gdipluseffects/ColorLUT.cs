// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;

/// <include file='ColorLUT.xml' path='doc/member[@name="ColorLUT"]/*' />
[NativeTypeName("struct ColorLUT : Effect")]
[NativeInheritance("Effect")]
public unsafe partial struct ColorLUT
{
    public Effect Base;

    public int GetAuxDataSize()
    {
        return Base.GetAuxDataSize();
    }

    public void* GetAuxData()
    {
        return Base.GetAuxData();
    }

    public void UseAuxData([NativeTypeName("const BOOL")] BOOL useAuxDataFlag)
    {
        Base.UseAuxData(useAuxDataFlag);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus GetParameterSize(uint* size)
    {
        return Base.GetParameterSize(size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus SetParameters([NativeTypeName("const void *")] void* @params, [NativeTypeName("const UINT")] uint size)
    {
        return Base.SetParameters(@params, size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus GetParameters(uint* size, void* @params)
    {
        return Base.GetParameters(size, @params);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus SetParameters([NativeTypeName("const Gdiplus::ColorLUTParams *")] ColorLUTParams* lut)
    {
        uint size = 1024;

        return Base.SetParameters(lut, size);
    }

    [return: NativeTypeName("Gdiplus::Status")]
    public GpStatus GetParameters(uint* size, [NativeTypeName("Gdiplus::ColorLUTParams *")] ColorLUTParams* lut)
    {
        return Base.GetParameters(size, unchecked((void*)(lut)));
    }
}
