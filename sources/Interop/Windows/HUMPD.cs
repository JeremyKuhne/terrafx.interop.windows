// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUMPD : IEquatable<HUMPD>
    {
        public readonly nint Value;

        public static HUMPD NULL => (HUMPD)(0);

        public HUMPD(int value)
        {
            Value = ((nint)(value));
        }

        public HUMPD(uint value)
        {
            Value = ((nint)(value));
        }

        public HUMPD(nint value)
        {
            Value = ((nint)(value));
        }

        public HUMPD(nuint value)
        {
            Value = ((nint)(value));
        }

        public HUMPD(void* value)
        {
            Value = ((nint)(value));
        }

        public HUMPD(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HUMPD left, HUMPD right) => left.Value == right.Value;

        public static bool operator !=(HUMPD left, HUMPD right) => left.Value != right.Value;

        public static explicit operator HUMPD(int value) => new HUMPD(value);

        public static explicit operator HUMPD(uint value) => new HUMPD(value);

        public static explicit operator HUMPD(nint value) => new HUMPD(value);

        public static explicit operator HUMPD(nuint value) => new HUMPD(value);

        public static explicit operator HUMPD(void* value) => new HUMPD(value);

        public static explicit operator HUMPD(HANDLE value) => new HUMPD(value);

        public static implicit operator int(HUMPD value) => (int)(value.Value);

        public static implicit operator uint(HUMPD value) => (uint)(value.Value);

        public static implicit operator nint(HUMPD value) => (nint)(value.Value);

        public static implicit operator nuint(HUMPD value) => (nuint)(value.Value);

        public static implicit operator void*(HUMPD value) => (void*)(value.Value);

        public static implicit operator HANDLE(HUMPD value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HUMPD other) && Equals(other);

        public bool Equals(HUMPD other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
