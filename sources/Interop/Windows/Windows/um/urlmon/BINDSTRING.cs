// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public enum BINDSTRING
{
    BINDSTRING_HEADERS = 1,
    BINDSTRING_ACCEPT_MIMES = (BINDSTRING_HEADERS + 1),
    BINDSTRING_EXTRA_URL = (BINDSTRING_ACCEPT_MIMES + 1),
    BINDSTRING_LANGUAGE = (BINDSTRING_EXTRA_URL + 1),
    BINDSTRING_USERNAME = (BINDSTRING_LANGUAGE + 1),
    BINDSTRING_PASSWORD = (BINDSTRING_USERNAME + 1),
    BINDSTRING_UA_PIXELS = (BINDSTRING_PASSWORD + 1),
    BINDSTRING_UA_COLOR = (BINDSTRING_UA_PIXELS + 1),
    BINDSTRING_OS = (BINDSTRING_UA_COLOR + 1),
    BINDSTRING_USER_AGENT = (BINDSTRING_OS + 1),
    BINDSTRING_ACCEPT_ENCODINGS = (BINDSTRING_USER_AGENT + 1),
    BINDSTRING_POST_COOKIE = (BINDSTRING_ACCEPT_ENCODINGS + 1),
    BINDSTRING_POST_DATA_MIME = (BINDSTRING_POST_COOKIE + 1),
    BINDSTRING_URL = (BINDSTRING_POST_DATA_MIME + 1),
    BINDSTRING_IID = (BINDSTRING_URL + 1),
    BINDSTRING_FLAG_BIND_TO_OBJECT = (BINDSTRING_IID + 1),
    BINDSTRING_PTR_BIND_CONTEXT = (BINDSTRING_FLAG_BIND_TO_OBJECT + 1),
    BINDSTRING_XDR_ORIGIN = (BINDSTRING_PTR_BIND_CONTEXT + 1),
    BINDSTRING_DOWNLOADPATH = (BINDSTRING_XDR_ORIGIN + 1),
    BINDSTRING_ROOTDOC_URL = (BINDSTRING_DOWNLOADPATH + 1),
    BINDSTRING_INITIAL_FILENAME = (BINDSTRING_ROOTDOC_URL + 1),
    BINDSTRING_PROXY_USERNAME = (BINDSTRING_INITIAL_FILENAME + 1),
    BINDSTRING_PROXY_PASSWORD = (BINDSTRING_PROXY_USERNAME + 1),
    BINDSTRING_ENTERPRISE_ID = (BINDSTRING_PROXY_PASSWORD + 1),
    BINDSTRING_DOC_URL = (BINDSTRING_ENTERPRISE_ID + 1),
    BINDSTRING_SAMESITE_COOKIE_LEVEL = (BINDSTRING_DOC_URL + 1),
}
