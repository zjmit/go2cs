//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:39:17 UTC
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
using gzip = go.compress.gzip_package;
using context = go.context_package;
using rand = go.crypto.rand_package;
using tls = go.crypto.tls_package;
using binary = go.encoding.binary_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using log = go.log_package;
using math = go.math_package;
using mathrand = go.math.rand_package;
using net = go.net_package;
using httptrace = go.net.http.httptrace_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using os = go.os_package;
using reflect = go.reflect_package;
using runtime = go.runtime_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using atomic = go.sync.atomic_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using hpack = go.golang.org.x.net.http2.hpack_package;
using idna = go.golang.org.x.net.idna_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct http2requestBody
        {
            // Constructors
            public http2requestBody(NilType _)
            {
                this._ = default;
                this.stream = default;
                this.conn = default;
                this.closed = default;
                this.sawEOF = default;
                this.pipe = default;
                this.needsContinue = default;
            }

            public http2requestBody(http2incomparable _ = default, ref ptr<http2stream> stream = default, ref ptr<http2serverConn> conn = default, bool closed = default, bool sawEOF = default, ref ptr<http2pipe> pipe = default, bool needsContinue = default)
            {
                this._ = _;
                this.stream = stream;
                this.conn = conn;
                this.closed = closed;
                this.sawEOF = sawEOF;
                this.pipe = pipe;
                this.needsContinue = needsContinue;
            }

            // Enable comparisons between nil and http2requestBody struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(http2requestBody value, NilType nil) => value.Equals(default(http2requestBody));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(http2requestBody value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, http2requestBody value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, http2requestBody value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator http2requestBody(NilType nil) => default(http2requestBody);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static http2requestBody http2requestBody_cast(dynamic value)
        {
            return new http2requestBody(value._, ref value.stream, ref value.conn, value.closed, value.sawEOF, ref value.pipe, value.needsContinue);
        }
    }
}}