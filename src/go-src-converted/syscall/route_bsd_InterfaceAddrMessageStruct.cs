//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:26:52 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using runtime = go.runtime_package;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct InterfaceAddrMessage
        {
            // Constructors
            public InterfaceAddrMessage(NilType _)
            {
                this.Header = default;
                this.Data = default;
            }

            public InterfaceAddrMessage(IfaMsghdr Header = default, slice<byte> Data = default)
            {
                this.Header = Header;
                this.Data = Data;
            }

            // Enable comparisons between nil and InterfaceAddrMessage struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(InterfaceAddrMessage value, NilType nil) => value.Equals(default(InterfaceAddrMessage));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(InterfaceAddrMessage value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, InterfaceAddrMessage value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, InterfaceAddrMessage value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator InterfaceAddrMessage(NilType nil) => default(InterfaceAddrMessage);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static InterfaceAddrMessage InterfaceAddrMessage_cast(dynamic value)
        {
            return new InterfaceAddrMessage(value.Header, value.Data);
        }
    }
}