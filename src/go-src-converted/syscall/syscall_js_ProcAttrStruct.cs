//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:27:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using oserror = go.@internal.oserror_package;
using sync = go.sync_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ProcAttr
        {
            // Constructors
            public ProcAttr(NilType _)
            {
                this.Dir = default;
                this.Env = default;
                this.Files = default;
                this.Sys = default;
            }

            public ProcAttr(@string Dir = default, slice<@string> Env = default, slice<System.UIntPtr> Files = default, ref ptr<SysProcAttr> Sys = default)
            {
                this.Dir = Dir;
                this.Env = Env;
                this.Files = Files;
                this.Sys = Sys;
            }

            // Enable comparisons between nil and ProcAttr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ProcAttr value, NilType nil) => value.Equals(default(ProcAttr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ProcAttr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ProcAttr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ProcAttr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ProcAttr(NilType nil) => default(ProcAttr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ProcAttr ProcAttr_cast(dynamic value)
        {
            return new ProcAttr(value.Dir, value.Env, value.Files, ref value.Sys);
        }
    }
}