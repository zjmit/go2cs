//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct CryptoReportLarval
        {
            // Constructors
            public CryptoReportLarval(NilType _)
            {
                this.Type = default;
            }

            public CryptoReportLarval(array<sbyte> Type = default)
            {
                this.Type = Type;
            }

            // Enable comparisons between nil and CryptoReportLarval struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(CryptoReportLarval value, NilType nil) => value.Equals(default(CryptoReportLarval));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(CryptoReportLarval value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, CryptoReportLarval value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, CryptoReportLarval value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator CryptoReportLarval(NilType nil) => default(CryptoReportLarval);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static CryptoReportLarval CryptoReportLarval_cast(dynamic value)
        {
            return new CryptoReportLarval(value.Type);
        }
    }
}}}}}}