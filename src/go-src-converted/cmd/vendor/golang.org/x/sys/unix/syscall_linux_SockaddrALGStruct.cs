//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:47:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using binary = go.encoding.binary_package;
using runtime = go.runtime_package;
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
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SockaddrALG
        {
            // Constructors
            public SockaddrALG(NilType _)
            {
                this.Type = default;
                this.Name = default;
                this.Feature = default;
                this.Mask = default;
                this.raw = default;
            }

            public SockaddrALG(@string Type = default, @string Name = default, uint Feature = default, uint Mask = default, RawSockaddrALG raw = default)
            {
                this.Type = Type;
                this.Name = Name;
                this.Feature = Feature;
                this.Mask = Mask;
                this.raw = raw;
            }

            // Enable comparisons between nil and SockaddrALG struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockaddrALG value, NilType nil) => value.Equals(default(SockaddrALG));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockaddrALG value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockaddrALG value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockaddrALG value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockaddrALG(NilType nil) => default(SockaddrALG);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockaddrALG SockaddrALG_cast(dynamic value)
        {
            return new SockaddrALG(value.Type, value.Name, value.Feature, value.Mask, value.raw);
        }
    }
}}}}}}