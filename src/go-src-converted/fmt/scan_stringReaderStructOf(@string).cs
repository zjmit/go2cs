//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:26:08 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class fmt_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct stringReader
        {
            // Value of the stringReader struct
            private readonly @string m_value;

            public stringReader(@string value) => m_value = value;

            // Enable implicit conversions between @string and stringReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringReader(@string value) => new stringReader(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(stringReader value) => value.m_value;
            
            // Enable comparisons between nil and stringReader struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(stringReader value, NilType nil) => value.Equals(default(stringReader));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(stringReader value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, stringReader value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, stringReader value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator stringReader(NilType nil) => default(stringReader);
        }
    }
}
