//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:50:07 UTC
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
using goobj2 = go.cmd.@internal.goobj2_package;
using objabi = go.cmd.@internal.objabi_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class goobj_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Var
        {
            // Constructors
            public Var(NilType _)
            {
                this.Name = default;
                this.Kind = default;
                this.Offset = default;
                this.Type = default;
            }

            public Var(@string Name = default, long Kind = default, long Offset = default, SymID Type = default)
            {
                this.Name = Name;
                this.Kind = Kind;
                this.Offset = Offset;
                this.Type = Type;
            }

            // Enable comparisons between nil and Var struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Var value, NilType nil) => value.Equals(default(Var));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Var value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Var value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Var value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Var(NilType nil) => default(Var);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Var Var_cast(dynamic value)
        {
            return new Var(value.Name, value.Kind, value.Offset, value.Type);
        }
    }
}}}