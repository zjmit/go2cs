//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct keventt
        {
            // Constructors
            public keventt(NilType _)
            {
                this.ident = default;
                this.filter = default;
                this.flags = default;
                this.fflags = default;
                this.data = default;
                this.udata = default;
            }

            public keventt(ulong ident = default, short filter = default, ushort flags = default, uint fflags = default, long data = default, ref ptr<byte> udata = default)
            {
                this.ident = ident;
                this.filter = filter;
                this.flags = flags;
                this.fflags = fflags;
                this.data = data;
                this.udata = udata;
            }

            // Enable comparisons between nil and keventt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(keventt value, NilType nil) => value.Equals(default(keventt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(keventt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, keventt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, keventt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator keventt(NilType nil) => default(keventt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static keventt keventt_cast(dynamic value)
        {
            return new keventt(value.ident, value.filter, value.flags, value.fflags, value.data, ref value.udata);
        }
    }
}