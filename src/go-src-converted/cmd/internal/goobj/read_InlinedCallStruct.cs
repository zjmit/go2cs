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
        public partial struct InlinedCall
        {
            // Constructors
            public InlinedCall(NilType _)
            {
                this.Parent = default;
                this.File = default;
                this.Line = default;
                this.Func = default;
                this.ParentPC = default;
            }

            public InlinedCall(long Parent = default, @string File = default, long Line = default, SymID Func = default, long ParentPC = default)
            {
                this.Parent = Parent;
                this.File = File;
                this.Line = Line;
                this.Func = Func;
                this.ParentPC = ParentPC;
            }

            // Enable comparisons between nil and InlinedCall struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InlinedCall value, NilType nil) => value.Equals(default(InlinedCall));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InlinedCall value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InlinedCall value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InlinedCall value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InlinedCall(NilType nil) => default(InlinedCall);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InlinedCall InlinedCall_cast(dynamic value)
        {
            return new InlinedCall(value.Parent, value.File, value.Line, value.Func, value.ParentPC);
        }
    }
}}}