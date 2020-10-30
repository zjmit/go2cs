//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:30 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

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
                this.Namlen = default;
                this.Type = default;
                this.Unused1 = default;
                this.Unused2 = default;
                this.Name = default;
            }

            public Dirent(ulong Fileno = default, ushort Namlen = default, byte Type = default, byte Unused1 = default, uint Unused2 = default, array<sbyte> Name = default)
            {
                this.Fileno = Fileno;
                this.Namlen = Namlen;
                this.Type = Type;
                this.Unused1 = Unused1;
                this.Unused2 = Unused2;
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
            return new Dirent(value.Fileno, value.Namlen, value.Type, value.Unused1, value.Unused2, value.Name);
        }
    }
}}}}}}