//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:55:46 UTC
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
using types = go.go.types_package;
using reflect = go.reflect_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace types
{
    public static partial class typeutil_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Map
        {
            // Constructors
            public Map(NilType _)
            {
                this.hasher = default;
                this.table = default;
                this.length = default;
            }

            public Map(Hasher hasher = default, map<uint, slice<entry>> table = default, long length = default)
            {
                this.hasher = hasher;
                this.table = table;
                this.length = length;
            }

            // Enable comparisons between nil and Map struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Map value, NilType nil) => value.Equals(default(Map));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Map value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Map value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Map value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Map(NilType nil) => default(Map);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Map Map_cast(dynamic value)
        {
            return new Map(value.hasher, value.table, value.length);
        }
    }
}}}}}}