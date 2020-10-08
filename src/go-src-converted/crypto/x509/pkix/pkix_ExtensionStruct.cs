//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:36:56 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using asn1 = go.encoding.asn1_package;
using hex = go.encoding.hex_package;
using fmt = go.fmt_package;
using big = go.math.big_package;
using time = go.time_package;
using go;

namespace go {
namespace crypto {
namespace x509
{
    public static partial class pkix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Extension
        {
            // Constructors
            public Extension(NilType _)
            {
                this.Id = default;
                this.Critical = default;
                this.Value = default;
            }

            public Extension(asn1.ObjectIdentifier Id = default, bool Critical = default, slice<byte> Value = default)
            {
                this.Id = Id;
                this.Critical = Critical;
                this.Value = Value;
            }

            // Enable comparisons between nil and Extension struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Extension value, NilType nil) => value.Equals(default(Extension));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Extension value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Extension value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Extension value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Extension(NilType nil) => default(Extension);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Extension Extension_cast(dynamic value)
        {
            return new Extension(value.Id, value.Critical, value.Value);
        }
    }
}}}