//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:58:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using types = go.go.types_package;
using reflect = go.reflect_package;
using regexp = go.regexp_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using utf8 = go.unicode.utf8_package;
using analysis = go.golang.org.x.tools.go.analysis_package;
using inspect = go.golang.org.x.tools.go.analysis.passes.inspect_package;
using analysisutil = go.golang.org.x.tools.go.analysis.passes.@internal.analysisutil_package;
using inspector = go.golang.org.x.tools.go.ast.inspector_package;
using typeutil = go.golang.org.x.tools.go.types.typeutil_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace analysis {
namespace passes
{
    public static partial class printf_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Result
        {
            // Constructors
            public Result(NilType _)
            {
                this.funcs = default;
            }

            public Result(map<ptr<types.Func>, Kind> funcs = default)
            {
                this.funcs = funcs;
            }

            // Enable comparisons between nil and Result struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Result value, NilType nil) => value.Equals(default(Result));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Result value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Result value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Result value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Result(NilType nil) => default(Result);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Result Result_cast(dynamic value)
        {
            return new Result(value.funcs);
        }
    }
}}}}}}}}}