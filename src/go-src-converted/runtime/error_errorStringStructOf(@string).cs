//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct errorString
        {
            // Value of the errorString struct
            private readonly @string m_value;

            public errorString(@string value) => m_value = value;

            // Enable implicit conversions between @string and errorString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errorString(@string value) => new errorString(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(errorString value) => value.m_value;
            
            // Enable comparisons between nil and errorString struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(errorString value, NilType nil) => value.Equals(default(errorString));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(errorString value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, errorString value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, errorString value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator errorString(NilType nil) => default(errorString);
        }
    }
}
