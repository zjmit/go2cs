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
        public partial struct LoopInfo
        {
            // Constructors
            public LoopInfo(NilType _)
            {
                this.Number = default;
                this.Device = default;
                this.Inode = default;
                this.Rdevice = default;
                this.Offset = default;
                this.Encrypt_type = default;
                this.Encrypt_key_size = default;
                this.Flags = default;
                this.Name = default;
                this.Encrypt_key = default;
                this.Init = default;
                this.Reserved = default;
            }

            public LoopInfo(int Number = default, uint Device = default, uint Inode = default, uint Rdevice = default, int Offset = default, int Encrypt_type = default, int Encrypt_key_size = default, int Flags = default, array<sbyte> Name = default, array<byte> Encrypt_key = default, array<uint> Init = default, array<sbyte> Reserved = default)
            {
                this.Number = Number;
                this.Device = Device;
                this.Inode = Inode;
                this.Rdevice = Rdevice;
                this.Offset = Offset;
                this.Encrypt_type = Encrypt_type;
                this.Encrypt_key_size = Encrypt_key_size;
                this.Flags = Flags;
                this.Name = Name;
                this.Encrypt_key = Encrypt_key;
                this.Init = Init;
                this.Reserved = Reserved;
            }

            // Enable comparisons between nil and LoopInfo struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(LoopInfo value, NilType nil) => value.Equals(default(LoopInfo));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(LoopInfo value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, LoopInfo value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, LoopInfo value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator LoopInfo(NilType nil) => default(LoopInfo);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static LoopInfo LoopInfo_cast(dynamic value)
        {
            return new LoopInfo(value.Number, value.Device, value.Inode, value.Rdevice, value.Offset, value.Encrypt_type, value.Encrypt_key_size, value.Flags, value.Name, value.Encrypt_key, value.Init, value.Reserved);
        }
    }
}}}}}}