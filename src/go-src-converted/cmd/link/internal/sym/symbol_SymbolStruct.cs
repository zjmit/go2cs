//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:37:54 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using elf = go.debug.elf_package;
using fmt = go.fmt_package;
using log = go.log_package;
using go;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class sym_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Symbol
        {
            // Constructors
            public Symbol(NilType _)
            {
                this.Name = default;
                this.Type = default;
                this.Version = default;
                this.Attr = default;
                this.Dynid = default;
                this.Align = default;
                this.Value = default;
                this.Size = default;
                this.Outer = default;
                this.SymIdx = default;
                this.auxinfo = default;
                this.Sect = default;
                this.P = default;
                this.R = default;
            }

            public Symbol(@string Name = default, SymKind Type = default, short Version = default, Attribute Attr = default, int Dynid = default, int Align = default, long Value = default, long Size = default, ref ptr<Symbol> Outer = default, LoaderSym SymIdx = default, ref ptr<AuxSymbol> auxinfo = default, ref ptr<Section> Sect = default, slice<byte> P = default, slice<Reloc> R = default)
            {
                this.Name = Name;
                this.Type = Type;
                this.Version = Version;
                this.Attr = Attr;
                this.Dynid = Dynid;
                this.Align = Align;
                this.Value = Value;
                this.Size = Size;
                this.Outer = Outer;
                this.SymIdx = SymIdx;
                this.auxinfo = auxinfo;
                this.Sect = Sect;
                this.P = P;
                this.R = R;
            }

            // Enable comparisons between nil and Symbol struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Symbol value, NilType nil) => value.Equals(default(Symbol));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Symbol value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Symbol value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Symbol value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Symbol(NilType nil) => default(Symbol);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Symbol Symbol_cast(dynamic value)
        {
            return new Symbol(value.Name, value.Type, value.Version, value.Attr, value.Dynid, value.Align, value.Value, value.Size, ref value.Outer, value.SymIdx, ref value.auxinfo, ref value.Sect, value.P, value.R);
        }
    }
}}}}