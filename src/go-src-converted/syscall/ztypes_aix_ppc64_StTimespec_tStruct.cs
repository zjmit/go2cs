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
        public partial struct StTimespec_t
        {
            // Constructors
            public StTimespec_t(NilType _)
            {
                this.Sec = default;
                this.Nsec = default;
                this.Pad_cgo_0 = default;
            }

            public StTimespec_t(long Sec = default, int Nsec = default, array<byte> Pad_cgo_0 = default)
            {
                this.Sec = Sec;
                this.Nsec = Nsec;
                this.Pad_cgo_0 = Pad_cgo_0;
            }

            // Enable comparisons between nil and StTimespec_t struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(StTimespec_t value, NilType nil) => value.Equals(default(StTimespec_t));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(StTimespec_t value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, StTimespec_t value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, StTimespec_t value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator StTimespec_t(NilType nil) => default(StTimespec_t);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static StTimespec_t StTimespec_t_cast(dynamic value)
        {
            return new StTimespec_t(value.Sec, value.Nsec, value.Pad_cgo_0);
        }
    }
}