//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:37 UTC
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
        private partial struct pollFd
        {
            // Constructors
            public pollFd(NilType _)
            {
                this.Fd = default;
                this.Events = default;
                this.Revents = default;
            }

            public pollFd(int Fd = default, short Events = default, short Revents = default)
            {
                this.Fd = Fd;
                this.Events = Events;
                this.Revents = Revents;
            }

            // Enable comparisons between nil and pollFd struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(pollFd value, NilType nil) => value.Equals(default(pollFd));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(pollFd value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, pollFd value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, pollFd value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator pollFd(NilType nil) => default(pollFd);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static pollFd pollFd_cast(dynamic value)
        {
            return new pollFd(value.Fd, value.Events, value.Revents);
        }
    }
}