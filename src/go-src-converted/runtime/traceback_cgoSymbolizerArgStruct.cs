//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:24:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using atomic = go.runtime.@internal.atomic_package;
using sys = go.runtime.@internal.sys_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct cgoSymbolizerArg
        {
            // Constructors
            public cgoSymbolizerArg(NilType _)
            {
                this.pc = default;
                this.file = default;
                this.lineno = default;
                this.funcName = default;
                this.entry = default;
                this.more = default;
                this.data = default;
            }

            public cgoSymbolizerArg(System.UIntPtr pc = default, ref ptr<byte> file = default, System.UIntPtr lineno = default, ref ptr<byte> funcName = default, System.UIntPtr entry = default, System.UIntPtr more = default, System.UIntPtr data = default)
            {
                this.pc = pc;
                this.file = file;
                this.lineno = lineno;
                this.funcName = funcName;
                this.entry = entry;
                this.more = more;
                this.data = data;
            }

            // Enable comparisons between nil and cgoSymbolizerArg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(cgoSymbolizerArg value, NilType nil) => value.Equals(default(cgoSymbolizerArg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(cgoSymbolizerArg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, cgoSymbolizerArg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, cgoSymbolizerArg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cgoSymbolizerArg(NilType nil) => default(cgoSymbolizerArg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static cgoSymbolizerArg cgoSymbolizerArg_cast(dynamic value)
        {
            return new cgoSymbolizerArg(value.pc, ref value.file, value.lineno, ref value.funcName, value.entry, value.more, value.data);
        }
    }
}