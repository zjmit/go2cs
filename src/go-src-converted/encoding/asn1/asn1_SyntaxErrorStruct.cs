//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:36:51 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using math = go.math_package;
using big = go.math.big_package;
using reflect = go.reflect_package;
using strconv = go.strconv_package;
using time = go.time_package;
using utf16 = go.unicode.utf16_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace encoding
{
    public static partial class asn1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SyntaxError
        {
            // Constructors
            public SyntaxError(NilType _)
            {
                this.Msg = default;
            }

            public SyntaxError(@string Msg = default)
            {
                this.Msg = Msg;
            }

            // Enable comparisons between nil and SyntaxError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SyntaxError value, NilType nil) => value.Equals(default(SyntaxError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SyntaxError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SyntaxError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SyntaxError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SyntaxError(NilType nil) => default(SyntaxError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SyntaxError SyntaxError_cast(dynamic value)
        {
            return new SyntaxError(value.Msg);
        }
    }
}}