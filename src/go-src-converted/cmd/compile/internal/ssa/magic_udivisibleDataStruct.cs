//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:10:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using big = go.math.big_package;
using bits = go.math.bits_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct udivisibleData
        {
            // Constructors
            public udivisibleData(NilType _)
            {
                this.k = default;
                this.m = default;
                this.max = default;
            }

            public udivisibleData(long k = default, ulong m = default, ulong max = default)
            {
                this.k = k;
                this.m = m;
                this.max = max;
            }

            // Enable comparisons between nil and udivisibleData struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(udivisibleData value, NilType nil) => value.Equals(default(udivisibleData));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(udivisibleData value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, udivisibleData value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, udivisibleData value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator udivisibleData(NilType nil) => default(udivisibleData);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static udivisibleData udivisibleData_cast(dynamic value)
        {
            return new udivisibleData(value.k, value.m, value.max);
        }
    }
}}}}