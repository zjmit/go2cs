//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:38:30 UTC
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
using fmt = go.fmt_package;
using io = go.io_package;
using ioutil = go.io.ioutil_package;
using mime = go.mime_package;
using quotedprintable = go.mime.quotedprintable_package;
using textproto = go.net.textproto_package;
using strings = go.strings_package;
using go;

namespace go {
namespace mime
{
    public static partial class multipart_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Reader
        {
            // Constructors
            public Reader(NilType _)
            {
                this.bufReader = default;
                this.currentPart = default;
                this.partsRead = default;
                this.nl = default;
                this.nlDashBoundary = default;
                this.dashBoundaryDash = default;
                this.dashBoundary = default;
            }

            public Reader(ref ptr<bufio.Reader> bufReader = default, ref ptr<Part> currentPart = default, long partsRead = default, slice<byte> nl = default, slice<byte> nlDashBoundary = default, slice<byte> dashBoundaryDash = default, slice<byte> dashBoundary = default)
            {
                this.bufReader = bufReader;
                this.currentPart = currentPart;
                this.partsRead = partsRead;
                this.nl = nl;
                this.nlDashBoundary = nlDashBoundary;
                this.dashBoundaryDash = dashBoundaryDash;
                this.dashBoundary = dashBoundary;
            }

            // Enable comparisons between nil and Reader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Reader value, NilType nil) => value.Equals(default(Reader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Reader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Reader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Reader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Reader(NilType nil) => default(Reader);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Reader Reader_cast(dynamic value)
        {
            return new Reader(ref value.bufReader, ref value.currentPart, value.partsRead, value.nl, value.nlDashBoundary, value.dashBoundaryDash, value.dashBoundary);
        }
    }
}}