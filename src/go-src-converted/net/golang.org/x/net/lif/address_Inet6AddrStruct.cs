//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:51:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using @unsafe = go.@unsafe_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class lif_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Inet6Addr
        {
            // Constructors
            public Inet6Addr(NilType _)
            {
                this.IP = default;
                this.PrefixLen = default;
                this.ZoneID = default;
            }

            public Inet6Addr(array<byte> IP = default, long PrefixLen = default, long ZoneID = default)
            {
                this.IP = IP;
                this.PrefixLen = PrefixLen;
                this.ZoneID = ZoneID;
            }

            // Enable comparisons between nil and Inet6Addr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Inet6Addr value, NilType nil) => value.Equals(default(Inet6Addr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Inet6Addr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Inet6Addr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Inet6Addr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Inet6Addr(NilType nil) => default(Inet6Addr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Inet6Addr Inet6Addr_cast(dynamic value)
        {
            return new Inet6Addr(value.IP, value.PrefixLen, value.ZoneID);
        }
    }
}}}}