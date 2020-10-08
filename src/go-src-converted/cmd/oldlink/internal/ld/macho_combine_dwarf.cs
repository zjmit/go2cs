// Copyright 2015 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// package ld -- go2cs converted at 2020 October 08 04:41:41 UTC
// import "cmd/oldlink/internal/ld" ==> using ld = go.cmd.oldlink.@internal.ld_package
// Original source: C:\Go\src\cmd\oldlink\internal\ld\macho_combine_dwarf.go
using bytes = go.bytes_package;
using zlib = go.compress.zlib_package;
using macho = go.debug.macho_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using reflect = go.reflect_package;
using @unsafe = go.@unsafe_package;
using static go.builtin;

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class ld_package
    {
        private static readonly long pageAlign = (long)12L; // 4096 = 1 << 12

        private partial struct loadCmd
        {
            public macho.LoadCmd Cmd;
            public uint Len;
        }

        private partial struct dyldInfoCmd
        {
            public macho.LoadCmd Cmd;
            public uint Len;
            public uint RebaseOff;
            public uint RebaseLen;
            public uint BindOff;
            public uint BindLen;
            public uint WeakBindOff;
            public uint WeakBindLen;
            public uint LazyBindOff;
            public uint LazyBindLen;
            public uint ExportOff;
            public uint ExportLen;
        }

        private partial struct linkEditDataCmd
        {
            public macho.LoadCmd Cmd;
            public uint Len;
            public uint DataOff;
            public uint DataLen;
        }

        private partial struct encryptionInfoCmd
        {
            public macho.LoadCmd Cmd;
            public uint Len;
            public uint CryptOff;
            public uint CryptLen;
            public uint CryptId;
        }

        private partial struct loadCmdReader
        {
            public long offset;
            public long next;
            public ptr<os.File> f;
            public binary.ByteOrder order;
        }

        private static (loadCmd, error) Next(this ptr<loadCmdReader> _addr_r)
        {
            loadCmd _p0 = default;
            error _p0 = default!;
            ref loadCmdReader r = ref _addr_r.val;

            ref loadCmd cmd = ref heap(out ptr<loadCmd> _addr_cmd);

            r.offset = r.next;
            {
                var (_, err) = r.f.Seek(r.offset, 0L);

                if (err != null)
                {
                    return (cmd, error.As(err)!);
                }

            }

            {
                var err = binary.Read(r.f, r.order, _addr_cmd);

                if (err != null)
                {
                    return (cmd, error.As(err)!);
                }

            }

            r.next = r.offset + int64(cmd.Len);
            return (cmd, error.As(null!)!);

        }

        private static error ReadAt(this loadCmdReader r, long offset, object data)
        {
            {
                var (_, err) = r.f.Seek(r.offset + offset, 0L);

                if (err != null)
                {
                    return error.As(err)!;
                }

            }

            return error.As(binary.Read(r.f, r.order, data))!;

        }

        private static error WriteAt(this loadCmdReader r, long offset, object data)
        {
            {
                var (_, err) = r.f.Seek(r.offset + offset, 0L);

                if (err != null)
                {
                    return error.As(err)!;
                }

            }

            return error.As(binary.Write(r.f, r.order, data))!;

        }

        // machoCombineDwarf merges dwarf info generated by dsymutil into a macho executable.
        //
        // With internal linking, DWARF is embedded into the executable, this lets us do the
        // same for external linking.
        // exef is the file of the executable with no DWARF. It must have enough room in the macho
        // header to add the DWARF sections. (Use ld's -headerpad option)
        // exem is the macho representation of exef.
        // dsym is the path to the macho file containing DWARF from dsymutil.
        // outexe is the path where the combined executable should be saved.
        private static error machoCombineDwarf(ptr<Link> _addr_ctxt, ptr<os.File> _addr_exef, ptr<macho.File> _addr_exem, @string dsym, @string outexe) => func((defer, _, __) =>
        {
            ref Link ctxt = ref _addr_ctxt.val;
            ref os.File exef = ref _addr_exef.val;
            ref macho.File exem = ref _addr_exem.val;

            var (dwarff, err) = os.Open(dsym);
            if (err != null)
            {
                return error.As(err)!;
            }

            defer(dwarff.Close());
            var (outf, err) = os.OpenFile(outexe, os.O_RDWR | os.O_CREATE | os.O_TRUNC, 0755L);
            if (err != null)
            {
                return error.As(err)!;
            }

            defer(outf.Close());
            var (dwarfm, err) = macho.NewFile(dwarff);
            if (err != null)
            {
                return error.As(err)!;
            }

            defer(dwarfm.Close()); 

            // The string table needs to be the last thing in the file
            // for code signing to work. So we'll need to move the
            // linkedit section, but all the others can be copied directly.
            var linkseg = exem.Segment("__LINKEDIT");
            if (linkseg == null)
            {
                return error.As(fmt.Errorf("missing __LINKEDIT segment"))!;
            }

            {
                var err__prev1 = err;

                var (_, err) = exef.Seek(0L, 0L);

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }

            {
                var err__prev1 = err;

                (_, err) = io.CopyN(outf, exef, int64(linkseg.Offset));

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }


            var realdwarf = dwarfm.Segment("__DWARF");
            if (realdwarf == null)
            {
                return error.As(fmt.Errorf("missing __DWARF segment"))!;
            } 

            // Try to compress the DWARF sections. This includes some Apple
            // proprietary sections like __apple_types.
            var (compressedSects, compressedBytes, err) = machoCompressSections(_addr_ctxt, _addr_dwarfm);
            if (err != null)
            {
                return error.As(err)!;
            } 

            // Now copy the dwarf data into the output.
            // Kernel requires all loaded segments to be page-aligned in the file,
            // even though we mark this one as being 0 bytes of virtual address space.
            var dwarfstart = machoCalcStart(realdwarf.Offset, linkseg.Offset, pageAlign);
            {
                var err__prev1 = err;

                (_, err) = outf.Seek(dwarfstart, 0L);

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }


            {
                var err__prev1 = err;

                (_, err) = dwarff.Seek(int64(realdwarf.Offset), 0L);

                if (err != null)
                {
                    return error.As(err)!;
                } 

                // Write out the compressed sections, or the originals if we gave up
                // on compressing them.

                err = err__prev1;

            } 

            // Write out the compressed sections, or the originals if we gave up
            // on compressing them.
            ulong dwarfsize = default;
            if (compressedBytes != null)
            {
                dwarfsize = uint64(len(compressedBytes));
                {
                    var err__prev2 = err;

                    (_, err) = outf.Write(compressedBytes);

                    if (err != null)
                    {
                        return error.As(err)!;
                    }

                    err = err__prev2;

                }

            }
            else
            {
                {
                    var err__prev2 = err;

                    (_, err) = io.CopyN(outf, dwarff, int64(realdwarf.Filesz));

                    if (err != null)
                    {
                        return error.As(err)!;
                    }

                    err = err__prev2;

                }

                dwarfsize = realdwarf.Filesz;

            } 

            // And finally the linkedit section.
            {
                var err__prev1 = err;

                (_, err) = exef.Seek(int64(linkseg.Offset), 0L);

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }

            var linkstart = machoCalcStart(linkseg.Offset, uint64(dwarfstart) + dwarfsize, pageAlign);
            {
                var err__prev1 = err;

                (_, err) = outf.Seek(linkstart, 0L);

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }

            {
                var err__prev1 = err;

                (_, err) = io.Copy(outf, exef);

                if (err != null)
                {
                    return error.As(err)!;
                } 

                // Now we need to update the headers.

                err = err__prev1;

            } 

            // Now we need to update the headers.
            var textsect = exem.Section("__text");
            if (textsect == null)
            {
                return error.As(fmt.Errorf("missing __text section"))!;
            }

            var cmdOffset = @unsafe.Sizeof(exem.FileHeader);
            {
                var is64bit = exem.Magic == macho.Magic64;

                if (is64bit)
                { 
                    // mach_header_64 has one extra uint32.
                    cmdOffset += @unsafe.Sizeof(exem.Magic);

                }

            }

            var dwarfCmdOffset = uint32(cmdOffset) + exem.FileHeader.Cmdsz;
            var availablePadding = textsect.Offset - dwarfCmdOffset;
            if (availablePadding < realdwarf.Len)
            {
                return error.As(fmt.Errorf("no room to add dwarf info. Need at least %d padding bytes, found %d", realdwarf.Len, availablePadding))!;
            } 
            // First, copy the dwarf load command into the header. It will be
            // updated later with new offsets and lengths as necessary.
            {
                var err__prev1 = err;

                (_, err) = outf.Seek(int64(dwarfCmdOffset), 0L);

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }

            {
                var err__prev1 = err;

                (_, err) = io.CopyN(outf, bytes.NewReader(realdwarf.Raw()), int64(realdwarf.Len));

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }

            {
                var err__prev1 = err;

                (_, err) = outf.Seek(int64(@unsafe.Offsetof(exem.FileHeader.Ncmd)), 0L);

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }

            {
                var err__prev1 = err;

                var err = binary.Write(outf, exem.ByteOrder, exem.Ncmd + 1L);

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }

            {
                var err__prev1 = err;

                err = binary.Write(outf, exem.ByteOrder, exem.Cmdsz + realdwarf.Len);

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }


            ref loadCmdReader reader = ref heap(new loadCmdReader(next:int64(cmdOffset),f:outf,order:exem.ByteOrder), out ptr<loadCmdReader> _addr_reader);
            for (var i = uint32(0L); i < exem.Ncmd; i++)
            {
                var (cmd, err) = reader.Next();
                if (err != null)
                {
                    return error.As(err)!;
                }

                var linkoffset = uint64(linkstart) - linkseg.Offset;

                if (cmd.Cmd == macho.LoadCmdSegment64) 
                    err = machoUpdateSegment(reader, _addr_linkseg, linkoffset, addr(new macho.Segment64()), addr(new macho.Section64()));
                else if (cmd.Cmd == macho.LoadCmdSegment) 
                    err = machoUpdateSegment(reader, _addr_linkseg, linkoffset, addr(new macho.Segment32()), addr(new macho.Section32()));
                else if (cmd.Cmd == LC_DYLD_INFO || cmd.Cmd == LC_DYLD_INFO_ONLY) 
                    err = machoUpdateLoadCommand(reader, _addr_linkseg, linkoffset, addr(new dyldInfoCmd()), "RebaseOff", "BindOff", "WeakBindOff", "LazyBindOff", "ExportOff");
                else if (cmd.Cmd == macho.LoadCmdSymtab) 
                    err = machoUpdateLoadCommand(reader, _addr_linkseg, linkoffset, addr(new macho.SymtabCmd()), "Symoff", "Stroff");
                else if (cmd.Cmd == macho.LoadCmdDysymtab) 
                    err = machoUpdateLoadCommand(reader, _addr_linkseg, linkoffset, addr(new macho.DysymtabCmd()), "Tocoffset", "Modtaboff", "Extrefsymoff", "Indirectsymoff", "Extreloff", "Locreloff");
                else if (cmd.Cmd == LC_CODE_SIGNATURE || cmd.Cmd == LC_SEGMENT_SPLIT_INFO || cmd.Cmd == LC_FUNCTION_STARTS || cmd.Cmd == LC_DATA_IN_CODE || cmd.Cmd == LC_DYLIB_CODE_SIGN_DRS) 
                    err = machoUpdateLoadCommand(reader, _addr_linkseg, linkoffset, addr(new linkEditDataCmd()), "DataOff");
                else if (cmd.Cmd == LC_ENCRYPTION_INFO || cmd.Cmd == LC_ENCRYPTION_INFO_64) 
                    err = machoUpdateLoadCommand(reader, _addr_linkseg, linkoffset, addr(new encryptionInfoCmd()), "CryptOff");
                else if (cmd.Cmd == macho.LoadCmdDylib || cmd.Cmd == macho.LoadCmdThread || cmd.Cmd == macho.LoadCmdUnixThread || cmd.Cmd == LC_PREBOUND_DYLIB || cmd.Cmd == LC_UUID || cmd.Cmd == LC_VERSION_MIN_MACOSX || cmd.Cmd == LC_VERSION_MIN_IPHONEOS || cmd.Cmd == LC_SOURCE_VERSION || cmd.Cmd == LC_MAIN || cmd.Cmd == LC_LOAD_DYLINKER || cmd.Cmd == LC_LOAD_WEAK_DYLIB || cmd.Cmd == LC_REEXPORT_DYLIB || cmd.Cmd == LC_RPATH || cmd.Cmd == LC_ID_DYLIB || cmd.Cmd == LC_SYMSEG || cmd.Cmd == LC_LOADFVMLIB || cmd.Cmd == LC_IDFVMLIB || cmd.Cmd == LC_IDENT || cmd.Cmd == LC_FVMFILE || cmd.Cmd == LC_PREPAGE || cmd.Cmd == LC_ID_DYLINKER || cmd.Cmd == LC_ROUTINES || cmd.Cmd == LC_SUB_FRAMEWORK || cmd.Cmd == LC_SUB_UMBRELLA || cmd.Cmd == LC_SUB_CLIENT || cmd.Cmd == LC_SUB_LIBRARY || cmd.Cmd == LC_TWOLEVEL_HINTS || cmd.Cmd == LC_PREBIND_CKSUM || cmd.Cmd == LC_ROUTINES_64 || cmd.Cmd == LC_LAZY_LOAD_DYLIB || cmd.Cmd == LC_LOAD_UPWARD_DYLIB || cmd.Cmd == LC_DYLD_ENVIRONMENT || cmd.Cmd == LC_LINKER_OPTION || cmd.Cmd == LC_LINKER_OPTIMIZATION_HINT || cmd.Cmd == LC_VERSION_MIN_TVOS || cmd.Cmd == LC_VERSION_MIN_WATCHOS || cmd.Cmd == LC_VERSION_NOTE || cmd.Cmd == LC_BUILD_VERSION)                 else 
                    err = fmt.Errorf("unknown load command 0x%x (%s)", int(cmd.Cmd), cmd.Cmd);
                                if (err != null)
                {
                    return error.As(err)!;
                }

            } 
            // Do the final update of the DWARF segment's load command.
 
            // Do the final update of the DWARF segment's load command.
            return error.As(machoUpdateDwarfHeader(_addr_reader, compressedSects, dwarfsize, dwarfstart, _addr_realdwarf))!;

        });

        // machoCompressSections tries to compress the DWARF segments in dwarfm,
        // returning the updated sections and segment contents, nils if the sections
        // weren't compressed, or an error if there was a problem reading dwarfm.
        private static (slice<ptr<macho.Section>>, slice<byte>, error) machoCompressSections(ptr<Link> _addr_ctxt, ptr<macho.File> _addr_dwarfm)
        {
            slice<ptr<macho.Section>> _p0 = default;
            slice<byte> _p0 = default;
            error _p0 = default!;
            ref Link ctxt = ref _addr_ctxt.val;
            ref macho.File dwarfm = ref _addr_dwarfm.val;

            if (!ctxt.compressDWARF)
            {
                return (null, null, error.As(null!)!);
            }

            var dwarfseg = dwarfm.Segment("__DWARF");
            slice<ptr<macho.Section>> sects = default;
            bytes.Buffer buf = default;

            foreach (var (_, sect) in dwarfm.Sections)
            {
                if (sect.Seg != "__DWARF")
                {
                    continue;
                } 

                // As of writing, there are no relocations in dsymutil's output
                // so there's no point in worrying about them. Bail out if that
                // changes.
                if (sect.Nreloc != 0L)
                {
                    return (null, null, error.As(null!)!);
                }

                var (data, err) = sect.Data();
                if (err != null)
                {
                    return (null, null, error.As(err)!);
                }

                var (compressed, contents, err) = machoCompressSection(data);
                if (err != null)
                {
                    return (null, null, error.As(err)!);
                }

                ref var newSec = ref heap(sect.val, out ptr<var> _addr_newSec);
                newSec.Offset = uint32(dwarfseg.Offset) + uint32(buf.Len());
                newSec.Addr = dwarfseg.Addr + uint64(buf.Len());
                if (compressed)
                {
                    newSec.Name = "__z" + sect.Name[2L..];
                    newSec.Size = uint64(len(contents));
                }

                sects = append(sects, _addr_newSec);
                buf.Write(contents);

            }
            return (sects, buf.Bytes(), error.As(null!)!);

        }

        // machoCompressSection compresses secBytes if it results in less data.
        private static (bool, slice<byte>, error) machoCompressSection(slice<byte> sectBytes)
        {
            bool compressed = default;
            slice<byte> contents = default;
            error err = default!;

            ref bytes.Buffer buf = ref heap(out ptr<bytes.Buffer> _addr_buf);
            buf.WriteString("ZLIB");
            array<byte> sizeBytes = new array<byte>(8L);
            binary.BigEndian.PutUint64(sizeBytes[..], uint64(len(sectBytes)));
            buf.Write(sizeBytes[..]);

            var z = zlib.NewWriter(_addr_buf);
            {
                var (_, err) = z.Write(sectBytes);

                if (err != null)
                {
                    return (false, null, error.As(err)!);
                }

            }

            {
                var err = z.Close();

                if (err != null)
                {
                    return (false, null, error.As(err)!);
                }

            }

            if (buf.Len() >= len(sectBytes))
            {
                return (false, sectBytes, error.As(null!)!);
            }

            return (true, buf.Bytes(), error.As(null!)!);

        }

        // machoUpdateSegment updates the load command for a moved segment.
        // Only the linkedit segment should move, and it should have 0 sections.
        // seg should be a macho.Segment32 or macho.Segment64 as appropriate.
        // sect should be a macho.Section32 or macho.Section64 as appropriate.
        private static error machoUpdateSegment(loadCmdReader r, ptr<macho.Segment> _addr_linkseg, ulong linkoffset, object seg, object sect)
        {
            ref macho.Segment linkseg = ref _addr_linkseg.val;

            {
                var err__prev1 = err;

                var err = r.ReadAt(0L, seg);

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }

            var segValue = reflect.ValueOf(seg);
            var offset = reflect.Indirect(segValue).FieldByName("Offset"); 

            // Only the linkedit segment moved, anything before that is fine.
            if (offset.Uint() < linkseg.Offset)
            {
                return error.As(null!)!;
            }

            offset.SetUint(offset.Uint() + linkoffset);
            {
                var err__prev1 = err;

                err = r.WriteAt(0L, seg);

                if (err != null)
                {
                    return error.As(err)!;
                } 
                // There shouldn't be any sections, but just to make sure...

                err = err__prev1;

            } 
            // There shouldn't be any sections, but just to make sure...
            return error.As(machoUpdateSections(r, segValue, reflect.ValueOf(sect), linkoffset, null))!;

        }

        private static error machoUpdateSections(loadCmdReader r, reflect.Value seg, reflect.Value sect, ulong deltaOffset, slice<ptr<macho.Section>> compressedSects)
        {
            var iseg = reflect.Indirect(seg);
            var nsect = iseg.FieldByName("Nsect").Uint();
            if (nsect == 0L)
            {
                return error.As(null!)!;
            }

            var sectOffset = int64(iseg.Type().Size());

            var isect = reflect.Indirect(sect);
            var offsetField = isect.FieldByName("Offset");
            var reloffField = isect.FieldByName("Reloff");
            var addrField = isect.FieldByName("Addr");
            var nameField = isect.FieldByName("Name");
            var sizeField = isect.FieldByName("Size");
            var sectSize = int64(isect.Type().Size());
            for (var i = uint64(0L); i < nsect; i++)
            {
                {
                    var err__prev1 = err;

                    var err = r.ReadAt(sectOffset, sect.Interface());

                    if (err != null)
                    {
                        return error.As(err)!;
                    }

                    err = err__prev1;

                }

                if (compressedSects != null)
                {
                    var cSect = compressedSects[i];
                    array<byte> name = new array<byte>(16L);
                    copy(name[..], (slice<byte>)cSect.Name);
                    nameField.Set(reflect.ValueOf(name));
                    sizeField.SetUint(cSect.Size);
                    if (cSect.Offset != 0L)
                    {
                        offsetField.SetUint(uint64(cSect.Offset) + deltaOffset);
                    }

                    if (cSect.Addr != 0L)
                    {
                        addrField.SetUint(cSect.Addr);
                    }

                }
                else
                {
                    if (offsetField.Uint() != 0L)
                    {
                        offsetField.SetUint(offsetField.Uint() + deltaOffset);
                    }

                    if (reloffField.Uint() != 0L)
                    {
                        reloffField.SetUint(reloffField.Uint() + deltaOffset);
                    }

                    if (addrField.Uint() != 0L)
                    {
                        addrField.SetUint(addrField.Uint());
                    }

                }

                {
                    var err__prev1 = err;

                    err = r.WriteAt(sectOffset, sect.Interface());

                    if (err != null)
                    {
                        return error.As(err)!;
                    }

                    err = err__prev1;

                }

                sectOffset += sectSize;

            }

            return error.As(null!)!;

        }

        // machoUpdateDwarfHeader updates the DWARF segment load command.
        private static error machoUpdateDwarfHeader(ptr<loadCmdReader> _addr_r, slice<ptr<macho.Section>> compressedSects, ulong dwarfsize, long dwarfstart, ptr<macho.Segment> _addr_realdwarf)
        {
            ref loadCmdReader r = ref _addr_r.val;
            ref macho.Segment realdwarf = ref _addr_realdwarf.val;

            var seg = default;            var sect = default;

            var (cmd, err) = r.Next();
            if (err != null)
            {
                return error.As(err)!;
            }

            if (cmd.Cmd == macho.LoadCmdSegment64)
            {
                seg = @new<macho.Segment64>();
                sect = @new<macho.Section64>();
            }
            else
            {
                seg = @new<macho.Segment32>();
                sect = @new<macho.Section32>();
            }

            {
                var err__prev1 = err;

                var err = r.ReadAt(0L, seg);

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }

            var segv = reflect.ValueOf(seg).Elem();
            segv.FieldByName("Offset").SetUint(uint64(dwarfstart));

            if (compressedSects != null)
            {
                ulong segSize = default;
                foreach (var (_, newSect) in compressedSects)
                {
                    segSize += newSect.Size;
                }
            else
                segv.FieldByName("Filesz").SetUint(segSize);

            }            {
                segv.FieldByName("Filesz").SetUint(dwarfsize);
            } 

            // We want the DWARF segment to be considered non-loadable, so
            // force vmaddr and vmsize to zero. In addition, set the initial
            // protection to zero so as to make the dynamic loader happy,
            // since otherwise it may complain that that the vm size and file
            // size don't match for the segment. See issues 21647 and 32673
            // for more context. Also useful to refer to the Apple dynamic
            // loader source, specifically ImageLoaderMachO::sniffLoadCommands
            // in ImageLoaderMachO.cpp (various versions can be found online, see
            // https://opensource.apple.com/source/dyld/dyld-519.2.2/src/ImageLoaderMachO.cpp.auto.html
            // as one example).
            segv.FieldByName("Addr").SetUint(0L);
            segv.FieldByName("Memsz").SetUint(0L);
            segv.FieldByName("Prot").SetUint(0L);

            {
                var err__prev1 = err;

                err = r.WriteAt(0L, seg);

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }

            return error.As(machoUpdateSections(r, segv, reflect.ValueOf(sect), uint64(dwarfstart) - realdwarf.Offset, compressedSects))!;

        }

        private static error machoUpdateLoadCommand(loadCmdReader r, ptr<macho.Segment> _addr_linkseg, ulong linkoffset, object cmd, params @string[] fields)
        {
            fields = fields.Clone();
            ref macho.Segment linkseg = ref _addr_linkseg.val;

            {
                var err__prev1 = err;

                var err = r.ReadAt(0L, cmd);

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }

            var value = reflect.Indirect(reflect.ValueOf(cmd));

            foreach (var (_, name) in fields)
            {
                var field = value.FieldByName(name);
                {
                    var fieldval = field.Uint();

                    if (fieldval >= linkseg.Offset)
                    {
                        field.SetUint(fieldval + linkoffset);
                    }

                }

            }
            {
                var err__prev1 = err;

                err = r.WriteAt(0L, cmd);

                if (err != null)
                {
                    return error.As(err)!;
                }

                err = err__prev1;

            }

            return error.As(null!)!;

        }

        private static long machoCalcStart(ulong origAddr, ulong newAddr, uint alignExp)
        {
            var align = uint64(1L << (int)(alignExp));
            var origMod = origAddr % align;
            var newMod = newAddr % align;
            if (origMod == newMod)
            {
                return int64(newAddr);
            }

            return int64(newAddr + align + origMod - newMod);

        }
    }
}}}}
