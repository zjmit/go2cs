//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:29:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ssa = go.cmd.compile.@internal.ssa_package;
using types = go.cmd.compile.@internal.types_package;
using src = go.cmd.@internal.src_package;
using heap = go.container.heap_package;
using fmt = go.fmt_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct simplePhiState
        {
            // Constructors
            public simplePhiState(NilType _)
            {
                this.s = default;
                this.f = default;
                this.fwdrefs = default;
                this.defvars = default;
                this.reachable = default;
            }

            public simplePhiState(ref ptr<state> s = default, ref ptr<ssa.Func> f = default, slice<ptr<ssa.Value>> fwdrefs = default, slice<map<ptr<Node>, ptr<ssa.Value>>> defvars = default, slice<bool> reachable = default)
            {
                this.s = s;
                this.f = f;
                this.fwdrefs = fwdrefs;
                this.defvars = defvars;
                this.reachable = reachable;
            }

            // Enable comparisons between nil and simplePhiState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(simplePhiState value, NilType nil) => value.Equals(default(simplePhiState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(simplePhiState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, simplePhiState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, simplePhiState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator simplePhiState(NilType nil) => default(simplePhiState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static simplePhiState simplePhiState_cast(dynamic value)
        {
            return new simplePhiState(ref value.s, ref value.f, value.fwdrefs, value.defvars, value.reachable);
        }
    }
}}}}