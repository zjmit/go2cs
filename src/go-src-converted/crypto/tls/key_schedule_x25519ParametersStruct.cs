//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:38:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using elliptic = go.crypto.elliptic_package;
using hmac = go.crypto.hmac_package;
using errors = go.errors_package;
using hash = go.hash_package;
using io = go.io_package;
using big = go.math.big_package;
using cryptobyte = go.golang.org.x.crypto.cryptobyte_package;
using curve25519 = go.golang.org.x.crypto.curve25519_package;
using hkdf = go.golang.org.x.crypto.hkdf_package;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct x25519Parameters
        {
            // Constructors
            public x25519Parameters(NilType _)
            {
                this.privateKey = default;
                this.publicKey = default;
            }

            public x25519Parameters(slice<byte> privateKey = default, slice<byte> publicKey = default)
            {
                this.privateKey = privateKey;
                this.publicKey = publicKey;
            }

            // Enable comparisons between nil and x25519Parameters struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(x25519Parameters value, NilType nil) => value.Equals(default(x25519Parameters));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(x25519Parameters value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, x25519Parameters value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, x25519Parameters value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator x25519Parameters(NilType nil) => default(x25519Parameters);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static x25519Parameters x25519Parameters_cast(dynamic value)
        {
            return new x25519Parameters(value.privateKey, value.publicKey);
        }
    }
}}