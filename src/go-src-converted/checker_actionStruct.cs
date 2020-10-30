//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:01:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using gob = go.encoding.gob_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using format = go.go.format_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using types = go.go.types_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using pprof = go.runtime.pprof_package;
using trace = go.runtime.trace_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using analysis = go.golang.org.x.tools.go.analysis_package;
using analysisflags = go.golang.org.x.tools.go.analysis.@internal.analysisflags_package;
using packages = go.golang.org.x.tools.go.packages_package;
using analysisinternal = go.golang.org.x.tools.@internal.analysisinternal_package;
using span = go.golang.org.x.tools.@internal.span_package;
using go;

#nullable enable

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace @internal
{
    public static partial class checker_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct action
        {
            // Constructors
            public action(NilType _)
            {
                this.once = default;
                this.a = default;
                this.pkg = default;
                this.pass = default;
                this.isroot = default;
                this.deps = default;
                this.objectFacts = default;
                this.packageFacts = default;
                this.diagnostics = default;
                this.err = default;
                this.duration = default;
            }

            public action(sync.Once once = default, ref ptr<analysis.Analyzer> a = default, ref ptr<packages.Package> pkg = default, ref ptr<analysis.Pass> pass = default, bool isroot = default, slice<ptr<action>> deps = default, map<objectFactKey, analysis.Fact> objectFacts = default, map<packageFactKey, analysis.Fact> packageFacts = default, slice<analysis.Diagnostic> diagnostics = default, error err = default, time.Duration duration = default)
            {
                this.once = once;
                this.a = a;
                this.pkg = pkg;
                this.pass = pass;
                this.isroot = isroot;
                this.deps = deps;
                this.objectFacts = objectFacts;
                this.packageFacts = packageFacts;
                this.diagnostics = diagnostics;
                this.err = err;
                this.duration = duration;
            }

            // Enable comparisons between nil and action struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(action value, NilType nil) => value.Equals(default(action));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(action value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, action value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, action value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator action(NilType nil) => default(action);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static action action_cast(dynamic value)
        {
            return new action(value.once, ref value.a, ref value.pkg, ref value.pass, value.isroot, value.deps, value.objectFacts, value.packageFacts, value.diagnostics, value.err, value.duration);
        }
    }
}}}}}}}