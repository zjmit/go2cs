//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Dirent
        {
            // Constructors
            public Dirent(NilType _)
            {
                this.Fileno = default;
                this.Off = default;
                this.Reclen = default;
                this.Type = default;
                this.Pad0 = default;
                this.Namlen = default;
                this.Pad1 = default;
                this.Name = default;
            }

            public Dirent(ulong Fileno = default, long Off = default, ushort Reclen = default, byte Type = default, byte Pad0 = default, ushort Namlen = default, ushort Pad1 = default, array<sbyte> Name = default)
            {
                this.Fileno = Fileno;
                this.Off = Off;
                this.Reclen = Reclen;
                this.Type = Type;
                this.Pad0 = Pad0;
                this.Namlen = Namlen;
                this.Pad1 = Pad1;
                this.Name = Name;
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
            return new Dirent(value.Fileno, value.Off, value.Reclen, value.Type, value.Pad0, value.Namlen, value.Pad1, value.Name);
        }
    }
}}}}}}