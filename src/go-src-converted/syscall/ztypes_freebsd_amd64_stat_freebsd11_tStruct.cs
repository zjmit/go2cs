//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:33 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct stat_freebsd11_t
        {
            // Constructors
            public stat_freebsd11_t(NilType _)
            {
                this.Dev = default;
                this.Ino = default;
                this.Mode = default;
                this.Nlink = default;
                this.Uid = default;
                this.Gid = default;
                this.Rdev = default;
                this.Atimespec = default;
                this.Mtimespec = default;
                this.Ctimespec = default;
                this.Size = default;
                this.Blocks = default;
                this.Blksize = default;
                this.Flags = default;
                this.Gen = default;
                this.Lspare = default;
                this.Birthtimespec = default;
            }

            public stat_freebsd11_t(uint Dev = default, uint Ino = default, ushort Mode = default, ushort Nlink = default, uint Uid = default, uint Gid = default, uint Rdev = default, Timespec Atimespec = default, Timespec Mtimespec = default, Timespec Ctimespec = default, long Size = default, long Blocks = default, int Blksize = default, uint Flags = default, uint Gen = default, int Lspare = default, Timespec Birthtimespec = default)
            {
                this.Dev = Dev;
                this.Ino = Ino;
                this.Mode = Mode;
                this.Nlink = Nlink;
                this.Uid = Uid;
                this.Gid = Gid;
                this.Rdev = Rdev;
                this.Atimespec = Atimespec;
                this.Mtimespec = Mtimespec;
                this.Ctimespec = Ctimespec;
                this.Size = Size;
                this.Blocks = Blocks;
                this.Blksize = Blksize;
                this.Flags = Flags;
                this.Gen = Gen;
                this.Lspare = Lspare;
                this.Birthtimespec = Birthtimespec;
            }

            // Enable comparisons between nil and stat_freebsd11_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stat_freebsd11_t value, NilType nil) => value.Equals(default(stat_freebsd11_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stat_freebsd11_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stat_freebsd11_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stat_freebsd11_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stat_freebsd11_t(NilType nil) => default(stat_freebsd11_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static stat_freebsd11_t stat_freebsd11_t_cast(dynamic value)
        {
            return new stat_freebsd11_t(value.Dev, value.Ino, value.Mode, value.Nlink, value.Uid, value.Gid, value.Rdev, value.Atimespec, value.Mtimespec, value.Ctimespec, value.Size, value.Blocks, value.Blksize, value.Flags, value.Gen, value.Lspare, value.Birthtimespec);
        }
    }
}