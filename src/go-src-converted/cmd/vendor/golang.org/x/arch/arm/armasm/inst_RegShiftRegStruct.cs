//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:44:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace arm
{
    public static partial class armasm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RegShiftReg
        {
            // Constructors
            public RegShiftReg(NilType _)
            {
                this.Reg = default;
                this.Shift = default;
                this.RegCount = default;
            }

            public RegShiftReg(Reg Reg = default, Shift Shift = default, Reg RegCount = default)
            {
                this.Reg = Reg;
                this.Shift = Shift;
                this.RegCount = RegCount;
            }

            // Enable comparisons between nil and RegShiftReg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RegShiftReg value, NilType nil) => value.Equals(default(RegShiftReg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RegShiftReg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RegShiftReg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RegShiftReg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RegShiftReg(NilType nil) => default(RegShiftReg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RegShiftReg RegShiftReg_cast(dynamic value)
        {
            return new RegShiftReg(value.Reg, value.Shift, value.RegCount);
        }
    }
}}}}}}}