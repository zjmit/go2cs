//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:31 UTC
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
        public partial struct SockFilter
        {
            // Constructors
            public SockFilter(NilType _)
            {
                this.Code = default;
                this.Jt = default;
                this.Jf = default;
                this.K = default;
            }

            public SockFilter(ushort Code = default, byte Jt = default, byte Jf = default, uint K = default)
            {
                this.Code = Code;
                this.Jt = Jt;
                this.Jf = Jf;
                this.K = K;
            }

            // Enable comparisons between nil and SockFilter struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SockFilter value, NilType nil) => value.Equals(default(SockFilter));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SockFilter value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SockFilter value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SockFilter value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SockFilter(NilType nil) => default(SockFilter);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SockFilter SockFilter_cast(dynamic value)
        {
            return new SockFilter(value.Code, value.Jt, value.Jf, value.K);
        }
    }
}}}}}}