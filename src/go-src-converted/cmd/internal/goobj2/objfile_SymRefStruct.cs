//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:50:11 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using bio = go.cmd.@internal.bio_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using unsafeheader = go.@internal.unsafeheader_package;
using io = go.io_package;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace cmd {
namespace @internal
{
    public static partial class goobj2_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SymRef
        {
            // Constructors
            public SymRef(NilType _)
            {
                this.PkgIdx = default;
                this.SymIdx = default;
            }

            public SymRef(uint PkgIdx = default, uint SymIdx = default)
            {
                this.PkgIdx = PkgIdx;
                this.SymIdx = SymIdx;
            }

            // Enable comparisons between nil and SymRef struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SymRef value, NilType nil) => value.Equals(default(SymRef));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SymRef value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SymRef value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SymRef value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SymRef(NilType nil) => default(SymRef);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SymRef SymRef_cast(dynamic value)
        {
            return new SymRef(value.PkgIdx, value.SymIdx);
        }
    }
}}}