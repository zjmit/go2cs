//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:40:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using bio = go.cmd.@internal.bio_package;
using dwarf = go.cmd.@internal.dwarf_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using sym = go.cmd.oldlink.@internal.sym_package;
using fmt = go.fmt_package;
using log = go.log_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class loader_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Reloc
        {
            // Constructors
            public Reloc(NilType _)
            {
                this.Off = default;
                this.Size = default;
                this.Type = default;
                this.Add = default;
                this.Sym = default;
            }

            public Reloc(int Off = default, byte Size = default, objabi.RelocType Type = default, long Add = default, Sym Sym = default)
            {
                this.Off = Off;
                this.Size = Size;
                this.Type = Type;
                this.Add = Add;
                this.Sym = Sym;
            }

            // Enable comparisons between nil and Reloc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Reloc value, NilType nil) => value.Equals(default(Reloc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Reloc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Reloc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Reloc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Reloc(NilType nil) => default(Reloc);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Reloc Reloc_cast(dynamic value)
        {
            return new Reloc(value.Off, value.Size, value.Type, value.Add, value.Sym);
        }
    }
}}}}