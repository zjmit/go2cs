//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:38:38 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using fmt = go.fmt_package;
using io = go.io_package;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct populateResponse
        {
            // Constructors
            public populateResponse(NilType _)
            {
                this.res = default;
                this.ch = default;
                this.wroteHeader = default;
                this.hasContent = default;
                this.sentResponse = default;
                this.pw = default;
            }

            public populateResponse(ref ptr<Response> res = default, channel<ptr<Response>> ch = default, bool wroteHeader = default, bool hasContent = default, bool sentResponse = default, ref ptr<io.PipeWriter> pw = default)
            {
                this.res = res;
                this.ch = ch;
                this.wroteHeader = wroteHeader;
                this.hasContent = hasContent;
                this.sentResponse = sentResponse;
                this.pw = pw;
            }

            // Enable comparisons between nil and populateResponse struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(populateResponse value, NilType nil) => value.Equals(default(populateResponse));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(populateResponse value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, populateResponse value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, populateResponse value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator populateResponse(NilType nil) => default(populateResponse);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static populateResponse populateResponse_cast(dynamic value)
        {
            return new populateResponse(ref value.res, value.ch, value.wroteHeader, value.hasContent, value.sentResponse, ref value.pw);
        }
    }
}}