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
        public partial struct Statfs_t
        {
            // Constructors
            public Statfs_t(NilType _)
            {
                this.Type = default;
                this.Bsize = default;
                this.Blocks = default;
                this.Bfree = default;
                this.Bavail = default;
                this.Files = default;
                this.Ffree = default;
                this.Fsid = default;
                this.Namelen = default;
                this.Frsize = default;
                this.Flags = default;
                this.Spare = default;
                this._ = default;
            }

            public Statfs_t(uint Type = default, uint Bsize = default, ulong Blocks = default, ulong Bfree = default, ulong Bavail = default, ulong Files = default, ulong Ffree = default, Fsid Fsid = default, uint Namelen = default, uint Frsize = default, uint Flags = default, array<uint> Spare = default, array<byte> _ = default)
            {
                this.Type = Type;
                this.Bsize = Bsize;
                this.Blocks = Blocks;
                this.Bfree = Bfree;
                this.Bavail = Bavail;
                this.Files = Files;
                this.Ffree = Ffree;
                this.Fsid = Fsid;
                this.Namelen = Namelen;
                this.Frsize = Frsize;
                this.Flags = Flags;
                this.Spare = Spare;
                this._ = _;
            }

            // Enable comparisons between nil and Statfs_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Statfs_t value, NilType nil) => value.Equals(default(Statfs_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Statfs_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Statfs_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Statfs_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Statfs_t(NilType nil) => default(Statfs_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Statfs_t Statfs_t_cast(dynamic value)
        {
            return new Statfs_t(value.Type, value.Bsize, value.Blocks, value.Bfree, value.Bavail, value.Files, value.Ffree, value.Fsid, value.Namelen, value.Frsize, value.Flags, value.Spare, value._);
        }
    }
}}}}}}