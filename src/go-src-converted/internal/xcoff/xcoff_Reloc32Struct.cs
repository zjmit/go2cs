//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:02:16 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace @internal
{
    public static partial class xcoff_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Reloc32
        {
            // Constructors
            public Reloc32(NilType _)
            {
                this.Rvaddr = default;
                this.Rsymndx = default;
                this.Rsize = default;
                this.Rtype = default;
            }

            public Reloc32(uint Rvaddr = default, uint Rsymndx = default, byte Rsize = default, byte Rtype = default)
            {
                this.Rvaddr = Rvaddr;
                this.Rsymndx = Rsymndx;
                this.Rsize = Rsize;
                this.Rtype = Rtype;
            }

            // Enable comparisons between nil and Reloc32 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Reloc32 value, NilType nil) => value.Equals(default(Reloc32));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Reloc32 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Reloc32 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Reloc32 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Reloc32(NilType nil) => default(Reloc32);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Reloc32 Reloc32_cast(dynamic value)
        {
            return new Reloc32(value.Rvaddr, value.Rsymndx, value.Rsize, value.Rtype);
        }
    }
}}