//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:29 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct sigset
        {
            // Value of the sigset struct
            private readonly array<ulong> m_value;

            public sigset(array<ulong> value) => m_value = value;

            // Enable implicit conversions between array<ulong> and sigset struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sigset(array<ulong> value) => new sigset(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<ulong>(sigset value) => value.m_value;
            
            // Enable comparisons between nil and sigset struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(sigset value, NilType nil) => value.Equals(default(sigset));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(sigset value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, sigset value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, sigset value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator sigset(NilType nil) => default(sigset);
        }
    }
}
