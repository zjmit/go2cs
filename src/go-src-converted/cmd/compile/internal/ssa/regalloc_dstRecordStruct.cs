//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:11:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using sys = go.cmd.@internal.sys_package;
using fmt = go.fmt_package;
using bits = go.math.bits_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct dstRecord
        {
            // Constructors
            public dstRecord(NilType _)
            {
                this.loc = default;
                this.vid = default;
                this.splice = default;
                this.pos = default;
            }

            public dstRecord(Location loc = default, ID vid = default, ref ptr<ptr<Value>> splice = default, src.XPos pos = default)
            {
                this.loc = loc;
                this.vid = vid;
                this.splice = splice;
                this.pos = pos;
            }

            // Enable comparisons between nil and dstRecord struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(dstRecord value, NilType nil) => value.Equals(default(dstRecord));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(dstRecord value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, dstRecord value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, dstRecord value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator dstRecord(NilType nil) => default(dstRecord);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static dstRecord dstRecord_cast(dynamic value)
        {
            return new dstRecord(value.loc, value.vid, ref value.splice, value.pos);
        }
    }
}}}}