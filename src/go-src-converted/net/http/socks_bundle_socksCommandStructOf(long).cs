//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:40:35 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace net
{
    public static partial class http_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct socksCommand
        {
            // Value of the socksCommand struct
            private readonly long m_value;

            public socksCommand(long value) => m_value = value;

            // Enable implicit conversions between long and socksCommand struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator socksCommand(long value) => new socksCommand(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(socksCommand value) => value.m_value;
            
            // Enable comparisons between nil and socksCommand struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(socksCommand value, NilType nil) => value.Equals(default(socksCommand));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(socksCommand value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, socksCommand value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, socksCommand value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator socksCommand(NilType nil) => default(socksCommand);
        }
    }
}}
