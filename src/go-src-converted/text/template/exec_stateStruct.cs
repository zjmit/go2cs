//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:42:12 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using fmtsort = go.@internal.fmtsort_package;
using io = go.io_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using strings = go.strings_package;
using parse = go.text.template.parse_package;
using go;

namespace go {
namespace text
{
    public static partial class template_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct state
        {
            // Constructors
            public state(NilType _)
            {
                this.tmpl = default;
                this.wr = default;
                this.node = default;
                this.vars = default;
                this.depth = default;
            }

            public state(ref ptr<Template> tmpl = default, io.Writer wr = default, parse.Node node = default, slice<variable> vars = default, long depth = default)
            {
                this.tmpl = tmpl;
                this.wr = wr;
                this.node = node;
                this.vars = vars;
                this.depth = depth;
            }

            // Enable comparisons between nil and state struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(state value, NilType nil) => value.Equals(default(state));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(state value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, state value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, state value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator state(NilType nil) => default(state);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static state state_cast(dynamic value)
        {
            return new state(ref value.tmpl, value.wr, value.node, value.vars, value.depth);
        }
    }
}}