//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:38:57 UTC
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
using goobj2 = go.cmd.@internal.goobj2_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loadelf = go.cmd.link.@internal.loadelf_package;
using loader = go.cmd.link.@internal.loader_package;
using loadmacho = go.cmd.link.@internal.loadmacho_package;
using loadpe = go.cmd.link.@internal.loadpe_package;
using loadxcoff = go.cmd.link.@internal.loadxcoff_package;
using sym = go.cmd.link.@internal.sym_package;
using sha1 = go.crypto.sha1_package;
using elf = go.debug.elf_package;
using macho = go.debug.macho_package;
using base64 = go.encoding.base64_package;
using binary = go.encoding.binary_package;
using hex = go.encoding.hex_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using exec = go.os.exec_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct chain
        {
            // Constructors
            public chain(NilType _)
            {
                this.sym = default;
                this.up = default;
                this.limit = default;
            }

            public chain(loader.Sym sym = default, ref ptr<chain> up = default, long limit = default)
            {
                this.sym = sym;
                this.up = up;
                this.limit = limit;
            }

            // Enable comparisons between nil and chain struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(chain value, NilType nil) => value.Equals(default(chain));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(chain value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, chain value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, chain value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator chain(NilType nil) => default(chain);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static chain chain_cast(dynamic value)
        {
            return new chain(value.sym, ref value.up, value.limit);
        }
    }
}}}}