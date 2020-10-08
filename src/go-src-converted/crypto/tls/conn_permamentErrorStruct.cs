//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:37:31 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bytes = go.bytes_package;
using cipher = go.crypto.cipher_package;
using subtle = go.crypto.subtle_package;
using x509 = go.crypto.x509_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using net = go.net_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using go;

namespace go {
namespace crypto
{
    public static partial class tls_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct permamentError
        {
            // Constructors
            public permamentError(NilType _)
            {
                this.err = default;
            }

            public permamentError(net.Error err = default)
            {
                this.err = err;
            }

            // Enable comparisons between nil and permamentError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(permamentError value, NilType nil) => value.Equals(default(permamentError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(permamentError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, permamentError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, permamentError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator permamentError(NilType nil) => default(permamentError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static permamentError permamentError_cast(dynamic value)
        {
            return new permamentError(value.err);
        }
    }
}}