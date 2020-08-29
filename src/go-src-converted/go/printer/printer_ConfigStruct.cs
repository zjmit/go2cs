//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:52:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using ast = go.go.ast_package;
using token = go.go.token_package;
using io = go.io_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using tabwriter = go.text.tabwriter_package;
using unicode = go.unicode_package;
using go;

namespace go {
namespace go
{
    public static partial class printer_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Config
        {
            // Constructors
            public Config(NilType _)
            {
                this.Mode = default;
                this.Tabwidth = default;
                this.Indent = default;
            }

            public Config(Mode Mode = default, long Tabwidth = default, long Indent = default)
            {
                this.Mode = Mode;
                this.Tabwidth = Tabwidth;
                this.Indent = Indent;
            }

            // Enable comparisons between nil and Config struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Config value, NilType nil) => value.Equals(default(Config));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Config value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Config value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Config value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Config(NilType nil) => default(Config);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Config Config_cast(dynamic value)
        {
            return new Config(value.Mode, value.Tabwidth, value.Indent);
        }
    }
}}