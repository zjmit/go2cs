//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:42:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using encoding = go.encoding_package;
using binary = go.encoding.binary_package;
using math = go.math_package;
using bits = go.math.bits_package;
using reflect = go.reflect_package;
using sync = go.sync_package;
using go;

namespace go {
namespace encoding
{
    public static partial class gob_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct encInstr
        {
            // Constructors
            public encInstr(NilType _)
            {
                this.op = default;
                this.field = default;
                this.index = default;
                this.indir = default;
            }

            public encInstr(encOp op = default, long field = default, slice<long> index = default, long indir = default)
            {
                this.op = op;
                this.field = field;
                this.index = index;
                this.indir = indir;
            }

            // Enable comparisons between nil and encInstr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(encInstr value, NilType nil) => value.Equals(default(encInstr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(encInstr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, encInstr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, encInstr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator encInstr(NilType nil) => default(encInstr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static encInstr encInstr_cast(dynamic value)
        {
            return new encInstr(value.op, value.field, value.index, value.indir);
        }
    }
}}