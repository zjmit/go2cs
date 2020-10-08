//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:36:44 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using crypto = go.crypto_package;
using aes = go.crypto.aes_package;
using cipher = go.crypto.cipher_package;
using des = go.crypto.des_package;
using hmac = go.crypto.hmac_package;
using rc4 = go.crypto.rc4_package;
using sha1 = go.crypto.sha1_package;
using sha256 = go.crypto.sha256_package;
using x509 = go.crypto.x509_package;
using fmt = go.fmt_package;
using hash = go.hash_package;
using chacha20poly1305 = go.golang.org.x.crypto.chacha20poly1305_package;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct tls10MAC
        {
            // Constructors
            public tls10MAC(NilType _)
            {
                this.h = default;
                this.buf = default;
            }

            public tls10MAC(hash.Hash h = default, slice<byte> buf = default)
            {
                this.h = h;
                this.buf = buf;
            }

            // Enable comparisons between nil and tls10MAC struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(tls10MAC value, NilType nil) => value.Equals(default(tls10MAC));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(tls10MAC value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, tls10MAC value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, tls10MAC value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator tls10MAC(NilType nil) => default(tls10MAC);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static tls10MAC tls10MAC_cast(dynamic value)
        {
            return new tls10MAC(value.h, value.buf);
        }
    }
}}