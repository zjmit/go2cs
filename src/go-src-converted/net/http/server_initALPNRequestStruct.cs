//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:40:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using bufio = go.bufio_package;
using bytes = go.bytes_package;
using context = go.context_package;
using tls = go.crypto.tls_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using net = go.net_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using path = go.path_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct initALPNRequest
        {
            // Constructors
            public initALPNRequest(NilType _)
            {
                this.ctx = default;
                this.c = default;
                this.h = default;
            }

            public initALPNRequest(context.Context ctx = default, ref ptr<tls.Conn> c = default, serverHandler h = default)
            {
                this.ctx = ctx;
                this.c = c;
                this.h = h;
            }

            // Enable comparisons between nil and initALPNRequest struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(initALPNRequest value, NilType nil) => value.Equals(default(initALPNRequest));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(initALPNRequest value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, initALPNRequest value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, initALPNRequest value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator initALPNRequest(NilType nil) => default(initALPNRequest);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static initALPNRequest initALPNRequest_cast(dynamic value)
        {
            return new initALPNRequest(value.ctx, ref value.c, value.h);
        }
    }
}}