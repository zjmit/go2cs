//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:42:05 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using objabi = go.cmd.@internal.objabi_package;
using sym = go.cmd.oldlink.@internal.sym_package;
using binary = go.encoding.binary_package;
using ioutil = go.io.ioutil_package;
using bits = go.math.bits_package;
using filepath = go.path.filepath_package;
using sort = go.sort_package;
using strings = go.strings_package;
using go;

namespace go {
namespace cmd {
namespace oldlink {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct xcoffLoaderReloc
        {
            // Constructors
            public xcoffLoaderReloc(NilType _)
            {
                this.sym = default;
                this.rel = default;
                this.rtype = default;
                this.symndx = default;
            }

            public xcoffLoaderReloc(ref ptr<sym.Symbol> sym = default, ref ptr<sym.Reloc> rel = default, ushort rtype = default, int symndx = default)
            {
                this.sym = sym;
                this.rel = rel;
                this.rtype = rtype;
                this.symndx = symndx;
            }

            // Enable comparisons between nil and xcoffLoaderReloc struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(xcoffLoaderReloc value, NilType nil) => value.Equals(default(xcoffLoaderReloc));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(xcoffLoaderReloc value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, xcoffLoaderReloc value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, xcoffLoaderReloc value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator xcoffLoaderReloc(NilType nil) => default(xcoffLoaderReloc);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static xcoffLoaderReloc xcoffLoaderReloc_cast(dynamic value)
        {
            return new xcoffLoaderReloc(ref value.sym, ref value.rel, value.rtype, value.symndx);
        }
    }
}}}}