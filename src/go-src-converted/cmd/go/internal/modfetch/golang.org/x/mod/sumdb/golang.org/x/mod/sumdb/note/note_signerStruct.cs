//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:36:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using sha256 = go.crypto.sha256_package;
using base64 = go.encoding.base64_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using unicode = go.unicode_package;
using utf8 = go.unicode.utf8_package;
using ed25519 = go.golang.org.x.crypto.ed25519_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace mod {
namespace sumdb
{
    public static partial class note_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct signer
        {
            // Constructors
            public signer(NilType _)
            {
                this.name = default;
                this.hash = default;
                this.sign = default;
            }

            public signer(@string name = default, uint hash = default, Func<slice<byte>, (slice<byte>, error)> sign = default)
            {
                this.name = name;
                this.hash = hash;
                this.sign = sign;
            }

            // Enable comparisons between nil and signer struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(signer value, NilType nil) => value.Equals(default(signer));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(signer value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, signer value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, signer value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator signer(NilType nil) => default(signer);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static signer signer_cast(dynamic value)
        {
            return new signer(value.name, value.hash, value.sign);
        }
    }
}}}}}