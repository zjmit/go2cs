//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:09:51 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using obj = go.cmd.@internal.obj_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class types_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Array
        {
            // Constructors
            public Array(NilType _)
            {
                this.Elem = default;
                this.Bound = default;
            }

            public Array(ref ptr<Type> Elem = default, long Bound = default)
            {
                this.Elem = Elem;
                this.Bound = Bound;
            }

            // Enable comparisons between nil and Array struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Array value, NilType nil) => value.Equals(default(Array));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Array value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Array value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Array value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Array(NilType nil) => default(Array);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Array Array_cast(dynamic value)
        {
            return new Array(ref value.Elem, value.Bound);
        }
    }
}}}}