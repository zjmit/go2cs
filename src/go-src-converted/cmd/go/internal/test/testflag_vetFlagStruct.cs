//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:46:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using flag = go.flag_package;
using fmt = go.fmt_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using strings = go.strings_package;
using time = go.time_package;
using @base = go.cmd.go.@internal.@base_package;
using cfg = go.cmd.go.@internal.cfg_package;
using cmdflag = go.cmd.go.@internal.cmdflag_package;
using work = go.cmd.go.@internal.work_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class test_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct vetFlag
        {
            // Constructors
            public vetFlag(NilType _)
            {
                this.@explicit = default;
                this.off = default;
                this.flags = default;
            }

            public vetFlag(bool @explicit = default, bool off = default, slice<@string> flags = default)
            {
                this.@explicit = @explicit;
                this.off = off;
                this.flags = flags;
            }

            // Enable comparisons between nil and vetFlag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(vetFlag value, NilType nil) => value.Equals(default(vetFlag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(vetFlag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, vetFlag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, vetFlag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator vetFlag(NilType nil) => default(vetFlag);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static vetFlag vetFlag_cast(dynamic value)
        {
            return new vetFlag(value.@explicit, value.off, value.flags);
        }
    }
}}}}