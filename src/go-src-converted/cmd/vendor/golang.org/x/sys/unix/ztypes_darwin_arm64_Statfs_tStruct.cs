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
        public partial struct Statfs_t
        {
            // Constructors
            public Statfs_t(NilType _)
            {
                this.Bsize = default;
                this.Iosize = default;
                this.Blocks = default;
                this.Bfree = default;
                this.Bavail = default;
                this.Files = default;
                this.Ffree = default;
                this.Fsid = default;
                this.Owner = default;
                this.Type = default;
                this.Flags = default;
                this.Fssubtype = default;
                this.Fstypename = default;
                this.Mntonname = default;
                this.Mntfromname = default;
                this.Reserved = default;
            }

            public Statfs_t(uint Bsize = default, int Iosize = default, ulong Blocks = default, ulong Bfree = default, ulong Bavail = default, ulong Files = default, ulong Ffree = default, Fsid Fsid = default, uint Owner = default, uint Type = default, uint Flags = default, uint Fssubtype = default, array<sbyte> Fstypename = default, array<sbyte> Mntonname = default, array<sbyte> Mntfromname = default, array<uint> Reserved = default)
            {
                this.Bsize = Bsize;
                this.Iosize = Iosize;
                this.Blocks = Blocks;
                this.Bfree = Bfree;
                this.Bavail = Bavail;
                this.Files = Files;
                this.Ffree = Ffree;
                this.Fsid = Fsid;
                this.Owner = Owner;
                this.Type = Type;
                this.Flags = Flags;
                this.Fssubtype = Fssubtype;
                this.Fstypename = Fstypename;
                this.Mntonname = Mntonname;
                this.Mntfromname = Mntfromname;
                this.Reserved = Reserved;
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
            return new Statfs_t(value.Bsize, value.Iosize, value.Blocks, value.Bfree, value.Bavail, value.Files, value.Ffree, value.Fsid, value.Owner, value.Type, value.Flags, value.Fssubtype, value.Fstypename, value.Mntonname, value.Mntfromname, value.Reserved);
        }
    }
}}}}}}