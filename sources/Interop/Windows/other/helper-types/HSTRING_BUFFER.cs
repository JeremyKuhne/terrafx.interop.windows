// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HSTRING_BUFFER : IEquatable<HSTRING_BUFFER>
    {
        public readonly nint Value;

        public HSTRING_BUFFER(nint value)
        {
            Value = value;
        }

        public static HSTRING_BUFFER INVALID_VALUE => new HSTRING_BUFFER(-1);

        public static HSTRING_BUFFER NULL => new HSTRING_BUFFER(0);

        public static bool operator ==(HSTRING_BUFFER left, HSTRING_BUFFER right) => left.Value == right.Value;

        public static bool operator !=(HSTRING_BUFFER left, HSTRING_BUFFER right) => left.Value != right.Value;

        public static explicit operator HSTRING_BUFFER(void* value) => new HSTRING_BUFFER((nint)(value));

        public static implicit operator void*(HSTRING_BUFFER value) => (void*)(value.Value);

        public static explicit operator HSTRING_BUFFER(HANDLE value) => new HSTRING_BUFFER(value);

        public static implicit operator HANDLE(HSTRING_BUFFER value) => new HANDLE(value.Value);

        public static explicit operator HSTRING_BUFFER(byte value) => new HSTRING_BUFFER((nint)(value));

        public static explicit operator byte(HSTRING_BUFFER value) => (byte)(value.Value);

        public static explicit operator HSTRING_BUFFER(short value) => new HSTRING_BUFFER((nint)(value));

        public static explicit operator short(HSTRING_BUFFER value) => (short)(value.Value);

        public static explicit operator HSTRING_BUFFER(int value) => new HSTRING_BUFFER((nint)(value));

        public static explicit operator int(HSTRING_BUFFER value) => (int)(value.Value);

        public static explicit operator HSTRING_BUFFER(long value) => new HSTRING_BUFFER((nint)(value));

        public static implicit operator long(HSTRING_BUFFER value) => (long)(value.Value);

        public static explicit operator HSTRING_BUFFER(nint value) => new HSTRING_BUFFER((nint)(value));

        public static implicit operator nint(HSTRING_BUFFER value) => (nint)(value.Value);

        public static explicit operator HSTRING_BUFFER(sbyte value) => new HSTRING_BUFFER((nint)(value));

        public static explicit operator sbyte(HSTRING_BUFFER value) => (sbyte)(value.Value);

        public static explicit operator HSTRING_BUFFER(ushort value) => new HSTRING_BUFFER((nint)(value));

        public static explicit operator ushort(HSTRING_BUFFER value) => (ushort)(value.Value);

        public static explicit operator HSTRING_BUFFER(uint value) => new HSTRING_BUFFER((nint)(value));

        public static explicit operator uint(HSTRING_BUFFER value) => (uint)(value.Value);

        public static explicit operator HSTRING_BUFFER(ulong value) => new HSTRING_BUFFER((nint)(value));

        public static explicit operator ulong(HSTRING_BUFFER value) => (ulong)(value.Value);

        public static explicit operator HSTRING_BUFFER(nuint value) => new HSTRING_BUFFER((nint)(value));

        public static explicit operator nuint(HSTRING_BUFFER value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HSTRING_BUFFER other) && Equals(other);

        public bool Equals(HSTRING_BUFFER other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
