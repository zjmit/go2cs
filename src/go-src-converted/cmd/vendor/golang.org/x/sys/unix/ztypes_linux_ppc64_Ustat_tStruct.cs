//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:36 UTC
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
        public partial struct Ustat_t
        {
            // Constructors
            public Ustat_t(NilType _)
            {
                this.Tfree = default;
                this.Tinode = default;
                this.Fname = default;
                this.Fpack = default;
                this._ = default;
            }

            public Ustat_t(int Tfree = default, ulong Tinode = default, array<byte> Fname = default, array<byte> Fpack = default, array<byte> _ = default)
            {
                this.Tfree = Tfree;
                this.Tinode = Tinode;
                this.Fname = Fname;
                this.Fpack = Fpack;
                this._ = _;
            }

            // Enable comparisons between nil and Ustat_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Ustat_t value, NilType nil) => value.Equals(default(Ustat_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Ustat_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Ustat_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Ustat_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Ustat_t(NilType nil) => default(Ustat_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Ustat_t Ustat_t_cast(dynamic value)
        {
            return new Ustat_t(value.Tfree, value.Tinode, value.Fname, value.Fpack, value._);
        }
    }
}}}}}}