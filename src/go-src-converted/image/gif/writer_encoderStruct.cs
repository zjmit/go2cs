//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:59:23 UTC
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
using lzw = go.compress.lzw_package;
using errors = go.errors_package;
using image = go.image_package;
using color = go.image.color_package;
using palette = go.image.color.palette_package;
using draw = go.image.draw_package;
using io = go.io_package;
using go;

namespace go {
namespace image
{
    public static partial class gif_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct encoder
        {
            // Constructors
            public encoder(NilType _)
            {
                this.w = default;
                this.err = default;
                this.g = default;
                this.globalCT = default;
                this.buf = default;
                this.globalColorTable = default;
                this.localColorTable = default;
            }

            public encoder(writer w = default, error err = default, GIF g = default, long globalCT = default, array<byte> buf = default, array<byte> globalColorTable = default, array<byte> localColorTable = default)
            {
                this.w = w;
                this.err = err;
                this.g = g;
                this.globalCT = globalCT;
                this.buf = buf;
                this.globalColorTable = globalColorTable;
                this.localColorTable = localColorTable;
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
            return new encoder(value.w, value.err, value.g, value.globalCT, value.buf, value.globalColorTable, value.localColorTable);
        }
    }
}}