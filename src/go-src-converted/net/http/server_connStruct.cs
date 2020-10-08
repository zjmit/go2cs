//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:40:31 UTC
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
        private partial struct conn
        {
            // Constructors
            public conn(NilType _)
            {
                this.server = default;
                this.cancelCtx = default;
                this.rwc = default;
                this.remoteAddr = default;
                this.tlsState = default;
                this.werr = default;
                this.r = default;
                this.bufr = default;
                this.bufw = default;
                this.lastMethod = default;
                this.curReq = default;
                this.mu = default;
                this.hijackedv = default;
            }

            public conn(ref ptr<Server> server = default, context.CancelFunc cancelCtx = default, net.Conn rwc = default, @string remoteAddr = default, ref ptr<tls.ConnectionState> tlsState = default, error werr = default, ref ptr<connReader> r = default, ref ptr<bufio.Reader> bufr = default, ref ptr<bufio.Writer> bufw = default, @string lastMethod = default, atomic.Value curReq = default, sync.Mutex mu = default, bool hijackedv = default)
            {
                this.server = server;
                this.cancelCtx = cancelCtx;
                this.rwc = rwc;
                this.remoteAddr = remoteAddr;
                this.tlsState = tlsState;
                this.werr = werr;
                this.r = r;
                this.bufr = bufr;
                this.bufw = bufw;
                this.lastMethod = lastMethod;
                this.curReq = curReq;
                this.mu = mu;
                this.hijackedv = hijackedv;
            }

            // Enable comparisons between nil and conn struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(conn value, NilType nil) => value.Equals(default(conn));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(conn value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, conn value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, conn value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator conn(NilType nil) => default(conn);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static conn conn_cast(dynamic value)
        {
            return new conn(ref value.server, value.cancelCtx, value.rwc, value.remoteAddr, ref value.tlsState, value.werr, ref value.r, ref value.bufr, ref value.bufw, value.lastMethod, value.curReq, value.mu, value.hijackedv);
        }
    }
}}