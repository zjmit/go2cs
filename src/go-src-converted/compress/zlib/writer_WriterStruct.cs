//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:49:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using flate = go.compress.flate_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using hash = go.hash_package;
using adler32 = go.hash.adler32_package;
using io = go.io_package;
using go;

namespace go {
namespace compress
{
    public static partial class zlib_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Writer
        {
            // Constructors
            public Writer(NilType _)
            {
                this.w = default;
                this.level = default;
                this.dict = default;
                this.compressor = default;
                this.digest = default;
                this.err = default;
                this.scratch = default;
                this.wroteHeader = default;
            }

            public Writer(io.Writer w = default, long level = default, slice<byte> dict = default, ref ptr<flate.Writer> compressor = default, hash.Hash32 digest = default, error err = default, array<byte> scratch = default, bool wroteHeader = default)
            {
                this.w = w;
                this.level = level;
                this.dict = dict;
                this.compressor = compressor;
                this.digest = digest;
                this.err = err;
                this.scratch = scratch;
                this.wroteHeader = wroteHeader;
            }

            // Enable comparisons between nil and Writer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Writer value, NilType nil) => value.Equals(default(Writer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Writer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Writer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Writer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Writer(NilType nil) => default(Writer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Writer Writer_cast(dynamic value)
        {
            return new Writer(value.w, value.level, value.dict, ref value.compressor, value.digest, value.err, value.scratch, value.wroteHeader);
        }
    }
}}