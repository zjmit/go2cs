//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:30:32 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class syscall_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct _C_short
        {
            // Value of the _C_short struct
            private readonly short m_value;

            public _C_short(short value) => m_value = value;

            // Enable implicit conversions between short and _C_short struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _C_short(short value) => new _C_short(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator short(_C_short value) => value.m_value;
            
            // Enable comparisons between nil and _C_short struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(_C_short value, NilType nil) => value.Equals(default(_C_short));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(_C_short value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, _C_short value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, _C_short value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator _C_short(NilType nil) => default(_C_short);
        }
    }
}
