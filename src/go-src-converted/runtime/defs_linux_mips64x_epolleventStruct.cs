//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct epollevent
        {
            // Constructors
            public epollevent(NilType _)
            {
                this.events = default;
                this.pad_cgo_0 = default;
                this.data = default;
            }

            public epollevent(uint events = default, array<byte> pad_cgo_0 = default, array<byte> data = default)
            {
                this.events = events;
                this.pad_cgo_0 = pad_cgo_0;
                this.data = data;
            }

            // Enable comparisons between nil and epollevent struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(epollevent value, NilType nil) => value.Equals(default(epollevent));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(epollevent value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, epollevent value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, epollevent value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator epollevent(NilType nil) => default(epollevent);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static epollevent epollevent_cast(dynamic value)
        {
            return new epollevent(value.events, value.pad_cgo_0, value.data);
        }
    }
}