//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:40:16 UTC
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
using base64 = go.encoding.base64_package;
using errors = go.errors_package;
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using mime = go.mime_package;
using multipart = go.mime.multipart_package;
using net = go.net_package;
using httptrace = go.net.http.httptrace_package;
using textproto = go.net.textproto_package;
using url = go.net.url_package;
using strconv = go.strconv_package;
using strings = go.strings_package;
using sync = go.sync_package;
using idna = go.golang.org.x.net.idna_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ProtocolError
        {
            // Constructors
            public ProtocolError(NilType _)
            {
                this.ErrorString = default;
            }

            public ProtocolError(@string ErrorString = default)
            {
                this.ErrorString = ErrorString;
            }

            // Enable comparisons between nil and ProtocolError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ProtocolError value, NilType nil) => value.Equals(default(ProtocolError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ProtocolError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ProtocolError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ProtocolError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ProtocolError(NilType nil) => default(ProtocolError);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ProtocolError ProtocolError_cast(dynamic value)
        {
            return new ProtocolError(value.ErrorString);
        }
    }
}}