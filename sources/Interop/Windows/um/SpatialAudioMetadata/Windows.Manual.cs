// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_ISpatialAudioMetadataClient = new Guid(0x777D4A3B, 0xF6FF, 0x4A26, 0x85, 0xDC, 0x68, 0xD7, 0xCD, 0xED, 0xA1, 0xD4);

        public static readonly Guid IID_ISpatialAudioMetadataCopier = new Guid(0xD224B233, 0xE251, 0x4FD0, 0x9C, 0xA2, 0xD5, 0xEC, 0xF9, 0xA6, 0x84, 0x04);
        
        public static readonly Guid IID_ISpatialAudioMetadataItems = new Guid(0xBCD7C78F, 0x3098, 0x4F22, 0xB5, 0x47, 0xA2, 0xF2, 0x5A, 0x38, 0x12, 0x69);
        
        public static readonly Guid IID_ISpatialAudioMetadataItemsBuffer = new Guid(0x42640A16, 0xE1BD, 0x42D9, 0x9F, 0xF6, 0x03, 0x1A, 0xB7, 0x1A, 0x2D, 0xBA);
        
        public static readonly Guid IID_ISpatialAudioMetadataReader = new Guid(0xB78E86A2, 0x31D9, 0x4C32, 0x94, 0xD2, 0x7D, 0xF4, 0x0F, 0xC7, 0xEB, 0xEC);
        
        public static readonly Guid IID_ISpatialAudioMetadataWriter = new Guid(0x1B17CA01, 0x2955, 0x444D, 0xA4, 0x30, 0x53, 0x7D, 0xC5, 0x89, 0xA8, 0x44);
        
        public static readonly Guid IID_ISpatialAudioObjectForMetadataCommands = new Guid(0x0DF2C94B, 0xF5F9, 0x472D, 0xAF, 0x6B, 0xC4, 0x6E, 0x0A, 0xC9, 0xCD, 0x05);
        
        public static readonly Guid IID_ISpatialAudioObjectForMetadataItems = new Guid(0xDDEA49FF, 0x3BC0, 0x4377, 0x8A, 0xAD, 0x9F, 0xBC, 0xFD, 0x80, 0x85, 0x66);
        
        public static readonly Guid IID_ISpatialAudioObjectRenderStreamForMetadata = new Guid(0xBBC9C907, 0x48D5, 0x4A2E, 0xA0, 0xC7, 0xF7, 0xF0, 0xD6, 0x7C, 0x1F, 0xB1);
    }
}
