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
        public partial struct Mem
        {
            // Constructors
            public Mem(NilType _)
            {
                this.Base = default;
                this.Mode = default;
                this.Sign = default;
                this.Index = default;
                this.Shift = default;
                this.Count = default;
                this.Offset = default;
            }

            public Mem(Reg Base = default, AddrMode Mode = default, sbyte Sign = default, Reg Index = default, Shift Shift = default, byte Count = default, short Offset = default)
            {
                this.Base = Base;
                this.Mode = Mode;
                this.Sign = Sign;
                this.Index = Index;
                this.Shift = Shift;
                this.Count = Count;
                this.Offset = Offset;
            }

            // Enable comparisons between nil and Mem struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Mem value, NilType nil) => value.Equals(default(Mem));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Mem value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Mem value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Mem value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Mem(NilType nil) => default(Mem);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Mem Mem_cast(dynamic value)
        {
            return new Mem(value.Base, value.Mode, value.Sign, value.Index, value.Shift, value.Count, value.Offset);
        }
    }
}}}}}}}