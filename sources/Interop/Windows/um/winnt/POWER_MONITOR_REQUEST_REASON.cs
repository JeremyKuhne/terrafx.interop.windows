// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum POWER_MONITOR_REQUEST_REASON
    {
        MonitorRequestReasonUnknown,
        MonitorRequestReasonPowerButton,
        MonitorRequestReasonRemoteConnection,
        MonitorRequestReasonScMonitorpower,
        MonitorRequestReasonUserInput,
        MonitorRequestReasonAcDcDisplayBurst,
        MonitorRequestReasonUserDisplayBurst,
        MonitorRequestReasonPoSetSystemState,
        MonitorRequestReasonSetThreadExecutionState,
        MonitorRequestReasonFullWake,
        MonitorRequestReasonSessionUnlock,
        MonitorRequestReasonScreenOffRequest,
        MonitorRequestReasonIdleTimeout,
        MonitorRequestReasonPolicyChange,
        MonitorRequestReasonSleepButton,
        MonitorRequestReasonLid,
        MonitorRequestReasonBatteryCountChange,
        MonitorRequestReasonGracePeriod,
        MonitorRequestReasonPnP,
        MonitorRequestReasonDP,
        MonitorRequestReasonSxTransition,
        MonitorRequestReasonSystemIdle,
        MonitorRequestReasonNearProximity,
        MonitorRequestReasonThermalStandby,
        MonitorRequestReasonResumePdc,
        MonitorRequestReasonResumeS4,
        MonitorRequestReasonTerminal,
        MonitorRequestReasonPdcSignal,
        MonitorRequestReasonAcDcDisplayBurstSuppressed,
        MonitorRequestReasonSystemStateEntered,
        MonitorRequestReasonWinrt,
        MonitorRequestReasonUserInputKeyboard,
        MonitorRequestReasonUserInputMouse,
        MonitorRequestReasonUserInputTouch,
        MonitorRequestReasonUserInputPen,
        MonitorRequestReasonUserInputAccelerometer,
        MonitorRequestReasonUserInputHid,
        MonitorRequestReasonUserInputPoUserPresent,
        MonitorRequestReasonUserInputSessionSwitch,
        MonitorRequestReasonUserInputInitialization,
        MonitorRequestReasonPdcSignalWindowsMobilePwrNotif,
        MonitorRequestReasonPdcSignalWindowsMobileShell,
        MonitorRequestReasonPdcSignalHeyCortana,
        MonitorRequestReasonPdcSignalHolographicShell,
        MonitorRequestReasonPdcSignalFingerprint,
        MonitorRequestReasonDirectedDrips,
        MonitorRequestReasonMax,
    }
}
