//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:41:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using bio = go.cmd.@internal.bio_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loader = go.cmd.oldlink.@internal.loader_package;
using sym = go.cmd.oldlink.@internal.sym_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using sort = go.sort_package;
using go;

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class loadmacho_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ldMachoSect
        {
            // Constructors
            public ldMachoSect(NilType _)
            {
                this.name = default;
                this.segname = default;
                this.addr = default;
                this.size = default;
                this.off = default;
                this.align = default;
                this.reloff = default;
                this.nreloc = default;
                this.flags = default;
                this.res1 = default;
                this.res2 = default;
                this.sym = default;
                this.rel = default;
            }

            public ldMachoSect(@string name = default, @string segname = default, ulong addr = default, ulong size = default, uint off = default, uint align = default, uint reloff = default, uint nreloc = default, uint flags = default, uint res1 = default, uint res2 = default, ref ptr<sym.Symbol> sym = default, slice<ldMachoRel> rel = default)
            {
                this.name = name;
                this.segname = segname;
                this.addr = addr;
                this.size = size;
                this.off = off;
                this.align = align;
                this.reloff = reloff;
                this.nreloc = nreloc;
                this.flags = flags;
                this.res1 = res1;
                this.res2 = res2;
                this.sym = sym;
                this.rel = rel;
            }

            // Enable comparisons between nil and ldMachoSect struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ldMachoSect value, NilType nil) => value.Equals(default(ldMachoSect));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ldMachoSect value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ldMachoSect value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ldMachoSect value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ldMachoSect(NilType nil) => default(ldMachoSect);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ldMachoSect ldMachoSect_cast(dynamic value)
        {
            return new ldMachoSect(value.name, value.segname, value.addr, value.size, value.off, value.align, value.reloff, value.nreloc, value.flags, value.res1, value.res2, ref value.sym, value.rel);
        }
    }
}}}}