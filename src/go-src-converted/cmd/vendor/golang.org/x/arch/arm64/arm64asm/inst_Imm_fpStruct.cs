//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:44:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace arm64
{
    public static partial class arm64asm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Imm_fp
        {
            // Constructors
            public Imm_fp(NilType _)
            {
                this.s = default;
                this.exp = default;
                this.pre = default;
            }

            public Imm_fp(byte s = default, sbyte exp = default, byte pre = default)
            {
                this.s = s;
                this.exp = exp;
                this.pre = pre;
            }

            // Enable comparisons between nil and Imm_fp struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Imm_fp value, NilType nil) => value.Equals(default(Imm_fp));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Imm_fp value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Imm_fp value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Imm_fp value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Imm_fp(NilType nil) => default(Imm_fp);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Imm_fp Imm_fp_cast(dynamic value)
        {
            return new Imm_fp(value.s, value.exp, value.pre);
        }
    }
}}}}}}}