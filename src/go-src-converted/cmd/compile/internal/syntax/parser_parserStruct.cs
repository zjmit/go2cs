//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:28:18 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class syntax_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct parser
        {
            // Constructors
            public parser(NilType _)
            {
                this.file = default;
                this.errh = default;
                this.mode = default;
                this.pragh = default;
                this.scanner = default;
                this.@base = default;
                this.first = default;
                this.errcnt = default;
                this.pragma = default;
                this.fnest = default;
                this.xnest = default;
                this.indent = default;
            }

            public parser(ref ptr<PosBase> file = default, ErrorHandler errh = default, Mode mode = default, PragmaHandler pragh = default, scanner scanner = default, ref ptr<PosBase> @base = default, error first = default, long errcnt = default, Pragma pragma = default, long fnest = default, long xnest = default, slice<byte> indent = default)
            {
                this.file = file;
                this.errh = errh;
                this.mode = mode;
                this.pragh = pragh;
                this.scanner = scanner;
                this.@base = @base;
                this.first = first;
                this.errcnt = errcnt;
                this.pragma = pragma;
                this.fnest = fnest;
                this.xnest = xnest;
                this.indent = indent;
            }

            // Enable comparisons between nil and parser struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(parser value, NilType nil) => value.Equals(default(parser));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(parser value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, parser value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, parser value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator parser(NilType nil) => default(parser);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static parser parser_cast(dynamic value)
        {
            return new parser(ref value.file, value.errh, value.mode, value.pragh, value.scanner, ref value.@base, value.first, value.errcnt, value.pragma, value.fnest, value.xnest, value.indent);
        }
    }
}}}}