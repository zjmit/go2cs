//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 August 29 10:05:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gState
        {
            // Value of the gState struct
            private readonly long m_value;

            public gState(long value) => m_value = value;

            // Enable implicit conversions between long and gState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gState(long value) => new gState(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(gState value) => value.m_value;
            
            // Enable comparisons between nil and gState struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gState value, NilType nil) => value.Equals(default(gState));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gState value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gState value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gState value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gState(NilType nil) => default(gState);
        }
    }
}