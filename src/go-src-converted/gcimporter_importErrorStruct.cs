//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:55:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using build = go.go.build_package;
using constant = go.go.constant_package;
using token = go.go.token_package;
using types = go.go.types_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using os = go.os_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using scanner = go.text.scanner_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace @internal
{
    public static partial class gcimporter_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct importError
        {
            // Constructors
            public importError(NilType _)
            {
                this.pos = default;
                this.err = default;
            }

            public importError(scanner.Position pos = default, error err = default)
            {
                this.pos = pos;
                this.err = err;
            }

            // Enable comparisons between nil and importError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(importError value, NilType nil) => value.Equals(default(importError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(importError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, importError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, importError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator importError(NilType nil) => default(importError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static importError importError_cast(dynamic value)
        {
            return new importError(value.pos, value.err);
        }
    }
}}}}}}