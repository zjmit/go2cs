//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:27:01 UTC
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
using flag = go.flag_package;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using format = go.go.format_package;
using parser = go.go.parser_package;
using printer = go.go.printer_package;
using token = go.go.token_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using path = go.path_package;
using regexp = go.regexp_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using astutil = go.golang.org.x.tools.go.ast.astutil_package;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Rule
        {
            // Constructors
            public Rule(NilType _)
            {
                this.Rule = default;
                this.Loc = default;
            }

            public Rule(@string Rule = default, @string Loc = default)
            {
                this.Rule = Rule;
                this.Loc = Loc;
            }

            // Enable comparisons between nil and Rule struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Rule value, NilType nil) => value.Equals(default(Rule));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Rule value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Rule value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Rule value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Rule(NilType nil) => default(Rule);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Rule Rule_cast(dynamic value)
        {
            return new Rule(value.Rule, value.Loc);
        }
    }
}