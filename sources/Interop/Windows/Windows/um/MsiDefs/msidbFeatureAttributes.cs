// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiDefs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum msidbFeatureAttributes
{
    msidbFeatureAttributesFavorLocal = 0x00000000,
    msidbFeatureAttributesFavorSource = 0x00000001,
    msidbFeatureAttributesFollowParent = 0x00000002,
    msidbFeatureAttributesFavorAdvertise = 0x00000004,
    msidbFeatureAttributesDisallowAdvertise = 0x00000008,
    msidbFeatureAttributesUIDisallowAbsent = 0x00000010,
    msidbFeatureAttributesNoUnsupportedAdvertise = 0x00000020,
}
