//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:26:43 UTC
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
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct stackAllocState
        {
            // Constructors
            public stackAllocState(NilType _)
            {
                this.f = default;
                this.live = default;
                this.values = default;
                this.interfere = default;
                this.names = default;
                this.slots = default;
                this.used = default;
                this.nArgSlot = default;
                this.nNotNeed = default;
                this.nNamedSlot = default;
                this.nReuse = default;
                this.nAuto = default;
                this.nSelfInterfere = default;
            }

            public stackAllocState(ref ptr<Func> f = default, slice<slice<ID>> live = default, slice<stackValState> values = default, slice<slice<ID>> interfere = default, slice<LocalSlot> names = default, slice<long> slots = default, slice<bool> used = default, int nArgSlot = default, int nNotNeed = default, int nNamedSlot = default, int nReuse = default, int nAuto = default, int nSelfInterfere = default)
            {
                this.f = f;
                this.live = live;
                this.values = values;
                this.interfere = interfere;
                this.names = names;
                this.slots = slots;
                this.used = used;
                this.nArgSlot = nArgSlot;
                this.nNotNeed = nNotNeed;
                this.nNamedSlot = nNamedSlot;
                this.nReuse = nReuse;
                this.nAuto = nAuto;
                this.nSelfInterfere = nSelfInterfere;
            }

            // Enable comparisons between nil and stackAllocState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stackAllocState value, NilType nil) => value.Equals(default(stackAllocState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stackAllocState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stackAllocState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stackAllocState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stackAllocState(NilType nil) => default(stackAllocState);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static stackAllocState stackAllocState_cast(dynamic value)
        {
            return new stackAllocState(ref value.f, value.live, value.values, value.interfere, value.names, value.slots, value.used, value.nArgSlot, value.nNotNeed, value.nNamedSlot, value.nReuse, value.nAuto, value.nSelfInterfere);
        }
    }
}}}}