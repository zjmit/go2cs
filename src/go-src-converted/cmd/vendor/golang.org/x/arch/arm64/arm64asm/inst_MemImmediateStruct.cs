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
        public partial struct MemImmediate
        {
            // Constructors
            public MemImmediate(NilType _)
            {
                this.Base = default;
                this.Mode = default;
                this.imm = default;
            }

            public MemImmediate(RegSP Base = default, AddrMode Mode = default, int imm = default)
            {
                this.Base = Base;
                this.Mode = Mode;
                this.imm = imm;
            }

            // Enable comparisons between nil and MemImmediate struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(MemImmediate value, NilType nil) => value.Equals(default(MemImmediate));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(MemImmediate value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, MemImmediate value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, MemImmediate value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator MemImmediate(NilType nil) => default(MemImmediate);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static MemImmediate MemImmediate_cast(dynamic value)
        {
            return new MemImmediate(value.Base, value.Mode, value.imm);
        }
    }
}}}}}}}