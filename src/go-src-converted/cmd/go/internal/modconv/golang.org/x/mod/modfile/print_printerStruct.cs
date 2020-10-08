//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:35:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using fmt = go.fmt_package;
using strings = go.strings_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace mod
{
    public static partial class modfile_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(bytes.Buffer))]
        private partial struct printer
        {
            // Buffer structure promotion - sourced from value copy
            private readonly ptr<Buffer> m_BufferRef;

            private ref Buffer Buffer_val => ref m_BufferRef.Value;

            public ref slice<byte> buf => ref m_BufferRef.Value.buf;

            public ref long off => ref m_BufferRef.Value.off;

            public ref readOp lastRead => ref m_BufferRef.Value.lastRead;

            // Constructors
            public printer(NilType _)
            {
                this.m_BufferRef = new ptr<bytes.Buffer>(new bytes.Buffer(nil));
                this.comment = default;
                this.margin = default;
            }

            public printer(bytes.Buffer Buffer = default, slice<Comment> comment = default, long margin = default)
            {
                this.m_BufferRef = new ptr<bytes.Buffer>(Buffer);
                this.comment = comment;
                this.margin = margin;
            }

            // Enable comparisons between nil and printer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(printer value, NilType nil) => value.Equals(default(printer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(printer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, printer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, printer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator printer(NilType nil) => default(printer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static printer printer_cast(dynamic value)
        {
            return new printer(value.Buffer, value.comment, value.margin);
        }
    }
}}}}