// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HACCEL : IEquatable<HACCEL>
    {
        public readonly nint Value;

        public static HACCEL NULL => (HACCEL)(0);

        public HACCEL(int value)
        {
            Value = ((nint)(value));
        }

        public HACCEL(uint value)
        {
            Value = ((nint)(value));
        }

        public HACCEL(nint value)
        {
            Value = ((nint)(value));
        }

        public HACCEL(nuint value)
        {
            Value = ((nint)(value));
        }

        public HACCEL(void* value)
        {
            Value = ((nint)(value));
        }

        public HACCEL(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HACCEL left, HACCEL right) => left.Value == right.Value;

        public static bool operator !=(HACCEL left, HACCEL right) => left.Value != right.Value;

        public static explicit operator HACCEL(int value) => new HACCEL(value);

        public static explicit operator HACCEL(uint value) => new HACCEL(value);

        public static explicit operator HACCEL(nint value) => new HACCEL(value);

        public static explicit operator HACCEL(nuint value) => new HACCEL(value);

        public static explicit operator HACCEL(void* value) => new HACCEL(value);

        public static explicit operator HACCEL(HANDLE value) => new HACCEL(value);

        public static implicit operator int(HACCEL value) => (int)(value.Value);

        public static implicit operator uint(HACCEL value) => (uint)(value.Value);

        public static implicit operator nint(HACCEL value) => (nint)(value.Value);

        public static implicit operator nuint(HACCEL value) => (nuint)(value.Value);

        public static implicit operator void*(HACCEL value) => (void*)(value.Value);

        public static implicit operator HANDLE(HACCEL value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HACCEL other) && Equals(other);

        public bool Equals(HACCEL other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
