//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 06:00:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

#nullable enable

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
        public partial struct Cmsghdr
        {
            // Constructors
            public Cmsghdr(NilType _)
            {
                this.Len = default;
                this.Level = default;
                this.Type = default;
            }

            public Cmsghdr(uint Len = default, int Level = default, int Type = default)
            {
                this.Len = Len;
                this.Level = Level;
                this.Type = Type;
            }

            // Enable comparisons between nil and Cmsghdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Cmsghdr value, NilType nil) => value.Equals(default(Cmsghdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Cmsghdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Cmsghdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Cmsghdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Cmsghdr(NilType nil) => default(Cmsghdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Cmsghdr Cmsghdr_cast(dynamic value)
        {
            return new Cmsghdr(value.Len, value.Level, value.Type);
        }
    }
}}}}}}