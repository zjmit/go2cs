//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:43:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using runtime = go.runtime_package;
using debug = go.runtime.debug_package;
using time = go.time_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct errorThatGosched
        {
            // Constructors
            public errorThatGosched(NilType _)
            {
            }
            // Enable comparisons between nil and errorThatGosched struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(errorThatGosched value, NilType nil) => value.Equals(default(errorThatGosched));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(errorThatGosched value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, errorThatGosched value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, errorThatGosched value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errorThatGosched(NilType nil) => default(errorThatGosched);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static errorThatGosched errorThatGosched_cast(dynamic value)
        {
            return new errorThatGosched();
        }
    }
}