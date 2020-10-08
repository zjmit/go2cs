//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:02:15 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace @internal
{
    public static partial class xcoff_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct SectionHeader64
        {
            // Constructors
            public SectionHeader64(NilType _)
            {
                this.Sname = default;
                this.Spaddr = default;
                this.Svaddr = default;
                this.Ssize = default;
                this.Sscnptr = default;
                this.Srelptr = default;
                this.Slnnoptr = default;
                this.Snreloc = default;
                this.Snlnno = default;
                this.Sflags = default;
                this.Spad = default;
            }

            public SectionHeader64(array<byte> Sname = default, ulong Spaddr = default, ulong Svaddr = default, ulong Ssize = default, ulong Sscnptr = default, ulong Srelptr = default, ulong Slnnoptr = default, uint Snreloc = default, uint Snlnno = default, uint Sflags = default, uint Spad = default)
            {
                this.Sname = Sname;
                this.Spaddr = Spaddr;
                this.Svaddr = Svaddr;
                this.Ssize = Ssize;
                this.Sscnptr = Sscnptr;
                this.Srelptr = Srelptr;
                this.Slnnoptr = Slnnoptr;
                this.Snreloc = Snreloc;
                this.Snlnno = Snlnno;
                this.Sflags = Sflags;
                this.Spad = Spad;
            }

            // Enable comparisons between nil and SectionHeader64 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(SectionHeader64 value, NilType nil) => value.Equals(default(SectionHeader64));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(SectionHeader64 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, SectionHeader64 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, SectionHeader64 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator SectionHeader64(NilType nil) => default(SectionHeader64);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static SectionHeader64 SectionHeader64_cast(dynamic value)
        {
            return new SectionHeader64(value.Sname, value.Spaddr, value.Svaddr, value.Ssize, value.Sscnptr, value.Srelptr, value.Slnnoptr, value.Snreloc, value.Snlnno, value.Sflags, value.Spad);
        }
    }
}}