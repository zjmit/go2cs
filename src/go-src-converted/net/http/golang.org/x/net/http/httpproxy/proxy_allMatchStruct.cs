//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:40:48 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using fmt = go.fmt_package;
using net = go.net_package;
using url = go.net.url_package;
using os = go.os_package;
using strings = go.strings_package;
using utf8 = go.unicode.utf8_package;
using idna = go.golang.org.x.net.idna_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace net {
namespace http
{
    public static partial class httpproxy_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct allMatch
        {
            // Constructors
            public allMatch(NilType _)
            {
            }
            // Enable comparisons between nil and allMatch struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(allMatch value, NilType nil) => value.Equals(default(allMatch));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(allMatch value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, allMatch value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, allMatch value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator allMatch(NilType nil) => default(allMatch);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static allMatch allMatch_cast(dynamic value)
        {
            return new allMatch();
        }
    }
}}}}}