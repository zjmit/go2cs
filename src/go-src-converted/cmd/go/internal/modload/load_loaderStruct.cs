//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:46:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using imports = go.cmd.go.@internal.imports_package;
using modfetch = go.cmd.go.@internal.modfetch_package;
using mvs = go.cmd.go.@internal.mvs_package;
using par = go.cmd.go.@internal.par_package;
using search = go.cmd.go.@internal.search_package;
using str = go.cmd.go.@internal.str_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using build = go.go.build_package;
using os = go.os_package;
using path = go.path_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using module = go.golang.org.x.mod.module_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modload_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct loader
        {
            // Constructors
            public loader(NilType _)
            {
                this.tags = default;
                this.testRoots = default;
                this.isALL = default;
                this.testAll = default;
                this.forceStdVendor = default;
                this.roots = default;
                this.pkgs = default;
                this.work = default;
                this.pkgCache = default;
                this.direct = default;
                this.goVersion = default;
            }

            public loader(map<@string, bool> tags = default, bool testRoots = default, bool isALL = default, bool testAll = default, bool forceStdVendor = default, slice<ptr<loadPkg>> roots = default, slice<ptr<loadPkg>> pkgs = default, ref ptr<par.Work> work = default, ref ptr<par.Cache> pkgCache = default, map<@string, bool> direct = default, map<@string, @string> goVersion = default)
            {
                this.tags = tags;
                this.testRoots = testRoots;
                this.isALL = isALL;
                this.testAll = testAll;
                this.forceStdVendor = forceStdVendor;
                this.roots = roots;
                this.pkgs = pkgs;
                this.work = work;
                this.pkgCache = pkgCache;
                this.direct = direct;
                this.goVersion = goVersion;
            }

            // Enable comparisons between nil and loader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(loader value, NilType nil) => value.Equals(default(loader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(loader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, loader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, loader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator loader(NilType nil) => default(loader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static loader loader_cast(dynamic value)
        {
            return new loader(value.tags, value.testRoots, value.isALL, value.testAll, value.forceStdVendor, value.roots, value.pkgs, ref value.work, ref value.pkgCache, value.direct, value.goVersion);
        }
    }
}}}}