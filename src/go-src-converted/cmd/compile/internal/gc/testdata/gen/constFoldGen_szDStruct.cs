//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:32:03 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using format = go.go.format_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct szD
        {
            // Constructors
            public szD(NilType _)
            {
                this.name = default;
                this.sn = default;
                this.u = default;
                this.i = default;
            }

            public szD(@string name = default, @string sn = default, slice<ulong> u = default, slice<long> i = default)
            {
                this.name = name;
                this.sn = sn;
                this.u = u;
                this.i = i;
            }

            // Enable comparisons between nil and szD struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(szD value, NilType nil) => value.Equals(default(szD));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(szD value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, szD value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, szD value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator szD(NilType nil) => default(szD);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static szD szD_cast(dynamic value)
        {
            return new szD(value.name, value.sn, value.u, value.i);
        }
    }
}