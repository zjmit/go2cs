//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:32 UTC
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
        public partial struct BpfStat
        {
            // Constructors
            public BpfStat(NilType _)
            {
                this.Recv = default;
                this.Drop = default;
            }

            public BpfStat(uint Recv = default, uint Drop = default)
            {
                this.Recv = Recv;
                this.Drop = Drop;
            }

            // Enable comparisons between nil and BpfStat struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BpfStat value, NilType nil) => value.Equals(default(BpfStat));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BpfStat value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BpfStat value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BpfStat value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BpfStat(NilType nil) => default(BpfStat);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static BpfStat BpfStat_cast(dynamic value)
        {
            return new BpfStat(value.Recv, value.Drop);
        }
    }
}