//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:36:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using zip = go.archive.zip_package;
using bytes = go.bytes_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using lockedfile = go.cmd.go.@internal.lockedfile_package;
using par = go.cmd.go.@internal.par_package;
using renameio = go.cmd.go.@internal.renameio_package;
using robustio = go.cmd.go.@internal.robustio_package;
using module = go.golang.org.x.mod.module_package;
using dirhash = go.golang.org.x.mod.sumdb.dirhash_package;
using modzip = go.golang.org.x.mod.zip_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modfetch_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct cached
        {
            // Constructors
            public cached(NilType _)
            {
                this.dir = default;
                this.err = default;
            }

            public cached(@string dir = default, error err = default)
            {
                this.dir = dir;
                this.err = err;
            }

            // Enable comparisons between nil and cached struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(cached value, NilType nil) => value.Equals(default(cached));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(cached value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, cached value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, cached value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cached(NilType nil) => default(cached);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static cached cached_cast(dynamic value)
        {
            return new cached(value.dir, value.err);
        }
    }
}}}}