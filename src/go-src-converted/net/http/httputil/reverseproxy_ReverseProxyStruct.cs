//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:41:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using fmt = go.fmt_package;
using io = go.io_package;
using log = go.log_package;
using net = go.net_package;
using http = go.net.http_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using go;

namespace go {
namespace net {
namespace http
{
    public static partial class httputil_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ReverseProxy
        {
            // Constructors
            public ReverseProxy(NilType _)
            {
                this.Director = default;
                this.Transport = default;
                this.FlushInterval = default;
                this.ErrorLog = default;
                this.BufferPool = default;
                this.ModifyResponse = default;
                this.ErrorHandler = default;
            }

            public ReverseProxy(Action<ptr<http.Request>> Director = default, http.RoundTripper Transport = default, time.Duration FlushInterval = default, ref ptr<log.Logger> ErrorLog = default, BufferPool BufferPool = default, Func<ptr<http.Response>, error> ModifyResponse = default, Action<http.ResponseWriter, ptr<http.Request>, error> ErrorHandler = default)
            {
                this.Director = Director;
                this.Transport = Transport;
                this.FlushInterval = FlushInterval;
                this.ErrorLog = ErrorLog;
                this.BufferPool = BufferPool;
                this.ModifyResponse = ModifyResponse;
                this.ErrorHandler = ErrorHandler;
            }

            // Enable comparisons between nil and ReverseProxy struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ReverseProxy value, NilType nil) => value.Equals(default(ReverseProxy));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ReverseProxy value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ReverseProxy value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ReverseProxy value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ReverseProxy(NilType nil) => default(ReverseProxy);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ReverseProxy ReverseProxy_cast(dynamic value)
        {
            return new ReverseProxy(value.Director, value.Transport, value.FlushInterval, ref value.ErrorLog, value.BufferPool, value.ModifyResponse, value.ErrorHandler);
        }
    }
}}}