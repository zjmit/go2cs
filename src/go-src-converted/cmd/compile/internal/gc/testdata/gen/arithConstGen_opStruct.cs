//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:32:00 UTC
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
using strings = go.strings_package;
using template = go.text.template_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct op
        {
            // Constructors
            public op(NilType _)
            {
                this.name = default;
                this.symbol = default;
            }

            public op(@string name = default, @string symbol = default)
            {
                this.name = name;
                this.symbol = symbol;
            }

            // Enable comparisons between nil and op struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(op value, NilType nil) => value.Equals(default(op));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(op value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, op value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, op value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator op(NilType nil) => default(op);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static op op_cast(dynamic value)
        {
            return new op(value.name, value.symbol);
        }
    }
}