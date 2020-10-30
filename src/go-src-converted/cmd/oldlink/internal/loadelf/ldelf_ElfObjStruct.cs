//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 05:52:04 UTC
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
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loader = go.cmd.oldlink.@internal.loader_package;
using sym = go.cmd.oldlink.@internal.sym_package;
using elf = go.debug.elf_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

#nullable enable

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class loadelf_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ElfObj
        {
            // Constructors
            public ElfObj(NilType _)
            {
                this.f = default;
                this.@base = default;
                this.length = default;
                this.is64 = default;
                this.name = default;
                this.e = default;
                this.sect = default;
                this.nsect = default;
                this.nsymtab = default;
                this.symtab = default;
                this.symstr = default;
                this.type_ = default;
                this.machine = default;
                this.version = default;
                this.entry = default;
                this.phoff = default;
                this.shoff = default;
                this.flags = default;
                this.ehsize = default;
                this.phentsize = default;
                this.phnum = default;
                this.shentsize = default;
                this.shnum = default;
                this.shstrndx = default;
            }

            public ElfObj(ref ptr<bio.Reader> f = default, long @base = default, long length = default, long is64 = default, @string name = default, binary.ByteOrder e = default, slice<ElfSect> sect = default, ulong nsect = default, long nsymtab = default, ref ptr<ElfSect> symtab = default, ref ptr<ElfSect> symstr = default, uint type_ = default, uint machine = default, uint version = default, ulong entry = default, ulong phoff = default, ulong shoff = default, uint flags = default, uint ehsize = default, uint phentsize = default, uint phnum = default, uint shentsize = default, uint shnum = default, uint shstrndx = default)
            {
                this.f = f;
                this.@base = @base;
                this.length = length;
                this.is64 = is64;
                this.name = name;
                this.e = e;
                this.sect = sect;
                this.nsect = nsect;
                this.nsymtab = nsymtab;
                this.symtab = symtab;
                this.symstr = symstr;
                this.type_ = type_;
                this.machine = machine;
                this.version = version;
                this.entry = entry;
                this.phoff = phoff;
                this.shoff = shoff;
                this.flags = flags;
                this.ehsize = ehsize;
                this.phentsize = phentsize;
                this.phnum = phnum;
                this.shentsize = shentsize;
                this.shnum = shnum;
                this.shstrndx = shstrndx;
            }

            // Enable comparisons between nil and ElfObj struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ElfObj value, NilType nil) => value.Equals(default(ElfObj));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ElfObj value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ElfObj value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ElfObj value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ElfObj(NilType nil) => default(ElfObj);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ElfObj ElfObj_cast(dynamic value)
        {
            return new ElfObj(ref value.f, value.@base, value.length, value.is64, value.name, value.e, value.sect, value.nsect, value.nsymtab, ref value.symtab, ref value.symstr, value.type_, value.machine, value.version, value.entry, value.phoff, value.shoff, value.flags, value.ehsize, value.phentsize, value.phnum, value.shentsize, value.shnum, value.shstrndx);
        }
    }
}}}}