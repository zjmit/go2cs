//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:38 UTC
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
        public partial struct NlMsghdr
        {
            // Constructors
            public NlMsghdr(NilType _)
            {
                this.Len = default;
                this.Type = default;
                this.Flags = default;
                this.Seq = default;
                this.Pid = default;
            }

            public NlMsghdr(uint Len = default, ushort Type = default, ushort Flags = default, uint Seq = default, uint Pid = default)
            {
                this.Len = Len;
                this.Type = Type;
                this.Flags = Flags;
                this.Seq = Seq;
                this.Pid = Pid;
            }

            // Enable comparisons between nil and NlMsghdr struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NlMsghdr value, NilType nil) => value.Equals(default(NlMsghdr));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NlMsghdr value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, NlMsghdr value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, NlMsghdr value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator NlMsghdr(NilType nil) => default(NlMsghdr);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static NlMsghdr NlMsghdr_cast(dynamic value)
        {
            return new NlMsghdr(value.Len, value.Type, value.Flags, value.Seq, value.Pid);
        }
    }
}