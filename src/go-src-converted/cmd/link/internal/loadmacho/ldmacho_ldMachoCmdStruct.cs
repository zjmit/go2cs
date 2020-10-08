//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:39:05 UTC
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
using loader = go.cmd.link.@internal.loader_package;
using sym = go.cmd.link.@internal.sym_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using go;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class loadmacho_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct ldMachoCmd
        {
            // Constructors
            public ldMachoCmd(NilType _)
            {
                this.type_ = default;
                this.off = default;
                this.size = default;
                this.seg = default;
                this.sym = default;
                this.dsym = default;
            }

            public ldMachoCmd(long type_ = default, uint off = default, uint size = default, ldMachoSeg seg = default, ldMachoSymtab sym = default, ldMachoDysymtab dsym = default)
            {
                this.type_ = type_;
                this.off = off;
                this.size = size;
                this.seg = seg;
                this.sym = sym;
                this.dsym = dsym;
            }

            // Enable comparisons between nil and ldMachoCmd struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ldMachoCmd value, NilType nil) => value.Equals(default(ldMachoCmd));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ldMachoCmd value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ldMachoCmd value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ldMachoCmd value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ldMachoCmd(NilType nil) => default(ldMachoCmd);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ldMachoCmd ldMachoCmd_cast(dynamic value)
        {
            return new ldMachoCmd(value.type_, value.off, value.size, value.seg, value.sym, value.dsym);
        }
    }
}}}}