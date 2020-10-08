//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:37:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bio = go.cmd.@internal.bio_package;
using objabi = go.cmd.@internal.objabi_package;
using sym = go.cmd.link.@internal.sym_package;
using binary = go.encoding.binary_package;
using fmt = go.fmt_package;
using io = go.io_package;
using os = go.os_package;
using go;

namespace go {
namespace cmd {
namespace link {
namespace @internal
{
    public static partial class ld_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ArHdr
        {
            // Constructors
            public ArHdr(NilType _)
            {
                this.name = default;
                this.date = default;
                this.uid = default;
                this.gid = default;
                this.mode = default;
                this.size = default;
                this.fmag = default;
            }

            public ArHdr(@string name = default, @string date = default, @string uid = default, @string gid = default, @string mode = default, @string size = default, @string fmag = default)
            {
                this.name = name;
                this.date = date;
                this.uid = uid;
                this.gid = gid;
                this.mode = mode;
                this.size = size;
                this.fmag = fmag;
            }

            // Enable comparisons between nil and ArHdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ArHdr value, NilType nil) => value.Equals(default(ArHdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ArHdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ArHdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ArHdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ArHdr(NilType nil) => default(ArHdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ArHdr ArHdr_cast(dynamic value)
        {
            return new ArHdr(value.name, value.date, value.uid, value.gid, value.mode, value.size, value.fmag);
        }
    }
}}}}