//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:10:50 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using obj = go.cmd.@internal.obj_package;
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
        private partial struct inputInfo
        {
            // Constructors
            public inputInfo(NilType _)
            {
                this.idx = default;
                this.regs = default;
            }

            public inputInfo(long idx = default, regMask regs = default)
            {
                this.idx = idx;
                this.regs = regs;
            }

            // Enable comparisons between nil and inputInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(inputInfo value, NilType nil) => value.Equals(default(inputInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(inputInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, inputInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, inputInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator inputInfo(NilType nil) => default(inputInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static inputInfo inputInfo_cast(dynamic value)
        {
            return new inputInfo(value.idx, value.regs);
        }
    }
}}}}