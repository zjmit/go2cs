//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Dirent
        {
            // Constructors
            public Dirent(NilType _)
            {
                this.Ino = default;
                this.Seekoff = default;
                this.Reclen = default;
                this.Namlen = default;
                this.Type = default;
                this.Name = default;
                this.Pad_cgo_0 = default;
            }

            public Dirent(ulong Ino = default, ulong Seekoff = default, ushort Reclen = default, ushort Namlen = default, byte Type = default, array<sbyte> Name = default, array<byte> Pad_cgo_0 = default)
            {
                this.Ino = Ino;
                this.Seekoff = Seekoff;
                this.Reclen = Reclen;
                this.Namlen = Namlen;
                this.Type = Type;
                this.Name = Name;
                this.Pad_cgo_0 = Pad_cgo_0;
            }

            // Enable comparisons between nil and Dirent struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Dirent value, NilType nil) => value.Equals(default(Dirent));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Dirent value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Dirent value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Dirent value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Dirent(NilType nil) => default(Dirent);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Dirent Dirent_cast(dynamic value)
        {
            return new Dirent(value.Ino, value.Seekoff, value.Reclen, value.Namlen, value.Type, value.Name, value.Pad_cgo_0);
        }
    }
}