//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:39:55 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct nflag
        {
            // Value of the nflag struct
            private readonly long m_value;

            public nflag(long value) => m_value = value;

            // Enable implicit conversions between long and nflag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nflag(long value) => new nflag(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(nflag value) => value.m_value;
            
            // Enable comparisons between nil and nflag struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(nflag value, NilType nil) => value.Equals(default(nflag));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(nflag value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, nflag value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, nflag value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator nflag(NilType nil) => default(nflag);
        }
    }
}
