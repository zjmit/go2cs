//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:41:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using reflect = go.reflect_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using time = go.time_package;

namespace go
{
    public static partial class flag_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct FlagSet
        {
            // Constructors
            public FlagSet(NilType _)
            {
                this.Usage = default;
                this.name = default;
                this.parsed = default;
                this.actual = default;
                this.formal = default;
                this.args = default;
                this.errorHandling = default;
                this.output = default;
            }

            public FlagSet(Action Usage = default, @string name = default, bool parsed = default, map<@string, ptr<Flag>> actual = default, map<@string, ptr<Flag>> formal = default, slice<@string> args = default, ErrorHandling errorHandling = default, io.Writer output = default)
            {
                this.Usage = Usage;
                this.name = name;
                this.parsed = parsed;
                this.actual = actual;
                this.formal = formal;
                this.args = args;
                this.errorHandling = errorHandling;
                this.output = output;
            }

            // Enable comparisons between nil and FlagSet struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FlagSet value, NilType nil) => value.Equals(default(FlagSet));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FlagSet value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FlagSet value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FlagSet value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FlagSet(NilType nil) => default(FlagSet);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FlagSet FlagSet_cast(dynamic value)
        {
            return new FlagSet(value.Usage, value.name, value.parsed, value.actual, value.formal, value.args, value.errorHandling, value.output);
        }
    }
}