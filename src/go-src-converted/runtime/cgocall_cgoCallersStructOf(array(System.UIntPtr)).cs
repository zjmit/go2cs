//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:06 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct cgoCallers
        {
            // Value of the cgoCallers struct
            private readonly array<System.UIntPtr> m_value;

            public cgoCallers(array<System.UIntPtr> value) => m_value = value;

            // Enable implicit conversions between array<System.UIntPtr> and cgoCallers struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cgoCallers(array<System.UIntPtr> value) => new cgoCallers(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator array<System.UIntPtr>(cgoCallers value) => value.m_value;
            
            // Enable comparisons between nil and cgoCallers struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(cgoCallers value, NilType nil) => value.Equals(default(cgoCallers));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(cgoCallers value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, cgoCallers value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, cgoCallers value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator cgoCallers(NilType nil) => default(cgoCallers);
        }
    }
}
