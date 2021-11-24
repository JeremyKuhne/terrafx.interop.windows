// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct WS_TCP_SSPI_USERNAME_SECURITY_CONTEXT_POLICY_DESCRIPTION
{
    public WS_CHANNEL_PROPERTIES channelProperties;

    public WS_SECURITY_PROPERTIES securityProperties;

    public WS_SSPI_TRANSPORT_SECURITY_BINDING_POLICY_DESCRIPTION sspiTransportSecurityBinding;

    public WS_USERNAME_MESSAGE_SECURITY_BINDING_POLICY_DESCRIPTION usernameMessageSecurityBinding;

    public WS_SECURITY_CONTEXT_SECURITY_BINDING_POLICY_DESCRIPTION securityContextSecurityBinding;
}
