//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:27:49 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Signal
        {
            // Value of the Signal struct
            private readonly long m_value;

            public Signal(long value) => m_value = value;

            // Enable implicit conversions between long and Signal struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Signal(long value) => new Signal(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(Signal value) => value.m_value;
            
            // Enable comparisons between nil and Signal struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Signal value, NilType nil) => value.Equals(default(Signal));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Signal value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Signal value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Signal value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Signal(NilType nil) => default(Signal);
        }
    }
}
