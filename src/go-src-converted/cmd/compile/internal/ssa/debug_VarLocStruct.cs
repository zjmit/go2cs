//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:10:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using dwarf = go.cmd.@internal.dwarf_package;
using obj = go.cmd.@internal.obj_package;
using hex = go.encoding.hex_package;
using fmt = go.fmt_package;
using bits = go.math.bits_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct VarLoc
        {
            // Constructors
            public VarLoc(NilType _)
            {
                this.Registers = default;
                this.StackOffset = default;
            }

            public VarLoc(RegisterSet Registers = default, StackOffset StackOffset = default)
            {
                this.Registers = Registers;
                this.StackOffset = StackOffset;
            }

            // Enable comparisons between nil and VarLoc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(VarLoc value, NilType nil) => value.Equals(default(VarLoc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(VarLoc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, VarLoc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, VarLoc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator VarLoc(NilType nil) => default(VarLoc);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static VarLoc VarLoc_cast(dynamic value)
        {
            return new VarLoc(value.Registers, value.StackOffset);
        }
    }
}}}}