//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:33:46 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class net_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct addrList
        {
            // Value of the addrList struct
            private readonly slice<Addr> m_value;

            public addrList(slice<Addr> value) => m_value = value;

            // Enable implicit conversions between slice<Addr> and addrList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator addrList(slice<Addr> value) => new addrList(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator slice<Addr>(addrList value) => value.m_value;
            
            // Enable comparisons between nil and addrList struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(addrList value, NilType nil) => value.Equals(default(addrList));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(addrList value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, addrList value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, addrList value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator addrList(NilType nil) => default(addrList);
        }
    }
}
