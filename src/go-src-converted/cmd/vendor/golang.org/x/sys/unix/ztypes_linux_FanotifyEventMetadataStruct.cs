//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:32 UTC
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
        public partial struct FanotifyEventMetadata
        {
            // Constructors
            public FanotifyEventMetadata(NilType _)
            {
                this.Event_len = default;
                this.Vers = default;
                this.Reserved = default;
                this.Metadata_len = default;
                this.Mask = default;
                this.Fd = default;
                this.Pid = default;
            }

            public FanotifyEventMetadata(uint Event_len = default, byte Vers = default, byte Reserved = default, ushort Metadata_len = default, ulong Mask = default, int Fd = default, int Pid = default)
            {
                this.Event_len = Event_len;
                this.Vers = Vers;
                this.Reserved = Reserved;
                this.Metadata_len = Metadata_len;
                this.Mask = Mask;
                this.Fd = Fd;
                this.Pid = Pid;
            }

            // Enable comparisons between nil and FanotifyEventMetadata struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(FanotifyEventMetadata value, NilType nil) => value.Equals(default(FanotifyEventMetadata));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(FanotifyEventMetadata value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, FanotifyEventMetadata value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, FanotifyEventMetadata value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator FanotifyEventMetadata(NilType nil) => default(FanotifyEventMetadata);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static FanotifyEventMetadata FanotifyEventMetadata_cast(dynamic value)
        {
            return new FanotifyEventMetadata(value.Event_len, value.Vers, value.Reserved, value.Metadata_len, value.Mask, value.Fd, value.Pid);
        }
    }
}}}}}}