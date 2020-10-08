//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:31:19 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using nettrace = go.@internal.nettrace_package;
using syscall = go.syscall_package;
using time = go.time_package;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct ListenConfig
        {
            // Constructors
            public ListenConfig(NilType _)
            {
                this.Control = default;
                this.KeepAlive = default;
            }

            public ListenConfig(Func<@string, @string, syscall.RawConn, error> Control = default, time.Duration KeepAlive = default)
            {
                this.Control = Control;
                this.KeepAlive = KeepAlive;
            }

            // Enable comparisons between nil and ListenConfig struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(ListenConfig value, NilType nil) => value.Equals(default(ListenConfig));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(ListenConfig value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, ListenConfig value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, ListenConfig value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator ListenConfig(NilType nil) => default(ListenConfig);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static ListenConfig ListenConfig_cast(dynamic value)
        {
            return new ListenConfig(value.Control, value.KeepAlive);
        }
    }
}