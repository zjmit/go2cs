//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:33:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using elf = go.debug.elf_package;
using macho = go.debug.macho_package;
using pe = go.debug.pe_package;
using fmt = go.fmt_package;
using xcoff = go.@internal.xcoff_package;
using io = go.io_package;
using os = go.os_package;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class version_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct machoExe
        {
            // Constructors
            public machoExe(NilType _)
            {
                this.os = default;
                this.f = default;
            }

            public machoExe(ref ptr<os.File> os = default, ref ptr<macho.File> f = default)
            {
                this.os = os;
                this.f = f;
            }

            // Enable comparisons between nil and machoExe struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(machoExe value, NilType nil) => value.Equals(default(machoExe));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(machoExe value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, machoExe value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, machoExe value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator machoExe(NilType nil) => default(machoExe);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static machoExe machoExe_cast(dynamic value)
        {
            return new machoExe(ref value.os, ref value.f);
        }
    }
}}}}