//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:42:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace @internal
{
    public static partial class trace_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct gStatus
        {
            // Value of the gStatus struct
            private readonly long m_value;

            public gStatus(long value) => m_value = value;

            // Enable implicit conversions between long and gStatus struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gStatus(long value) => new gStatus(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(gStatus value) => value.m_value;
            
            // Enable comparisons between nil and gStatus struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(gStatus value, NilType nil) => value.Equals(default(gStatus));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(gStatus value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, gStatus value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, gStatus value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator gStatus(NilType nil) => default(gStatus);
        }
    }
}}
