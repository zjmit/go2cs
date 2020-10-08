//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:40:49 UTC
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
using dwarf = go.cmd.@internal.dwarf_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using sym = go.cmd.oldlink.@internal.sym_package;
using fmt = go.fmt_package;
using log = go.log_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class loader_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Loader
        {
            // Constructors
            public Loader(NilType _)
            {
                this.start = default;
                this.objs = default;
                this.max = default;
                this.extStart = default;
                this.extSyms = default;
                this.builtinSyms = default;
                this.ocache = default;
                this.symsByName = default;
                this.extStaticSyms = default;
                this.overwrite = default;
                this.objByPkg = default;
                this.Syms = default;
                this.anonVersion = default;
                this.Reachable = default;
                this.Reachparent = default;
                this.relocBatch = default;
                this.flags = default;
                this.strictDupMsgs = default;
            }

            public Loader(map<ptr<oReader>, Sym> start = default, slice<objIdx> objs = default, Sym max = default, Sym extStart = default, slice<nameVer> extSyms = default, slice<Sym> builtinSyms = default, long ocache = default, array<map<@string, Sym>> symsByName = default, map<nameVer, Sym> extStaticSyms = default, map<Sym, Sym> overwrite = default, map<@string, ptr<oReader>> objByPkg = default, slice<ptr<sym.Symbol>> Syms = default, long anonVersion = default, bitmap Reachable = default, slice<Sym> Reachparent = default, slice<sym.Reloc> relocBatch = default, uint flags = default, long strictDupMsgs = default)
            {
                this.start = start;
                this.objs = objs;
                this.max = max;
                this.extStart = extStart;
                this.extSyms = extSyms;
                this.builtinSyms = builtinSyms;
                this.ocache = ocache;
                this.symsByName = symsByName;
                this.extStaticSyms = extStaticSyms;
                this.overwrite = overwrite;
                this.objByPkg = objByPkg;
                this.Syms = Syms;
                this.anonVersion = anonVersion;
                this.Reachable = Reachable;
                this.Reachparent = Reachparent;
                this.relocBatch = relocBatch;
                this.flags = flags;
                this.strictDupMsgs = strictDupMsgs;
            }

            // Enable comparisons between nil and Loader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Loader value, NilType nil) => value.Equals(default(Loader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Loader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Loader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Loader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Loader(NilType nil) => default(Loader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Loader Loader_cast(dynamic value)
        {
            return new Loader(value.start, value.objs, value.max, value.extStart, value.extSyms, value.builtinSyms, value.ocache, value.symsByName, value.extStaticSyms, value.overwrite, value.objByPkg, value.Syms, value.anonVersion, value.Reachable, value.Reachparent, value.relocBatch, value.flags, value.strictDupMsgs);
        }
    }
}}}}