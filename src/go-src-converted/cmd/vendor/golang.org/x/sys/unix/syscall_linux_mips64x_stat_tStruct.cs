//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:47:38 UTC
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
        private partial struct stat_t
        {
            // Constructors
            public stat_t(NilType _)
            {
                this.Dev = default;
                this.Pad0 = default;
                this.Ino = default;
                this.Mode = default;
                this.Nlink = default;
                this.Uid = default;
                this.Gid = default;
                this.Rdev = default;
                this.Pad1 = default;
                this.Size = default;
                this.Atime = default;
                this.Atime_nsec = default;
                this.Mtime = default;
                this.Mtime_nsec = default;
                this.Ctime = default;
                this.Ctime_nsec = default;
                this.Blksize = default;
                this.Pad2 = default;
                this.Blocks = default;
            }

            public stat_t(uint Dev = default, array<int> Pad0 = default, ulong Ino = default, uint Mode = default, uint Nlink = default, uint Uid = default, uint Gid = default, uint Rdev = default, array<uint> Pad1 = default, long Size = default, uint Atime = default, uint Atime_nsec = default, uint Mtime = default, uint Mtime_nsec = default, uint Ctime = default, uint Ctime_nsec = default, uint Blksize = default, uint Pad2 = default, long Blocks = default)
            {
                this.Dev = Dev;
                this.Pad0 = Pad0;
                this.Ino = Ino;
                this.Mode = Mode;
                this.Nlink = Nlink;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Rdev = Rdev;
                this.Pad1 = Pad1;
                this.Size = Size;
                this.Atime = Atime;
                this.Atime_nsec = Atime_nsec;
                this.Mtime = Mtime;
                this.Mtime_nsec = Mtime_nsec;
                this.Ctime = Ctime;
                this.Ctime_nsec = Ctime_nsec;
                this.Blksize = Blksize;
                this.Pad2 = Pad2;
                this.Blocks = Blocks;
            }

            // Enable comparisons between nil and stat_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stat_t value, NilType nil) => value.Equals(default(stat_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stat_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stat_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stat_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stat_t(NilType nil) => default(stat_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static stat_t stat_t_cast(dynamic value)
        {
            return new stat_t(value.Dev, value.Pad0, value.Ino, value.Mode, value.Nlink, value.Uid, value.Gid, value.Rdev, value.Pad1, value.Size, value.Atime, value.Atime_nsec, value.Mtime, value.Mtime_nsec, value.Ctime, value.Ctime_nsec, value.Blksize, value.Pad2, value.Blocks);
        }
    }
}}}}}}