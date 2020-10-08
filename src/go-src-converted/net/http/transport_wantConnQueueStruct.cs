//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:40:47 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using gzip = go.compress.gzip_package;
using list = go.container.list_package;
using context = go.context_package;
using tls = go.crypto.tls_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using net = go.net_package;
using httptrace = go.net.http.httptrace_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using reflect = go.reflect_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using httpproxy = go.golang.org.x.net.http.httpproxy_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct wantConnQueue
        {
            // Constructors
            public wantConnQueue(NilType _)
            {
                this.head = default;
                this.headPos = default;
                this.tail = default;
            }

            public wantConnQueue(slice<ptr<wantConn>> head = default, long headPos = default, slice<ptr<wantConn>> tail = default)
            {
                this.head = head;
                this.headPos = headPos;
                this.tail = tail;
            }

            // Enable comparisons between nil and wantConnQueue struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(wantConnQueue value, NilType nil) => value.Equals(default(wantConnQueue));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(wantConnQueue value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, wantConnQueue value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, wantConnQueue value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator wantConnQueue(NilType nil) => default(wantConnQueue);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static wantConnQueue wantConnQueue_cast(dynamic value)
        {
            return new wantConnQueue(value.head, value.headPos, value.tail);
        }
    }
}}