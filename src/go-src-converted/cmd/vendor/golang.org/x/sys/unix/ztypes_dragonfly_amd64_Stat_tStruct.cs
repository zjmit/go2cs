//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:27 UTC
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
                this.Ino = default;
                this.Nlink = default;
                this.Dev = default;
                this.Mode = default;
                this._1 = default;
                this.Uid = default;
                this.Gid = default;
                this.Rdev = default;
                this.Atim = default;
                this.Mtim = default;
                this.Ctim = default;
                this.Size = default;
                this.Blocks = default;
                this.Blksize = default;
                this.Flags = default;
                this.Gen = default;
                this.Lspare = default;
                this.Qspare1 = default;
                this.Qspare2 = default;
            }

            public Stat_t(ulong Ino = default, uint Nlink = default, uint Dev = default, ushort Mode = default, ushort _1 = default, uint Uid = default, uint Gid = default, uint Rdev = default, Timespec Atim = default, Timespec Mtim = default, Timespec Ctim = default, long Size = default, long Blocks = default, uint Blksize = default, uint Flags = default, uint Gen = default, int Lspare = default, long Qspare1 = default, long Qspare2 = default)
            {
                this.Ino = Ino;
                this.Nlink = Nlink;
                this.Dev = Dev;
                this.Mode = Mode;
                this._1 = _1;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Rdev = Rdev;
                this.Atim = Atim;
                this.Mtim = Mtim;
                this.Ctim = Ctim;
                this.Size = Size;
                this.Blocks = Blocks;
                this.Blksize = Blksize;
                this.Flags = Flags;
                this.Gen = Gen;
                this.Lspare = Lspare;
                this.Qspare1 = Qspare1;
                this.Qspare2 = Qspare2;
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
            return new Stat_t(value.Ino, value.Nlink, value.Dev, value.Mode, value._1, value.Uid, value.Gid, value.Rdev, value.Atim, value.Mtim, value.Ctim, value.Size, value.Blocks, value.Blksize, value.Flags, value.Gen, value.Lspare, value.Qspare1, value.Qspare2);
        }
    }
}}}}}}