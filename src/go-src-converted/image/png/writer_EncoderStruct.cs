//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:59:40 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using zlib = go.compress.zlib_package;
using binary = go.encoding.binary_package;
using crc32 = go.hash.crc32_package;
using image = go.image_package;
using color = go.image.color_package;
using io = go.io_package;
using strconv = go.strconv_package;
using go;

namespace go {
namespace image
{
    public static partial class png_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct encoder
        {
            // Constructors
            public encoder(NilType _)
            {
                this.enc = default;
                this.w = default;
                this.m = default;
                this.cb = default;
                this.err = default;
                this.header = default;
                this.footer = default;
                this.tmp = default;
                this.cr = default;
                this.pr = default;
                this.zw = default;
                this.zwLevel = default;
                this.bw = default;
            }

            public encoder(ref ptr<Encoder> enc = default, io.Writer w = default, image.Image m = default, long cb = default, error err = default, array<byte> header = default, array<byte> footer = default, array<byte> tmp = default, array<slice<byte>> cr = default, slice<byte> pr = default, ref ptr<zlib.Writer> zw = default, long zwLevel = default, ref ptr<bufio.Writer> bw = default)
            {
                this.enc = enc;
                this.w = w;
                this.m = m;
                this.cb = cb;
                this.err = err;
                this.header = header;
                this.footer = footer;
                this.tmp = tmp;
                this.cr = cr;
                this.pr = pr;
                this.zw = zw;
                this.zwLevel = zwLevel;
                this.bw = bw;
            }

            // Enable comparisons between nil and encoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(encoder value, NilType nil) => value.Equals(default(encoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(encoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, encoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, encoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator encoder(NilType nil) => default(encoder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static encoder encoder_cast(dynamic value)
        {
            return new encoder(ref value.enc, value.w, value.m, value.cb, value.err, value.header, value.footer, value.tmp, value.cr, value.pr, ref value.zw, value.zwLevel, ref value.bw);
        }
    }
}}