//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:45:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using errors = go.errors_package;
using sync = go.sync_package;
using syscall = go.syscall_package;

namespace go
{
    public static partial class time_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct zone
        {
            // Constructors
            public zone(NilType _)
            {
                this.name = default;
                this.offset = default;
                this.isDST = default;
            }

            public zone(@string name = default, long offset = default, bool isDST = default)
            {
                this.name = name;
                this.offset = offset;
                this.isDST = isDST;
            }

            // Enable comparisons between nil and zone struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(zone value, NilType nil) => value.Equals(default(zone));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(zone value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, zone value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, zone value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator zone(NilType nil) => default(zone);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static zone zone_cast(dynamic value)
        {
            return new zone(value.name, value.offset, value.isDST);
        }
    }
}