//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:10:09 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using sort = go.sort_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sortvalues
        {
            // Constructors
            public sortvalues(NilType _)
            {
                this.a = default;
                this.auxIDs = default;
            }

            public sortvalues(slice<ptr<Value>> a = default, auxmap auxIDs = default)
            {
                this.a = a;
                this.auxIDs = auxIDs;
            }

            // Enable comparisons between nil and sortvalues struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sortvalues value, NilType nil) => value.Equals(default(sortvalues));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sortvalues value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sortvalues value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sortvalues value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sortvalues(NilType nil) => default(sortvalues);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sortvalues sortvalues_cast(dynamic value)
        {
            return new sortvalues(value.a, value.auxIDs);
        }
    }
}}}}