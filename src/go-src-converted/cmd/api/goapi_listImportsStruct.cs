//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:02:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using json = go.encoding.json_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using build = go.go.build_package;
using parser = go.go.parser_package;
using token = go.go.token_package;
using types = go.go.types_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using exec = go.os.exec_package;
using filepath = go.path.filepath_package;
using regexp = go.regexp_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct listImports
        {
            // Constructors
            public listImports(NilType _)
            {
                this.stdPackages = default;
                this.importDir = default;
                this.importMap = default;
            }

            public listImports(slice<@string> stdPackages = default, map<@string, @string> importDir = default, map<@string, map<@string, @string>> importMap = default)
            {
                this.stdPackages = stdPackages;
                this.importDir = importDir;
                this.importMap = importMap;
            }

            // Enable comparisons between nil and listImports struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(listImports value, NilType nil) => value.Equals(default(listImports));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(listImports value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, listImports value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, listImports value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator listImports(NilType nil) => default(listImports);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static listImports listImports_cast(dynamic value)
        {
            return new listImports(value.stdPackages, value.importDir, value.importMap);
        }
    }
}