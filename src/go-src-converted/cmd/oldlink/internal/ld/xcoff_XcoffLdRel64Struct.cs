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
        public partial struct XcoffLdRel64
        {
            // Constructors
            public XcoffLdRel64(NilType _)
            {
                this.Lvaddr = default;
                this.Lrtype = default;
                this.Lrsecnm = default;
                this.Lsymndx = default;
            }

            public XcoffLdRel64(ulong Lvaddr = default, ushort Lrtype = default, short Lrsecnm = default, int Lsymndx = default)
            {
                this.Lvaddr = Lvaddr;
                this.Lrtype = Lrtype;
                this.Lrsecnm = Lrsecnm;
                this.Lsymndx = Lsymndx;
            }

            // Enable comparisons between nil and XcoffLdRel64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(XcoffLdRel64 value, NilType nil) => value.Equals(default(XcoffLdRel64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(XcoffLdRel64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, XcoffLdRel64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, XcoffLdRel64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator XcoffLdRel64(NilType nil) => default(XcoffLdRel64);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static XcoffLdRel64 XcoffLdRel64_cast(dynamic value)
        {
            return new XcoffLdRel64(value.Lvaddr, value.Lrtype, value.Lrsecnm, value.Lsymndx);
        }
    }
}}}}