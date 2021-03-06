// Copyright 2012 The Go Authors. All rights reserved.
// Use of this source code is governed by a BSD-style
// license that can be found in the LICENSE file.

// Objdump disassembles executable files.
//
// Usage:
//
//    go tool objdump [-s symregexp] binary
//
// Objdump prints a disassembly of all text symbols (code) in the binary.
// If the -s option is present, objdump only disassembles
// symbols with names matching the regular expression.
//
// Alternate usage:
//
//    go tool objdump binary start end
//
// In this mode, objdump disassembles the binary starting at the start address and
// stopping at the end address. The start and end addresses are program
// counters written in hexadecimal with optional leading 0x prefix.
// In this mode, objdump prints a sequence of stanzas of the form:
//
//    file:line
//     address: assembly
//     address: assembly
//     ...
//
// Each stanza gives the disassembly for a contiguous range of addresses
// all mapped to the same original source file and line number.
// This mode is intended for use by pprof.
// package main -- go2cs converted at 2020 October 09 05:50:40 UTC
// Original source: C:\Go\src\cmd\objdump\main.go
using flag = go.flag_package;
using fmt = go.fmt_package;
using log = go.log_package;
using os = go.os_package;
using regexp = go.regexp_package;
using strconv = go.strconv_package;
using strings = go.strings_package;

using objfile = go.cmd.@internal.objfile_package;
using static go.builtin;

namespace go
{
    public static partial class main_package
    {
        private static var printCode = flag.Bool("S", false, "print Go code alongside assembly");
        private static var symregexp = flag.String("s", "", "only dump symbols matching this regexp");
        private static var gnuAsm = flag.Bool("gnu", false, "print GNU assembly next to Go assembly (where supported)");
        private static ptr<regexp.Regexp> symRE;

        private static void usage()
        {
            fmt.Fprintf(os.Stderr, "usage: go tool objdump [-S] [-gnu] [-s symregexp] binary [start end]\n\n");
            flag.PrintDefaults();
            os.Exit(2L);
        }

        private static void Main() => func((defer, _, __) =>
        {
            log.SetFlags(0L);
            log.SetPrefix("objdump: ");

            flag.Usage = usage;
            flag.Parse();
            if (flag.NArg() != 1L && flag.NArg() != 3L)
            {
                usage();
            }

            if (symregexp != "".val)
            {
                var (re, err) = regexp.Compile(symregexp.val);
                if (err != null)
                {
                    log.Fatalf("invalid -s regexp: %v", err);
                }

                symRE = re;

            }

            var (f, err) = objfile.Open(flag.Arg(0L));
            if (err != null)
            {
                log.Fatal(err);
            }

            defer(f.Close());

            var (dis, err) = f.Disasm();
            if (err != null)
            {
                log.Fatalf("disassemble %s: %v", flag.Arg(0L), err);
            }

            switch (flag.NArg())
            {
                case 1L: 
                    // disassembly of entire object
                    dis.Print(os.Stdout, symRE, 0L, ~uint64(0L), printCode.val, gnuAsm.val);
                    break;
                case 3L: 
                    // disassembly of PC range
                    var (start, err) = strconv.ParseUint(strings.TrimPrefix(flag.Arg(1L), "0x"), 16L, 64L);
                    if (err != null)
                    {
                        log.Fatalf("invalid start PC: %v", err);
                    }

                    var (end, err) = strconv.ParseUint(strings.TrimPrefix(flag.Arg(2L), "0x"), 16L, 64L);
                    if (err != null)
                    {
                        log.Fatalf("invalid end PC: %v", err);
                    }

                    dis.Print(os.Stdout, symRE, start, end, printCode.val, gnuAsm.val);
                    break;
                default: 
                    usage();
                    break;
            }

        });
    }
}
