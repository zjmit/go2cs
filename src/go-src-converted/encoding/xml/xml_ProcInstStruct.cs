//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:43:08 UTC
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
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using go;

namespace go {
namespace encoding
{
    public static partial class xml_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ProcInst
        {
            // Constructors
            public ProcInst(NilType _)
            {
                this.Target = default;
                this.Inst = default;
            }

            public ProcInst(@string Target = default, slice<byte> Inst = default)
            {
                this.Target = Target;
                this.Inst = Inst;
            }

            // Enable comparisons between nil and ProcInst struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ProcInst value, NilType nil) => value.Equals(default(ProcInst));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ProcInst value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ProcInst value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ProcInst value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ProcInst(NilType nil) => default(ProcInst);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ProcInst ProcInst_cast(dynamic value)
        {
            return new ProcInst(value.Target, value.Inst);
        }
    }
}}