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
        private partial struct ldMachoSym
        {
            // Constructors
            public ldMachoSym(NilType _)
            {
                this.name = default;
                this.type_ = default;
                this.sectnum = default;
                this.desc = default;
                this.kind = default;
                this.value = default;
                this.sym = default;
            }

            public ldMachoSym(@string name = default, byte type_ = default, byte sectnum = default, ushort desc = default, sbyte kind = default, ulong value = default, loader.Sym sym = default)
            {
                this.name = name;
                this.type_ = type_;
                this.sectnum = sectnum;
                this.desc = desc;
                this.kind = kind;
                this.value = value;
                this.sym = sym;
            }

            // Enable comparisons between nil and ldMachoSym struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ldMachoSym value, NilType nil) => value.Equals(default(ldMachoSym));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ldMachoSym value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ldMachoSym value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ldMachoSym value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ldMachoSym(NilType nil) => default(ldMachoSym);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static ldMachoSym ldMachoSym_cast(dynamic value)
        {
            return new ldMachoSym(value.name, value.type_, value.sectnum, value.desc, value.kind, value.value, value.sym);
        }
    }
}}}}