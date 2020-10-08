//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:31:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using html = go.html_package;
using os = go.os_package;
using sort = go.sort_package;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using ssa = go.cmd.compile.@internal.ssa_package;
using types = go.cmd.compile.@internal.types_package;
using obj = go.cmd.@internal.obj_package;
using x86 = go.cmd.@internal.obj.x86_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using sys = go.cmd.@internal.sys_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct opAndTwoTypes
        {
            // Constructors
            public opAndTwoTypes(NilType _)
            {
                this.op = default;
                this.etype1 = default;
                this.etype2 = default;
            }

            public opAndTwoTypes(Op op = default, types.EType etype1 = default, types.EType etype2 = default)
            {
                this.op = op;
                this.etype1 = etype1;
                this.etype2 = etype2;
            }

            // Enable comparisons between nil and opAndTwoTypes struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(opAndTwoTypes value, NilType nil) => value.Equals(default(opAndTwoTypes));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(opAndTwoTypes value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, opAndTwoTypes value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, opAndTwoTypes value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator opAndTwoTypes(NilType nil) => default(opAndTwoTypes);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static opAndTwoTypes opAndTwoTypes_cast(dynamic value)
        {
            return new opAndTwoTypes(value.op, value.etype1, value.etype2);
        }
    }
}}}}