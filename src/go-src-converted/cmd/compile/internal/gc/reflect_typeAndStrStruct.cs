//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:30:14 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using types = go.cmd.compile.@internal.types_package;
using gcprog = go.cmd.@internal.gcprog_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using src = go.cmd.@internal.src_package;
using fmt = go.fmt_package;
using os = go.os_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct typeAndStr
        {
            // Constructors
            public typeAndStr(NilType _)
            {
                this.t = default;
                this.@short = default;
                this.regular = default;
            }

            public typeAndStr(ref ptr<types.Type> t = default, @string @short = default, @string regular = default)
            {
                this.t = t;
                this.@short = @short;
                this.regular = regular;
            }

            // Enable comparisons between nil and typeAndStr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(typeAndStr value, NilType nil) => value.Equals(default(typeAndStr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(typeAndStr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, typeAndStr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, typeAndStr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator typeAndStr(NilType nil) => default(typeAndStr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static typeAndStr typeAndStr_cast(dynamic value)
        {
            return new typeAndStr(ref value.t, value.@short, value.regular);
        }
    }
}}}}