//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:31:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using io = go.io_package;
using bits = go.math.bits_package;
using strconv = go.strconv_package;
using sync = go.sync_package;
using go;

namespace go {
namespace compress
{
    public static partial class flate_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct huffmanDecoder
        {
            // Constructors
            public huffmanDecoder(NilType _)
            {
                this.min = default;
                this.chunks = default;
                this.links = default;
                this.linkMask = default;
            }

            public huffmanDecoder(long min = default, array<uint> chunks = default, slice<slice<uint>> links = default, uint linkMask = default)
            {
                this.min = min;
                this.chunks = chunks;
                this.links = links;
                this.linkMask = linkMask;
            }

            // Enable comparisons between nil and huffmanDecoder struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(huffmanDecoder value, NilType nil) => value.Equals(default(huffmanDecoder));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(huffmanDecoder value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, huffmanDecoder value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, huffmanDecoder value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator huffmanDecoder(NilType nil) => default(huffmanDecoder);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static huffmanDecoder huffmanDecoder_cast(dynamic value)
        {
            return new huffmanDecoder(value.min, value.chunks, value.links, value.linkMask);
        }
    }
}}