//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:57:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ast = go.go.ast_package;
using types = go.go.types_package;
using log = go.log_package;
using reflect = go.reflect_package;
using analysis = go.golang.org.x.tools.go.analysis_package;
using inspect = go.golang.org.x.tools.go.analysis.passes.inspect_package;
using inspector = go.golang.org.x.tools.go.ast.inspector_package;
using cfg = go.golang.org.x.tools.go.cfg_package;
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
    public static partial class ctrlflow_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct noReturn
        {
            // Constructors
            public noReturn(NilType _)
            {
            }
            // Enable comparisons between nil and noReturn struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(noReturn value, NilType nil) => value.Equals(default(noReturn));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(noReturn value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, noReturn value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, noReturn value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator noReturn(NilType nil) => default(noReturn);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static noReturn noReturn_cast(dynamic value)
        {
            return new noReturn();
        }
    }
}}}}}}}}}