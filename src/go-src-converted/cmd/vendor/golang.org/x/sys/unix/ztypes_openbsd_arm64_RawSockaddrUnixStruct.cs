//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:41 UTC
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
        public partial struct RawSockaddrUnix
        {
            // Constructors
            public RawSockaddrUnix(NilType _)
            {
                this.Len = default;
                this.Family = default;
                this.Path = default;
            }

            public RawSockaddrUnix(byte Len = default, byte Family = default, array<sbyte> Path = default)
            {
                this.Len = Len;
                this.Family = Family;
                this.Path = Path;
            }

            // Enable comparisons between nil and RawSockaddrUnix struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RawSockaddrUnix value, NilType nil) => value.Equals(default(RawSockaddrUnix));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RawSockaddrUnix value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RawSockaddrUnix value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RawSockaddrUnix value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RawSockaddrUnix(NilType nil) => default(RawSockaddrUnix);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RawSockaddrUnix RawSockaddrUnix_cast(dynamic value)
        {
            return new RawSockaddrUnix(value.Len, value.Family, value.Path);
        }
    }
}}}}}}