//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 09:30:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct utd64
        {
            // Constructors
            public utd64(NilType _)
            {
                this.a = default;
                this.b = default;
                this.add = default;
                this.sub = default;
                this.mul = default;
                this.div = default;
                this.mod = default;
            }

            public utd64(ulong a = default, ulong b = default, ulong add = default, ulong sub = default, ulong mul = default, ulong div = default, ulong mod = default)
            {
                this.a = a;
                this.b = b;
                this.add = add;
                this.sub = sub;
                this.mul = mul;
                this.div = div;
                this.mod = mod;
            }

            // Enable comparisons between nil and utd64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(utd64 value, NilType nil) => value.Equals(default(utd64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(utd64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, utd64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, utd64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator utd64(NilType nil) => default(utd64);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static utd64 utd64_cast(dynamic value)
        {
            return new utd64(value.a, value.b, value.add, value.sub, value.mul, value.div, value.mod);
        }
    }
}