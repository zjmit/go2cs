//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:02:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using token = go.go.token_package;
using math = go.math_package;
using big = go.math.big_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace go
{
    public static partial class constant_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct stringVal
        {
            // Constructors
            public stringVal(NilType _)
            {
                this.mu = default;
                this.s = default;
                this.l = default;
                this.r = default;
            }

            public stringVal(sync.Mutex mu = default, @string s = default, ref ptr<stringVal> l = default, ref ptr<stringVal> r = default)
            {
                this.mu = mu;
                this.s = s;
                this.l = l;
                this.r = r;
            }

            // Enable comparisons between nil and stringVal struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stringVal value, NilType nil) => value.Equals(default(stringVal));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stringVal value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stringVal value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stringVal value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringVal(NilType nil) => default(stringVal);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static stringVal stringVal_cast(dynamic value)
        {
            return new stringVal(value.mu, value.s, ref value.l, ref value.r);
        }
    }
}}