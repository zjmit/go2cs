//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:38:27 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using errors = go.errors_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using textproto = go.net.textproto_package;
using os = go.os_package;
using go;

namespace go {
namespace mime
{
    public static partial class multipart_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sectionReadCloser
        {
            // Constructors
            public sectionReadCloser(NilType _)
            {
                this.SectionReader> = default;
            }

            public sectionReadCloser(ref ptr<io.SectionReader> SectionReader> = default)
            {
                this.SectionReader> = SectionReader>;
            }

            // Enable comparisons between nil and sectionReadCloser struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sectionReadCloser value, NilType nil) => value.Equals(default(sectionReadCloser));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sectionReadCloser value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sectionReadCloser value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sectionReadCloser value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sectionReadCloser(NilType nil) => default(sectionReadCloser);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sectionReadCloser sectionReadCloser_cast(dynamic value)
        {
            return new sectionReadCloser(ref value.SectionReader>);
        }
    }
}}