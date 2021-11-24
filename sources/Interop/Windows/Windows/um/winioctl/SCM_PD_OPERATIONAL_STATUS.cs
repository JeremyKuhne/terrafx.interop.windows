// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum SCM_PD_OPERATIONAL_STATUS
{
    ScmPhysicalDeviceOpStatus_Unknown = 0,
    ScmPhysicalDeviceOpStatus_Ok,
    ScmPhysicalDeviceOpStatus_PredictingFailure,
    ScmPhysicalDeviceOpStatus_InService,
    ScmPhysicalDeviceOpStatus_HardwareError,
    ScmPhysicalDeviceOpStatus_NotUsable,
    ScmPhysicalDeviceOpStatus_TransientError,
    ScmPhysicalDeviceOpStatus_Missing,
    ScmPhysicalDeviceOpStatus_Max,
}
