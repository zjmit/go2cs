//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 09 04:46:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

#nullable enable

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct lockRank
        {
            // Value of the lockRank struct
            private readonly long m_value;

            public lockRank(long value) => m_value = value;

            // Enable implicit conversions between long and lockRank struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lockRank(long value) => new lockRank(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(lockRank value) => value.m_value;
            
            // Enable comparisons between nil and lockRank struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lockRank value, NilType nil) => value.Equals(default(lockRank));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lockRank value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lockRank value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lockRank value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lockRank(NilType nil) => default(lockRank);
        }
    }
}