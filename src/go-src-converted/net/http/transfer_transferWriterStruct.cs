//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:40:38 UTC
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
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using httptrace = go.net.http.httptrace_package;
using @internal = go.net.http.@internal_package;
using textproto = go.net.textproto_package;
using reflect = go.reflect_package;
using sort = go.sort_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using time = go.time_package;
using httpguts = go.golang.org.x.net.http.httpguts_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct transferWriter
        {
            // Constructors
            public transferWriter(NilType _)
            {
                this.Method = default;
                this.Body = default;
                this.BodyCloser = default;
                this.ResponseToHEAD = default;
                this.ContentLength = default;
                this.Close = default;
                this.TransferEncoding = default;
                this.Header = default;
                this.Trailer = default;
                this.IsResponse = default;
                this.bodyReadError = default;
                this.FlushHeaders = default;
                this.ByteReadCh = default;
            }

            public transferWriter(@string Method = default, io.Reader Body = default, io.Closer BodyCloser = default, bool ResponseToHEAD = default, long ContentLength = default, bool Close = default, slice<@string> TransferEncoding = default, Header Header = default, Header Trailer = default, bool IsResponse = default, error bodyReadError = default, bool FlushHeaders = default, channel<readResult> ByteReadCh = default)
            {
                this.Method = Method;
                this.Body = Body;
                this.BodyCloser = BodyCloser;
                this.ResponseToHEAD = ResponseToHEAD;
                this.ContentLength = ContentLength;
                this.Close = Close;
                this.TransferEncoding = TransferEncoding;
                this.Header = Header;
                this.Trailer = Trailer;
                this.IsResponse = IsResponse;
                this.bodyReadError = bodyReadError;
                this.FlushHeaders = FlushHeaders;
                this.ByteReadCh = ByteReadCh;
            }

            // Enable comparisons between nil and transferWriter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(transferWriter value, NilType nil) => value.Equals(default(transferWriter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(transferWriter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, transferWriter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, transferWriter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator transferWriter(NilType nil) => default(transferWriter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static transferWriter transferWriter_cast(dynamic value)
        {
            return new transferWriter(value.Method, value.Body, value.BodyCloser, value.ResponseToHEAD, value.ContentLength, value.Close, value.TransferEncoding, value.Header, value.Trailer, value.IsResponse, value.bodyReadError, value.FlushHeaders, value.ByteReadCh);
        }
    }
}}