//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:28 UTC
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
                this._0 = default;
                this.Uid = default;
                this.Gid = default;
                this._1 = default;
                this.Rdev = default;
                this._ = default;
                this.Atim = default;
                this._ = default;
                this.Mtim = default;
                this._ = default;
                this.Ctim = default;
                this._ = default;
                this.Btim = default;
                this.Size = default;
                this.Blocks = default;
                this.Blksize = default;
                this.Flags = default;
                this.Gen = default;
                this.Spare = default;
            }

            public Stat_t(ulong Dev = default, ulong Ino = default, ulong Nlink = default, ushort Mode = default, short _0 = default, uint Uid = default, uint Gid = default, int _1 = default, ulong Rdev = default, int _ = default, Timespec Atim = default, int _ = default, Timespec Mtim = default, int _ = default, Timespec Ctim = default, int _ = default, Timespec Btim = default, long Size = default, long Blocks = default, int Blksize = default, uint Flags = default, ulong Gen = default, array<ulong> Spare = default)
            {
                this.Dev = Dev;
                this.Ino = Ino;
                this.Nlink = Nlink;
                this.Mode = Mode;
                this._0 = _0;
                this.Uid = Uid;
                this.Gid = Gid;
                this._1 = _1;
                this.Rdev = Rdev;
                this._ = _;
                this.Atim = Atim;
                this._ = _;
                this.Mtim = Mtim;
                this._ = _;
                this.Ctim = Ctim;
                this._ = _;
                this.Btim = Btim;
                this.Size = Size;
                this.Blocks = Blocks;
                this.Blksize = Blksize;
                this.Flags = Flags;
                this.Gen = Gen;
                this.Spare = Spare;
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
            return new Stat_t(value.Dev, value.Ino, value.Nlink, value.Mode, value._0, value.Uid, value.Gid, value._1, value.Rdev, value._, value.Atim, value._, value.Mtim, value._, value.Ctim, value._, value.Btim, value.Size, value.Blocks, value.Blksize, value.Flags, value.Gen, value.Spare);
        }
    }
}}}}}}