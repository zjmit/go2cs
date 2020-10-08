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
        public partial struct EpollEvent
        {
            // Constructors
            public EpollEvent(NilType _)
            {
                this.Events = default;
                this.X_padFd = default;
                this.Fd = default;
                this.Pad = default;
            }

            public EpollEvent(uint Events = default, int X_padFd = default, int Fd = default, int Pad = default)
            {
                this.Events = Events;
                this.X_padFd = X_padFd;
                this.Fd = Fd;
                this.Pad = Pad;
            }

            // Enable comparisons between nil and EpollEvent struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(EpollEvent value, NilType nil) => value.Equals(default(EpollEvent));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(EpollEvent value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, EpollEvent value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, EpollEvent value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator EpollEvent(NilType nil) => default(EpollEvent);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static EpollEvent EpollEvent_cast(dynamic value)
        {
            return new EpollEvent(value.Events, value.X_padFd, value.Fd, value.Pad);
        }
    }
}