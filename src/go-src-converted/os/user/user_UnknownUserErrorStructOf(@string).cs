//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:45:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace os
{
    public static partial class user_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct UnknownUserError
        {
            // Value of the UnknownUserError struct
            private readonly @string m_value;

            public UnknownUserError(@string value) => m_value = value;

            // Enable implicit conversions between @string and UnknownUserError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnknownUserError(@string value) => new UnknownUserError(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator @string(UnknownUserError value) => value.m_value;
            
            // Enable comparisons between nil and UnknownUserError struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(UnknownUserError value, NilType nil) => value.Equals(default(UnknownUserError));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(UnknownUserError value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, UnknownUserError value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, UnknownUserError value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator UnknownUserError(NilType nil) => default(UnknownUserError);
        }
    }
}}
