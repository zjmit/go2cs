//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:57 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using net = go.net_package;
using syscall = go.syscall_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class windows_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Protoent
        {
            // Constructors
            public Protoent(NilType _)
            {
                this.Name = default;
                this.Aliases = default;
                this.Proto = default;
            }

            public Protoent(ref ptr<byte> Name = default, ref ptr<ptr<byte>> Aliases = default, ushort Proto = default)
            {
                this.Name = Name;
                this.Aliases = Aliases;
                this.Proto = Proto;
            }

            // Enable comparisons between nil and Protoent struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Protoent value, NilType nil) => value.Equals(default(Protoent));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Protoent value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Protoent value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Protoent value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Protoent(NilType nil) => default(Protoent);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Protoent Protoent_cast(dynamic value)
        {
            return new Protoent(ref value.Name, ref value.Aliases, value.Proto);
        }
    }
}}}}}}