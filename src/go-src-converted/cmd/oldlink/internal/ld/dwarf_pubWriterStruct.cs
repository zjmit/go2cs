//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:40:59 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using dwarf = go.cmd.@internal.dwarf_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using sys = go.cmd.@internal.sys_package;
using sym = go.cmd.oldlink.@internal.sym_package;
using fmt = go.fmt_package;
using log = go.log_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct pubWriter
        {
            // Constructors
            public pubWriter(NilType _)
            {
                this.ctxt = default;
                this.s = default;
                this.sname = default;
                this.sectionstart = default;
                this.culengthOff = default;
            }

            public pubWriter(ref ptr<Link> ctxt = default, ref ptr<sym.Symbol> s = default, @string sname = default, long sectionstart = default, long culengthOff = default)
            {
                this.ctxt = ctxt;
                this.s = s;
                this.sname = sname;
                this.sectionstart = sectionstart;
                this.culengthOff = culengthOff;
            }

            // Enable comparisons between nil and pubWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pubWriter value, NilType nil) => value.Equals(default(pubWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pubWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pubWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pubWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pubWriter(NilType nil) => default(pubWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pubWriter pubWriter_cast(dynamic value)
        {
            return new pubWriter(ref value.ctxt, ref value.s, value.sname, value.sectionstart, value.culengthOff);
        }
    }
}}}}