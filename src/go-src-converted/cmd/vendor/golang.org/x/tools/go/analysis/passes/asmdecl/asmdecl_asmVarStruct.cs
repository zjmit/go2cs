//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:57:47 UTC
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
using build = go.go.build_package;
using token = go.go.token_package;
using types = go.go.types_package;
using log = go.log_package;
using regexp = go.regexp_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using analysis = go.golang.org.x.tools.go.analysis_package;
using analysisutil = go.golang.org.x.tools.go.analysis.passes.@internal.analysisutil_package;
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
    public static partial class asmdecl_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct asmVar
        {
            // Constructors
            public asmVar(NilType _)
            {
                this.name = default;
                this.kind = default;
                this.typ = default;
                this.off = default;
                this.size = default;
                this.inner = default;
            }

            public asmVar(@string name = default, asmKind kind = default, @string typ = default, long off = default, long size = default, slice<ptr<asmVar>> inner = default)
            {
                this.name = name;
                this.kind = kind;
                this.typ = typ;
                this.off = off;
                this.size = size;
                this.inner = inner;
            }

            // Enable comparisons between nil and asmVar struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(asmVar value, NilType nil) => value.Equals(default(asmVar));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(asmVar value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, asmVar value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, asmVar value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator asmVar(NilType nil) => default(asmVar);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static asmVar asmVar_cast(dynamic value)
        {
            return new asmVar(value.name, value.kind, value.typ, value.off, value.size, value.inner);
        }
    }
}}}}}}}}}