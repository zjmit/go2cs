//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 08:33:22 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using tls = go.crypto.tls_package;
using nettrace = go.@internal.nettrace_package;
using net = go.net_package;
using reflect = go.reflect_package;
using time = go.time_package;
using go;

namespace go {
namespace net {
namespace http
{
    public static partial class httptrace_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct clientEventContextKey
        {
            // Constructors
            public clientEventContextKey(NilType _)
            {
            }
            // Enable comparisons between nil and clientEventContextKey struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(clientEventContextKey value, NilType nil) => value.Equals(default(clientEventContextKey));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(clientEventContextKey value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, clientEventContextKey value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, clientEventContextKey value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator clientEventContextKey(NilType nil) => default(clientEventContextKey);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static clientEventContextKey clientEventContextKey_cast(dynamic value)
        {
            return new clientEventContextKey();
        }
    }
}}}