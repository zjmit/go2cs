//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:35:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using build = go.go.build_package;
using goroot = go.@internal.goroot_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using time = go.time_package;
using cfg = go.cmd.go.@internal.cfg_package;
using load = go.cmd.go.@internal.load_package;
using modfetch = go.cmd.go.@internal.modfetch_package;
using par = go.cmd.go.@internal.par_package;
using search = go.cmd.go.@internal.search_package;
using module = go.golang.org.x.mod.module_package;
using semver = go.golang.org.x.mod.semver_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modload_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ImportMissingError
        {
            // Constructors
            public ImportMissingError(NilType _)
            {
                this.Path = default;
                this.Module = default;
                this.QueryErr = default;
                this.newMissingVersion = default;
            }

            public ImportMissingError(@string Path = default, module.Version Module = default, error QueryErr = default, @string newMissingVersion = default)
            {
                this.Path = Path;
                this.Module = Module;
                this.QueryErr = QueryErr;
                this.newMissingVersion = newMissingVersion;
            }

            // Enable comparisons between nil and ImportMissingError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ImportMissingError value, NilType nil) => value.Equals(default(ImportMissingError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ImportMissingError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ImportMissingError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ImportMissingError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ImportMissingError(NilType nil) => default(ImportMissingError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ImportMissingError ImportMissingError_cast(dynamic value)
        {
            return new ImportMissingError(value.Path, value.Module, value.QueryErr, value.newMissingVersion);
        }
    }
}}}}