//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:42:57 UTC
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
using io = go.io_package;
using os = go.os_package;
using exec = go.os.exec_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;
using plugin = go.github.com.google.pprof.@internal.plugin_package;
using report = go.github.com.google.pprof.@internal.report_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace github.com {
namespace google {
namespace pprof {
namespace @internal
{
    public static partial class driver_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct variable
        {
            // Constructors
            public variable(NilType _)
            {
                this.kind = default;
                this.value = default;
                this.group = default;
                this.help = default;
            }

            public variable(long kind = default, @string value = default, @string group = default, @string help = default)
            {
                this.kind = kind;
                this.value = value;
                this.group = group;
                this.help = help;
            }

            // Enable comparisons between nil and variable struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(variable value, NilType nil) => value.Equals(default(variable));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(variable value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, variable value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, variable value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator variable(NilType nil) => default(variable);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static variable variable_cast(dynamic value)
        {
            return new variable(value.kind, value.value, value.group, value.help);
        }
    }
}}}}}}}