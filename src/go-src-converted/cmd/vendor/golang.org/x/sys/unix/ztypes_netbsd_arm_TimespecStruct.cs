//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:39 UTC
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
        public partial struct Timespec
        {
            // Constructors
            public Timespec(NilType _)
            {
                this.Sec = default;
                this.Nsec = default;
                this.Pad_cgo_0 = default;
            }

            public Timespec(long Sec = default, int Nsec = default, array<byte> Pad_cgo_0 = default)
            {
                this.Sec = Sec;
                this.Nsec = Nsec;
                this.Pad_cgo_0 = Pad_cgo_0;
            }

            // Enable comparisons between nil and Timespec struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Timespec value, NilType nil) => value.Equals(default(Timespec));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Timespec value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Timespec value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Timespec value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Timespec(NilType nil) => default(Timespec);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Timespec Timespec_cast(dynamic value)
        {
            return new Timespec(value.Sec, value.Nsec, value.Pad_cgo_0);
        }
    }
}}}}}}