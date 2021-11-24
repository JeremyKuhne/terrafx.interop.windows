// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("E6176F96-E373-4801-B223-3B62C068C0B4")]
[NativeTypeName("struct ISpeechPhraseElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechPhraseElement : ISpeechPhraseElement.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, uint>)(lpVtbl[1]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, uint>)(lpVtbl[2]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, uint*, int>)(lpVtbl[3]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_AudioTimeOffset([NativeTypeName("long *")] int* AudioTimeOffset)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, int*, int>)(lpVtbl[7]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), AudioTimeOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AudioSizeTime([NativeTypeName("long *")] int* AudioSizeTime)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, int*, int>)(lpVtbl[8]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), AudioSizeTime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_AudioStreamOffset([NativeTypeName("long *")] int* AudioStreamOffset)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, int*, int>)(lpVtbl[9]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), AudioStreamOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AudioSizeBytes([NativeTypeName("long *")] int* AudioSizeBytes)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, int*, int>)(lpVtbl[10]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), AudioSizeBytes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_RetainedStreamOffset([NativeTypeName("long *")] int* RetainedStreamOffset)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, int*, int>)(lpVtbl[11]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), RetainedStreamOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RetainedSizeBytes([NativeTypeName("long *")] int* RetainedSizeBytes)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, int*, int>)(lpVtbl[12]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), RetainedSizeBytes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_DisplayText([NativeTypeName("BSTR *")] ushort** DisplayText)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, ushort**, int>)(lpVtbl[13]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), DisplayText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_LexicalForm([NativeTypeName("BSTR *")] ushort** LexicalForm)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, ushort**, int>)(lpVtbl[14]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), LexicalForm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Pronunciation(VARIANT* Pronunciation)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, VARIANT*, int>)(lpVtbl[15]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), Pronunciation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_DisplayAttributes(SpeechDisplayAttributes* DisplayAttributes)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, SpeechDisplayAttributes*, int>)(lpVtbl[16]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), DisplayAttributes);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_RequiredConfidence(SpeechEngineConfidence* RequiredConfidence)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, SpeechEngineConfidence*, int>)(lpVtbl[17]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), RequiredConfidence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ActualConfidence(SpeechEngineConfidence* ActualConfidence)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, SpeechEngineConfidence*, int>)(lpVtbl[18]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), ActualConfidence);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_EngineConfidence(float* EngineConfidence)
    {
        return ((delegate* unmanaged<ISpeechPhraseElement*, float*, int>)(lpVtbl[19]))((ISpeechPhraseElement*)Unsafe.AsPointer(ref this), EngineConfidence);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_AudioTimeOffset([NativeTypeName("long *")] int* AudioTimeOffset);

        [VtblIndex(8)]
        HRESULT get_AudioSizeTime([NativeTypeName("long *")] int* AudioSizeTime);

        [VtblIndex(9)]
        HRESULT get_AudioStreamOffset([NativeTypeName("long *")] int* AudioStreamOffset);

        [VtblIndex(10)]
        HRESULT get_AudioSizeBytes([NativeTypeName("long *")] int* AudioSizeBytes);

        [VtblIndex(11)]
        HRESULT get_RetainedStreamOffset([NativeTypeName("long *")] int* RetainedStreamOffset);

        [VtblIndex(12)]
        HRESULT get_RetainedSizeBytes([NativeTypeName("long *")] int* RetainedSizeBytes);

        [VtblIndex(13)]
        HRESULT get_DisplayText([NativeTypeName("BSTR *")] ushort** DisplayText);

        [VtblIndex(14)]
        HRESULT get_LexicalForm([NativeTypeName("BSTR *")] ushort** LexicalForm);

        [VtblIndex(15)]
        HRESULT get_Pronunciation(VARIANT* Pronunciation);

        [VtblIndex(16)]
        HRESULT get_DisplayAttributes(SpeechDisplayAttributes* DisplayAttributes);

        [VtblIndex(17)]
        HRESULT get_RequiredConfidence(SpeechEngineConfidence* RequiredConfidence);

        [VtblIndex(18)]
        HRESULT get_ActualConfidence(SpeechEngineConfidence* ActualConfidence);

        [VtblIndex(19)]
        HRESULT get_EngineConfidence(float* EngineConfidence);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, uint> Release;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, int*, int> get_AudioTimeOffset;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, int*, int> get_AudioSizeTime;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, int*, int> get_AudioStreamOffset;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, int*, int> get_AudioSizeBytes;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, int*, int> get_RetainedStreamOffset;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, int*, int> get_RetainedSizeBytes;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, ushort**, int> get_DisplayText;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, ushort**, int> get_LexicalForm;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, VARIANT*, int> get_Pronunciation;

        [NativeTypeName("HRESULT (SpeechDisplayAttributes *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, SpeechDisplayAttributes*, int> get_DisplayAttributes;

        [NativeTypeName("HRESULT (SpeechEngineConfidence *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, SpeechEngineConfidence*, int> get_RequiredConfidence;

        [NativeTypeName("HRESULT (SpeechEngineConfidence *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, SpeechEngineConfidence*, int> get_ActualConfidence;

        [NativeTypeName("HRESULT (float *) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpeechPhraseElement*, float*, int> get_EngineConfidence;
    }
}
