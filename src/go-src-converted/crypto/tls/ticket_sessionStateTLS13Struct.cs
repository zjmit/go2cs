//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:38:24 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using aes = go.crypto.aes_package;
using cipher = go.crypto.cipher_package;
using hmac = go.crypto.hmac_package;
using sha256 = go.crypto.sha256_package;
using subtle = go.crypto.subtle_package;
using errors = go.errors_package;
using io = go.io_package;
using cryptobyte = go.golang.org.x.crypto.cryptobyte_package;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sessionStateTLS13
        {
            // Constructors
            public sessionStateTLS13(NilType _)
            {
                this.cipherSuite = default;
                this.createdAt = default;
                this.resumptionSecret = default;
                this.certificate = default;
            }

            public sessionStateTLS13(ushort cipherSuite = default, ulong createdAt = default, slice<byte> resumptionSecret = default, Certificate certificate = default)
            {
                this.cipherSuite = cipherSuite;
                this.createdAt = createdAt;
                this.resumptionSecret = resumptionSecret;
                this.certificate = certificate;
            }

            // Enable comparisons between nil and sessionStateTLS13 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sessionStateTLS13 value, NilType nil) => value.Equals(default(sessionStateTLS13));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sessionStateTLS13 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sessionStateTLS13 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sessionStateTLS13 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sessionStateTLS13(NilType nil) => default(sessionStateTLS13);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static sessionStateTLS13 sessionStateTLS13_cast(dynamic value)
        {
            return new sessionStateTLS13(value.cipherSuite, value.createdAt, value.resumptionSecret, value.certificate);
        }
    }
}}