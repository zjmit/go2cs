//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:56:25 UTC
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
        private partial struct asmFunc
        {
            // Constructors
            public asmFunc(NilType _)
            {
                this.arch = default;
                this.size = default;
                this.vars = default;
                this.varByOffset = default;
            }

            public asmFunc(ref ptr<asmArch> arch = default, long size = default, map<@string, ptr<asmVar>> vars = default, map<long, ptr<asmVar>> varByOffset = default)
            {
                this.arch = arch;
                this.size = size;
                this.vars = vars;
                this.varByOffset = varByOffset;
            }

            // Enable comparisons between nil and asmFunc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(asmFunc value, NilType nil) => value.Equals(default(asmFunc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(asmFunc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, asmFunc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, asmFunc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator asmFunc(NilType nil) => default(asmFunc);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static asmFunc asmFunc_cast(dynamic value)
        {
            return new asmFunc(ref value.arch, value.size, value.vars, value.varByOffset);
        }
    }
}}}}}}}