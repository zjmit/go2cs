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
        public partial struct RtGenmsg
        {
            // Constructors
            public RtGenmsg(NilType _)
            {
                this.Family = default;
            }

            public RtGenmsg(byte Family = default)
            {
                this.Family = Family;
            }

            // Enable comparisons between nil and RtGenmsg struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RtGenmsg value, NilType nil) => value.Equals(default(RtGenmsg));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RtGenmsg value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RtGenmsg value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RtGenmsg value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RtGenmsg(NilType nil) => default(RtGenmsg);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static RtGenmsg RtGenmsg_cast(dynamic value)
        {
            return new RtGenmsg(value.Family);
        }
    }
}