//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:04:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ptwo = go.p2_package;
using go;

namespace go {
namespace cmd {
namespace api {
namespace testdata {
namespace src {
namespace pkg
{
    public static partial class p1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct common
        {
            // Constructors
            public common(NilType _)
            {
                this.i = default;
            }

            public common(long i = default)
            {
                this.i = i;
            }

            // Enable comparisons between nil and common struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(common value, NilType nil) => value.Equals(default(common));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(common value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, common value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, common value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator common(NilType nil) => default(common);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static common common_cast(dynamic value)
        {
            return new common(value.i);
        }
    }
}}}}}}