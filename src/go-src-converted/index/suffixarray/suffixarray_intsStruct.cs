//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:59:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using io = go.io_package;
using math = go.math_package;
using regexp = go.regexp_package;
using sort = go.sort_package;
using go;

namespace go {
namespace index
{
    public static partial class suffixarray_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ints
        {
            // Constructors
            public ints(NilType _)
            {
                this.int32 = default;
                this.int64 = default;
            }

            public ints(slice<int> int32 = default, slice<long> int64 = default)
            {
                this.int32 = int32;
                this.int64 = int64;
            }

            // Enable comparisons between nil and ints struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ints value, NilType nil) => value.Equals(default(ints));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ints value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ints value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ints value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ints(NilType nil) => default(ints);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ints ints_cast(dynamic value)
        {
            return new ints(value.int32, value.int64);
        }
    }
}}