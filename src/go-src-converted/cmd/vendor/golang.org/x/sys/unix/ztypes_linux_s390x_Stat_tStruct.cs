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
        public partial struct Stat_t
        {
            // Constructors
            public Stat_t(NilType _)
            {
                this.Dev = default;
                this.Ino = default;
                this.Nlink = default;
                this.Mode = default;
                this.Uid = default;
                this.Gid = default;
                this._ = default;
                this.Rdev = default;
                this.Size = default;
                this.Atim = default;
                this.Mtim = default;
                this.Ctim = default;
                this.Blksize = default;
                this.Blocks = default;
                this._ = default;
            }

            public Stat_t(ulong Dev = default, ulong Ino = default, ulong Nlink = default, uint Mode = default, uint Uid = default, uint Gid = default, int _ = default, ulong Rdev = default, long Size = default, Timespec Atim = default, Timespec Mtim = default, Timespec Ctim = default, long Blksize = default, long Blocks = default, array<long> _ = default)
            {
                this.Dev = Dev;
                this.Ino = Ino;
                this.Nlink = Nlink;
                this.Mode = Mode;
                this.Uid = Uid;
                this.Gid = Gid;
                this._ = _;
                this.Rdev = Rdev;
                this.Size = Size;
                this.Atim = Atim;
                this.Mtim = Mtim;
                this.Ctim = Ctim;
                this.Blksize = Blksize;
                this.Blocks = Blocks;
                this._ = _;
            }

            // Enable comparisons between nil and Stat_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Stat_t value, NilType nil) => value.Equals(default(Stat_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Stat_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Stat_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Stat_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Stat_t(NilType nil) => default(Stat_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Stat_t Stat_t_cast(dynamic value)
        {
            return new Stat_t(value.Dev, value.Ino, value.Nlink, value.Mode, value.Uid, value.Gid, value._, value.Rdev, value.Size, value.Atim, value.Mtim, value.Ctim, value.Blksize, value.Blocks, value._);
        }
    }
}}}}}}