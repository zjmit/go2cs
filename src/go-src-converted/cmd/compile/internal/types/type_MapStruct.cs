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
        public partial struct Map
        {
            // Constructors
            public Map(NilType _)
            {
                this.Key = default;
                this.Elem = default;
                this.Bucket = default;
                this.Hmap = default;
                this.Hiter = default;
            }

            public Map(ref ptr<Type> Key = default, ref ptr<Type> Elem = default, ref ptr<Type> Bucket = default, ref ptr<Type> Hmap = default, ref ptr<Type> Hiter = default)
            {
                this.Key = Key;
                this.Elem = Elem;
                this.Bucket = Bucket;
                this.Hmap = Hmap;
                this.Hiter = Hiter;
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
            return new Map(ref value.Key, ref value.Elem, ref value.Bucket, ref value.Hmap, ref value.Hiter);
        }
    }
}}}}