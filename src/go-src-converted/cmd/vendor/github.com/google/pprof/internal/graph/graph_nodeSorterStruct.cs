//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:43:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using math = go.math_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using profile = go.github.com.google.pprof.profile_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class graph_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct nodeSorter
        {
            // Constructors
            public nodeSorter(NilType _)
            {
                this.rs = default;
                this.less = default;
            }

            public nodeSorter(Nodes rs = default, Func<ptr<Node>, ptr<Node>, bool> less = default)
            {
                this.rs = rs;
                this.less = less;
            }

            // Enable comparisons between nil and nodeSorter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nodeSorter value, NilType nil) => value.Equals(default(nodeSorter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nodeSorter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nodeSorter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nodeSorter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nodeSorter(NilType nil) => default(nodeSorter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static nodeSorter nodeSorter_cast(dynamic value)
        {
            return new nodeSorter(value.rs, value.less);
        }
    }
}}}}}}}