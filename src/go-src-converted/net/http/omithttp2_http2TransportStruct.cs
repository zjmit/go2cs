//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:40:13 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using sync = go.sync_package;
using time = go.time_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct http2Transport
        {
            // Constructors
            public http2Transport(NilType _)
            {
                this.MaxHeaderListSize = default;
            }

            public http2Transport(uint MaxHeaderListSize = default)
            {
                this.MaxHeaderListSize = MaxHeaderListSize;
            }

            // Enable comparisons between nil and http2Transport struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2Transport value, NilType nil) => value.Equals(default(http2Transport));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2Transport value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2Transport value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2Transport value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2Transport(NilType nil) => default(http2Transport);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static http2Transport http2Transport_cast(dynamic value)
        {
            return new http2Transport(value.MaxHeaderListSize);
        }
    }
}}