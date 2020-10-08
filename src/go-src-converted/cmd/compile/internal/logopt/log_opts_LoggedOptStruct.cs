//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:09:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using json = go.encoding.json_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using url = go.net.url_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class logopt_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct LoggedOpt
        {
            // Constructors
            public LoggedOpt(NilType _)
            {
                this.pos = default;
                this.pass = default;
                this.fname = default;
                this.what = default;
                this.target = default;
            }

            public LoggedOpt(src.XPos pos = default, @string pass = default, @string fname = default, @string what = default, slice<object> target = default)
            {
                this.pos = pos;
                this.pass = pass;
                this.fname = fname;
                this.what = what;
                this.target = target;
            }

            // Enable comparisons between nil and LoggedOpt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(LoggedOpt value, NilType nil) => value.Equals(default(LoggedOpt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(LoggedOpt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, LoggedOpt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, LoggedOpt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LoggedOpt(NilType nil) => default(LoggedOpt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static LoggedOpt LoggedOpt_cast(dynamic value)
        {
            return new LoggedOpt(value.pos, value.pass, value.fname, value.what, value.target);
        }
    }
}}}}