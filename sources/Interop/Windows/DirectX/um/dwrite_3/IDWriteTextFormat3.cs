// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("6D3B5641-E550-430D-A85B-B7BF48A93427")]
[NativeTypeName("struct IDWriteTextFormat3 : IDWriteTextFormat2")]
[NativeInheritance("IDWriteTextFormat2")]
public unsafe partial struct IDWriteTextFormat3 : IDWriteTextFormat3.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, uint>)(lpVtbl[1]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, uint>)(lpVtbl[2]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetTextAlignment(DWRITE_TEXT_ALIGNMENT textAlignment)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_TEXT_ALIGNMENT, int>)(lpVtbl[3]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), textAlignment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetParagraphAlignment(DWRITE_PARAGRAPH_ALIGNMENT paragraphAlignment)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_PARAGRAPH_ALIGNMENT, int>)(lpVtbl[4]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), paragraphAlignment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetWordWrapping(DWRITE_WORD_WRAPPING wordWrapping)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_WORD_WRAPPING, int>)(lpVtbl[5]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), wordWrapping);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetReadingDirection(DWRITE_READING_DIRECTION readingDirection)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_READING_DIRECTION, int>)(lpVtbl[6]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), readingDirection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetFlowDirection(DWRITE_FLOW_DIRECTION flowDirection)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_FLOW_DIRECTION, int>)(lpVtbl[7]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), flowDirection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetIncrementalTabStop(float incrementalTabStop)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, float, int>)(lpVtbl[8]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), incrementalTabStop);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetTrimming([NativeTypeName("const DWRITE_TRIMMING *")] DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject* trimmingSign)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_TRIMMING*, IDWriteInlineObject*, int>)(lpVtbl[9]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLineSpacing(DWRITE_LINE_SPACING_METHOD lineSpacingMethod, float lineSpacing, float baseline)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_LINE_SPACING_METHOD, float, float, int>)(lpVtbl[10]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public DWRITE_TEXT_ALIGNMENT GetTextAlignment()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_TEXT_ALIGNMENT>)(lpVtbl[11]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public DWRITE_PARAGRAPH_ALIGNMENT GetParagraphAlignment()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_PARAGRAPH_ALIGNMENT>)(lpVtbl[12]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public DWRITE_WORD_WRAPPING GetWordWrapping()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_WORD_WRAPPING>)(lpVtbl[13]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public DWRITE_READING_DIRECTION GetReadingDirection()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_READING_DIRECTION>)(lpVtbl[14]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public DWRITE_FLOW_DIRECTION GetFlowDirection()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_FLOW_DIRECTION>)(lpVtbl[15]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public float GetIncrementalTabStop()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, float>)(lpVtbl[16]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetTrimming(DWRITE_TRIMMING* trimmingOptions, IDWriteInlineObject** trimmingSign)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_TRIMMING*, IDWriteInlineObject**, int>)(lpVtbl[17]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), trimmingOptions, trimmingSign);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT GetLineSpacing(DWRITE_LINE_SPACING_METHOD* lineSpacingMethod, float* lineSpacing, float* baseline)
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int>)(lpVtbl[18]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingMethod, lineSpacing, baseline);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetFontCollection(IDWriteFontCollection** fontCollection)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, IDWriteFontCollection**, int>)(lpVtbl[19]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontCollection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontFamilyNameLength()
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, uint>)(lpVtbl[20]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetFontFamilyName([NativeTypeName("WCHAR *")] ushort* fontFamilyName, [NativeTypeName("UINT32")] uint nameSize)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, ushort*, uint, int>)(lpVtbl[21]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontFamilyName, nameSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public DWRITE_FONT_WEIGHT GetFontWeight()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_FONT_WEIGHT>)(lpVtbl[22]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public DWRITE_FONT_STYLE GetFontStyle()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_FONT_STYLE>)(lpVtbl[23]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public DWRITE_FONT_STRETCH GetFontStretch()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_FONT_STRETCH>)(lpVtbl[24]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public float GetFontSize()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, float>)(lpVtbl[25]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    [return: NativeTypeName("UINT32")]
    public uint GetLocaleNameLength()
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, uint>)(lpVtbl[26]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetLocaleName([NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint nameSize)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, ushort*, uint, int>)(lpVtbl[27]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), localeName, nameSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT SetVerticalGlyphOrientation(DWRITE_VERTICAL_GLYPH_ORIENTATION glyphOrientation)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_VERTICAL_GLYPH_ORIENTATION, int>)(lpVtbl[28]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), glyphOrientation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public DWRITE_VERTICAL_GLYPH_ORIENTATION GetVerticalGlyphOrientation()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_VERTICAL_GLYPH_ORIENTATION>)(lpVtbl[29]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetLastLineWrapping(BOOL isLastLineWrappingEnabled)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, BOOL, int>)(lpVtbl[30]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), isLastLineWrappingEnabled);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public BOOL GetLastLineWrapping()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, int>)(lpVtbl[31]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT SetOpticalAlignment(DWRITE_OPTICAL_ALIGNMENT opticalAlignment)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_OPTICAL_ALIGNMENT, int>)(lpVtbl[32]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), opticalAlignment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public DWRITE_OPTICAL_ALIGNMENT GetOpticalAlignment()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_OPTICAL_ALIGNMENT>)(lpVtbl[33]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT SetFontFallback(IDWriteFontFallback* fontFallback)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, IDWriteFontFallback*, int>)(lpVtbl[34]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontFallback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetFontFallback(IDWriteFontFallback** fontFallback)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, IDWriteFontFallback**, int>)(lpVtbl[35]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontFallback);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT SetLineSpacing([NativeTypeName("const DWRITE_LINE_SPACING *")] DWRITE_LINE_SPACING* lineSpacingOptions)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_LINE_SPACING*, int>)(lpVtbl[36]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT GetLineSpacing(DWRITE_LINE_SPACING* lineSpacingOptions)
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_LINE_SPACING*, int>)(lpVtbl[37]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), lineSpacingOptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT SetFontAxisValues([NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_FONT_AXIS_VALUE*, uint, int>)(lpVtbl[38]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    [return: NativeTypeName("UINT32")]
    public uint GetFontAxisValueCount()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, uint>)(lpVtbl[39]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT GetFontAxisValues(DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_FONT_AXIS_VALUE*, uint, int>)(lpVtbl[40]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), fontAxisValues, fontAxisValueCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public DWRITE_AUTOMATIC_FONT_AXES GetAutomaticFontAxes()
    {
        return ((delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_AUTOMATIC_FONT_AXES>)(lpVtbl[41]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT SetAutomaticFontAxes(DWRITE_AUTOMATIC_FONT_AXES automaticFontAxes)
    {
        return ((delegate* unmanaged<IDWriteTextFormat3*, DWRITE_AUTOMATIC_FONT_AXES, int>)(lpVtbl[42]))((IDWriteTextFormat3*)Unsafe.AsPointer(ref this), automaticFontAxes);
    }

    public interface Interface : IDWriteTextFormat2.Interface
    {
        [VtblIndex(38)]
        HRESULT SetFontAxisValues([NativeTypeName("const DWRITE_FONT_AXIS_VALUE *")] DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount);

        [VtblIndex(39)]
        [return: NativeTypeName("UINT32")]
        uint GetFontAxisValueCount();

        [VtblIndex(40)]
        HRESULT GetFontAxisValues(DWRITE_FONT_AXIS_VALUE* fontAxisValues, [NativeTypeName("UINT32")] uint fontAxisValueCount);

        [VtblIndex(41)]
        DWRITE_AUTOMATIC_FONT_AXES GetAutomaticFontAxes();

        [VtblIndex(42)]
        HRESULT SetAutomaticFontAxes(DWRITE_AUTOMATIC_FONT_AXES automaticFontAxes);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, uint> Release;

        [NativeTypeName("HRESULT (DWRITE_TEXT_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_TEXT_ALIGNMENT, int> SetTextAlignment;

        [NativeTypeName("HRESULT (DWRITE_PARAGRAPH_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_PARAGRAPH_ALIGNMENT, int> SetParagraphAlignment;

        [NativeTypeName("HRESULT (DWRITE_WORD_WRAPPING) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_WORD_WRAPPING, int> SetWordWrapping;

        [NativeTypeName("HRESULT (DWRITE_READING_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_READING_DIRECTION, int> SetReadingDirection;

        [NativeTypeName("HRESULT (DWRITE_FLOW_DIRECTION) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_FLOW_DIRECTION, int> SetFlowDirection;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, float, int> SetIncrementalTabStop;

        [NativeTypeName("HRESULT (const DWRITE_TRIMMING *, IDWriteInlineObject *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_TRIMMING*, IDWriteInlineObject*, int> SetTrimming;

        [NativeTypeName("HRESULT (DWRITE_LINE_SPACING_METHOD, FLOAT, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_LINE_SPACING_METHOD, float, float, int> SetLineSpacing;

        [NativeTypeName("DWRITE_TEXT_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_TEXT_ALIGNMENT> GetTextAlignment;

        [NativeTypeName("DWRITE_PARAGRAPH_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_PARAGRAPH_ALIGNMENT> GetParagraphAlignment;

        [NativeTypeName("DWRITE_WORD_WRAPPING () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_WORD_WRAPPING> GetWordWrapping;

        [NativeTypeName("DWRITE_READING_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_READING_DIRECTION> GetReadingDirection;

        [NativeTypeName("DWRITE_FLOW_DIRECTION () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_FLOW_DIRECTION> GetFlowDirection;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, float> GetIncrementalTabStop;

        [NativeTypeName("HRESULT (DWRITE_TRIMMING *, IDWriteInlineObject **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_TRIMMING*, IDWriteInlineObject**, int> GetTrimming;

        [NativeTypeName("HRESULT (DWRITE_LINE_SPACING_METHOD *, FLOAT *, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_LINE_SPACING_METHOD*, float*, float*, int> GetLineSpacing;

        [NativeTypeName("HRESULT (IDWriteFontCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, IDWriteFontCollection**, int> GetFontCollection;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, uint> GetFontFamilyNameLength;

        [NativeTypeName("HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, ushort*, uint, int> GetFontFamilyName;

        [NativeTypeName("DWRITE_FONT_WEIGHT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_FONT_WEIGHT> GetFontWeight;

        [NativeTypeName("DWRITE_FONT_STYLE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_FONT_STYLE> GetFontStyle;

        [NativeTypeName("DWRITE_FONT_STRETCH () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_FONT_STRETCH> GetFontStretch;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, float> GetFontSize;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, uint> GetLocaleNameLength;

        [NativeTypeName("HRESULT (WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, ushort*, uint, int> GetLocaleName;

        [NativeTypeName("HRESULT (DWRITE_VERTICAL_GLYPH_ORIENTATION) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_VERTICAL_GLYPH_ORIENTATION, int> SetVerticalGlyphOrientation;

        [NativeTypeName("DWRITE_VERTICAL_GLYPH_ORIENTATION () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_VERTICAL_GLYPH_ORIENTATION> GetVerticalGlyphOrientation;

        [NativeTypeName("HRESULT (BOOL) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, BOOL, int> SetLastLineWrapping;

        [NativeTypeName("BOOL () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, int> GetLastLineWrapping;

        [NativeTypeName("HRESULT (DWRITE_OPTICAL_ALIGNMENT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_OPTICAL_ALIGNMENT, int> SetOpticalAlignment;

        [NativeTypeName("DWRITE_OPTICAL_ALIGNMENT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_OPTICAL_ALIGNMENT> GetOpticalAlignment;

        [NativeTypeName("HRESULT (IDWriteFontFallback *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, IDWriteFontFallback*, int> SetFontFallback;

        [NativeTypeName("HRESULT (IDWriteFontFallback **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, IDWriteFontFallback**, int> GetFontFallback;

        [NativeTypeName("HRESULT (const DWRITE_LINE_SPACING *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_LINE_SPACING*, int> SetLineSpacing1;

        [NativeTypeName("HRESULT (DWRITE_LINE_SPACING *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_LINE_SPACING*, int> GetLineSpacing1;

        [NativeTypeName("HRESULT (const DWRITE_FONT_AXIS_VALUE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_FONT_AXIS_VALUE*, uint, int> SetFontAxisValues;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, uint> GetFontAxisValueCount;

        [NativeTypeName("HRESULT (DWRITE_FONT_AXIS_VALUE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_FONT_AXIS_VALUE*, uint, int> GetFontAxisValues;

        [NativeTypeName("DWRITE_AUTOMATIC_FONT_AXES () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged[SuppressGCTransition]<IDWriteTextFormat3*, DWRITE_AUTOMATIC_FONT_AXES> GetAutomaticFontAxes;

        [NativeTypeName("HRESULT (DWRITE_AUTOMATIC_FONT_AXES) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<IDWriteTextFormat3*, DWRITE_AUTOMATIC_FONT_AXES, int> SetAutomaticFontAxes;
    }
}
