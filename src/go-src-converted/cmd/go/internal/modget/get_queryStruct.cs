//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:33:45 UTC
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
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using @base = go.cmd.go.@internal.@base_package;
using get = go.cmd.go.@internal.get_package;
using imports = go.cmd.go.@internal.imports_package;
using load = go.cmd.go.@internal.load_package;
using modload = go.cmd.go.@internal.modload_package;
using mvs = go.cmd.go.@internal.mvs_package;
using par = go.cmd.go.@internal.par_package;
using search = go.cmd.go.@internal.search_package;
using work = go.cmd.go.@internal.work_package;
using module = go.golang.org.x.mod.module_package;
using semver = go.golang.org.x.mod.semver_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class modget_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(querySpec))]
        private partial struct query
        {
            // querySpec structure promotion - sourced from value copy
            private readonly ptr<querySpec> m_querySpecRef;

            private ref querySpec querySpec_val => ref m_querySpecRef.Value;

            public ref @string path => ref m_querySpecRef.Value.path;

            public ref @string vers => ref m_querySpecRef.Value.vers;

            public ref bool forceModulePath => ref m_querySpecRef.Value.forceModulePath;

            public ref module.Version prevM => ref m_querySpecRef.Value.prevM;

            // Constructors
            public query(NilType _)
            {
                this.m_querySpecRef = new ptr<querySpec>(new querySpec(nil));
                this.arg = default;
                this.m = default;
            }

            public query(querySpec querySpec = default, @string arg = default, module.Version m = default)
            {
                this.m_querySpecRef = new ptr<querySpec>(querySpec);
                this.arg = arg;
                this.m = m;
            }

            // Enable comparisons between nil and query struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(query value, NilType nil) => value.Equals(default(query));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(query value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, query value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, query value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator query(NilType nil) => default(query);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static query query_cast(dynamic value)
        {
            return new query(value.querySpec, value.arg, value.m);
        }
    }
}}}}