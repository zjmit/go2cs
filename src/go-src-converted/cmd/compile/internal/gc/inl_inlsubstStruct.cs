//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:29:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using logopt = go.cmd.compile.@internal.logopt_package;
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct inlsubst
        {
            // Constructors
            public inlsubst(NilType _)
            {
                this.retlabel = default;
                this.retvars = default;
                this.inlvars = default;
                this.bases = default;
                this.newInlIndex = default;
            }

            public inlsubst(ref ptr<types.Sym> retlabel = default, slice<ptr<Node>> retvars = default, map<ptr<Node>, ptr<Node>> inlvars = default, map<ptr<src.PosBase>, ptr<src.PosBase>> bases = default, long newInlIndex = default)
            {
                this.retlabel = retlabel;
                this.retvars = retvars;
                this.inlvars = inlvars;
                this.bases = bases;
                this.newInlIndex = newInlIndex;
            }

            // Enable comparisons between nil and inlsubst struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(inlsubst value, NilType nil) => value.Equals(default(inlsubst));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(inlsubst value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, inlsubst value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, inlsubst value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator inlsubst(NilType nil) => default(inlsubst);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static inlsubst inlsubst_cast(dynamic value)
        {
            return new inlsubst(ref value.retlabel, value.retvars, value.inlvars, value.bases, value.newInlIndex);
        }
    }
}}}}