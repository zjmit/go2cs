//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:22:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using cpu = go.@internal.cpu_package;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct _func
        {
            // Constructors
            public _func(NilType _)
            {
                this.entry = default;
                this.nameoff = default;
                this.args = default;
                this.deferreturn = default;
                this.pcsp = default;
                this.pcfile = default;
                this.pcln = default;
                this.npcdata = default;
                this.funcID = default;
                this._ = default;
                this.nfuncdata = default;
            }

            public _func(System.UIntPtr entry = default, int nameoff = default, int args = default, uint deferreturn = default, int pcsp = default, int pcfile = default, int pcln = default, int npcdata = default, funcID funcID = default, array<sbyte> _ = default, byte nfuncdata = default)
            {
                this.entry = entry;
                this.nameoff = nameoff;
                this.args = args;
                this.deferreturn = deferreturn;
                this.pcsp = pcsp;
                this.pcfile = pcfile;
                this.pcln = pcln;
                this.npcdata = npcdata;
                this.funcID = funcID;
                this._ = _;
                this.nfuncdata = nfuncdata;
            }

            // Enable comparisons between nil and _func struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(_func value, NilType nil) => value.Equals(default(_func));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(_func value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, _func value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, _func value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _func(NilType nil) => default(_func);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static _func _func_cast(dynamic value)
        {
            return new _func(value.entry, value.nameoff, value.args, value.deferreturn, value.pcsp, value.pcfile, value.pcln, value.npcdata, value.funcID, value._, value.nfuncdata);
        }
    }
}