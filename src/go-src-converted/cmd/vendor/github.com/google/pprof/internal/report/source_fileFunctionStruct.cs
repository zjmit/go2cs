//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:43:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using fmt = go.fmt_package;
using template = go.html.template_package;
using io = go.io_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using graph = go.github.com.google.pprof.@internal.graph_package;
using measurement = go.github.com.google.pprof.@internal.measurement_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class report_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct fileFunction
        {
            // Constructors
            public fileFunction(NilType _)
            {
                this.fileName = default;
                this.functionName = default;
            }

            public fileFunction(@string fileName = default, @string functionName = default)
            {
                this.fileName = fileName;
                this.functionName = functionName;
            }

            // Enable comparisons between nil and fileFunction struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(fileFunction value, NilType nil) => value.Equals(default(fileFunction));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(fileFunction value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, fileFunction value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, fileFunction value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator fileFunction(NilType nil) => default(fileFunction);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static fileFunction fileFunction_cast(dynamic value)
        {
            return new fileFunction(value.fileName, value.functionName);
        }
    }
}}}}}}}