//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:31:44 UTC
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
        public partial struct RevokedCertificate
        {
            // Constructors
            public RevokedCertificate(NilType _)
            {
                this.SerialNumber = default;
                this.RevocationTime = default;
                this.Extensions = default;
            }

            public RevokedCertificate(ref ptr<big.Int> SerialNumber = default, time.Time RevocationTime = default, slice<Extension> Extensions = default)
            {
                this.SerialNumber = SerialNumber;
                this.RevocationTime = RevocationTime;
                this.Extensions = Extensions;
            }

            // Enable comparisons between nil and RevokedCertificate struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RevokedCertificate value, NilType nil) => value.Equals(default(RevokedCertificate));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RevokedCertificate value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RevokedCertificate value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RevokedCertificate value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RevokedCertificate(NilType nil) => default(RevokedCertificate);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RevokedCertificate RevokedCertificate_cast(dynamic value)
        {
            return new RevokedCertificate(ref value.SerialNumber, value.RevocationTime, value.Extensions);
        }
    }
}}}