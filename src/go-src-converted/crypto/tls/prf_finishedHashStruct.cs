//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:38:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using crypto = go.crypto_package;
using hmac = go.crypto.hmac_package;
using md5 = go.crypto.md5_package;
using sha1 = go.crypto.sha1_package;
using sha256 = go.crypto.sha256_package;
using sha512 = go.crypto.sha512_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using hash = go.hash_package;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct finishedHash
        {
            // Constructors
            public finishedHash(NilType _)
            {
                this.client = default;
                this.server = default;
                this.clientMD5 = default;
                this.serverMD5 = default;
                this.buffer = default;
                this.version = default;
                this.prf = default;
            }

            public finishedHash(hash.Hash client = default, hash.Hash server = default, hash.Hash clientMD5 = default, hash.Hash serverMD5 = default, slice<byte> buffer = default, ushort version = default, Action<slice<byte>, slice<byte>, slice<byte>, slice<byte>> prf = default)
            {
                this.client = client;
                this.server = server;
                this.clientMD5 = clientMD5;
                this.serverMD5 = serverMD5;
                this.buffer = buffer;
                this.version = version;
                this.prf = prf;
            }

            // Enable comparisons between nil and finishedHash struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(finishedHash value, NilType nil) => value.Equals(default(finishedHash));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(finishedHash value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, finishedHash value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, finishedHash value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator finishedHash(NilType nil) => default(finishedHash);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static finishedHash finishedHash_cast(dynamic value)
        {
            return new finishedHash(value.client, value.server, value.clientMD5, value.serverMD5, value.buffer, value.version, value.prf);
        }
    }
}}