//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:41:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using bio = go.cmd.@internal.bio_package;
using obj = go.cmd.@internal.obj_package;
using objabi = go.cmd.@internal.objabi_package;
using sys = go.cmd.@internal.sys_package;
using loadelf = go.cmd.oldlink.@internal.loadelf_package;
using loader = go.cmd.oldlink.@internal.loader_package;
using loadmacho = go.cmd.oldlink.@internal.loadmacho_package;
using loadpe = go.cmd.oldlink.@internal.loadpe_package;
using loadxcoff = go.cmd.oldlink.@internal.loadxcoff_package;
using objfile = go.cmd.oldlink.@internal.objfile_package;
using sym = go.cmd.oldlink.@internal.sym_package;
using sha1 = go.crypto.sha1_package;
using elf = go.debug.elf_package;
using macho = go.debug.macho_package;
using base64 = go.encoding.base64_package;
using binary = go.encoding.binary_package;
using hex = go.encoding.hex_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using os = go.os_package;
using exec = go.os.exec_package;
using filepath = go.path.filepath_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strings = go.strings_package;
using sync = go.sync_package;
using go;

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Arch
        {
            // Constructors
            public Arch(NilType _)
            {
                this.Funcalign = default;
                this.Maxalign = default;
                this.Minalign = default;
                this.Dwarfregsp = default;
                this.Dwarfreglr = default;
                this.Androiddynld = default;
                this.Linuxdynld = default;
                this.Freebsddynld = default;
                this.Netbsddynld = default;
                this.Openbsddynld = default;
                this.Dragonflydynld = default;
                this.Solarisdynld = default;
                this.Adddynrel = default;
                this.Archinit = default;
                this.Archreloc = default;
                this.Archrelocvariant = default;
                this.Trampoline = default;
                this.Asmb = default;
                this.Asmb2 = default;
                this.Elfreloc1 = default;
                this.Elfsetupplt = default;
                this.Gentext = default;
                this.Machoreloc1 = default;
                this.PEreloc1 = default;
                this.Xcoffreloc1 = default;
                this.TLSIEtoLE = default;
                this.AssignAddress = default;
            }

            public Arch(long Funcalign = default, long Maxalign = default, long Minalign = default, long Dwarfregsp = default, long Dwarfreglr = default, @string Androiddynld = default, @string Linuxdynld = default, @string Freebsddynld = default, @string Netbsddynld = default, @string Openbsddynld = default, @string Dragonflydynld = default, @string Solarisdynld = default, Func<ptr<Link>, ptr<sym.Symbol>, ptr<sym.Reloc>, bool> Adddynrel = default, Action<ptr<Link>> Archinit = default, Func<ptr<Link>, ptr<sym.Reloc>, ptr<sym.Symbol>, long, (long, bool)> Archreloc = default, Func<ptr<Link>, ptr<sym.Reloc>, ptr<sym.Symbol>, long, long> Archrelocvariant = default, Action<ptr<Link>, ptr<sym.Reloc>, ptr<sym.Symbol>> Trampoline = default, Action<ptr<Link>> Asmb = default, Action<ptr<Link>> Asmb2 = default, Func<ptr<Link>, ptr<sym.Reloc>, long, bool> Elfreloc1 = default, Action<ptr<Link>> Elfsetupplt = default, Action<ptr<Link>> Gentext = default, Func<ptr<sys.Arch>, ptr<OutBuf>, ptr<sym.Symbol>, ptr<sym.Reloc>, long, bool> Machoreloc1 = default, Func<ptr<sys.Arch>, ptr<OutBuf>, ptr<sym.Symbol>, ptr<sym.Reloc>, long, bool> PEreloc1 = default, Func<ptr<sys.Arch>, ptr<OutBuf>, ptr<sym.Symbol>, ptr<sym.Reloc>, long, bool> Xcoffreloc1 = default, Action<ptr<sym.Symbol>, long, long> TLSIEtoLE = default, Func<ptr<Link>, ptr<sym.Section>, long, ptr<sym.Symbol>, ulong, bool, (ptr<sym.Section>, long, ulong)> AssignAddress = default)
            {
                this.Funcalign = Funcalign;
                this.Maxalign = Maxalign;
                this.Minalign = Minalign;
                this.Dwarfregsp = Dwarfregsp;
                this.Dwarfreglr = Dwarfreglr;
                this.Androiddynld = Androiddynld;
                this.Linuxdynld = Linuxdynld;
                this.Freebsddynld = Freebsddynld;
                this.Netbsddynld = Netbsddynld;
                this.Openbsddynld = Openbsddynld;
                this.Dragonflydynld = Dragonflydynld;
                this.Solarisdynld = Solarisdynld;
                this.Adddynrel = Adddynrel;
                this.Archinit = Archinit;
                this.Archreloc = Archreloc;
                this.Archrelocvariant = Archrelocvariant;
                this.Trampoline = Trampoline;
                this.Asmb = Asmb;
                this.Asmb2 = Asmb2;
                this.Elfreloc1 = Elfreloc1;
                this.Elfsetupplt = Elfsetupplt;
                this.Gentext = Gentext;
                this.Machoreloc1 = Machoreloc1;
                this.PEreloc1 = PEreloc1;
                this.Xcoffreloc1 = Xcoffreloc1;
                this.TLSIEtoLE = TLSIEtoLE;
                this.AssignAddress = AssignAddress;
            }

            // Enable comparisons between nil and Arch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Arch value, NilType nil) => value.Equals(default(Arch));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Arch value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Arch value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Arch value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Arch(NilType nil) => default(Arch);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Arch Arch_cast(dynamic value)
        {
            return new Arch(value.Funcalign, value.Maxalign, value.Minalign, value.Dwarfregsp, value.Dwarfreglr, value.Androiddynld, value.Linuxdynld, value.Freebsddynld, value.Netbsddynld, value.Openbsddynld, value.Dragonflydynld, value.Solarisdynld, value.Adddynrel, value.Archinit, value.Archreloc, value.Archrelocvariant, value.Trampoline, value.Asmb, value.Asmb2, value.Elfreloc1, value.Elfsetupplt, value.Gentext, value.Machoreloc1, value.PEreloc1, value.Xcoffreloc1, value.TLSIEtoLE, value.AssignAddress);
        }
    }
}}}}