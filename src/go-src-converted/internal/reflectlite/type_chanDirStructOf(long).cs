//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace @internal
{
    public static partial class reflectlite_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct chanDir
        {
            // Value of the chanDir struct
            private readonly long m_value;

            public chanDir(long value) => m_value = value;

            // Enable implicit conversions between long and chanDir struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator chanDir(long value) => new chanDir(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(chanDir value) => value.m_value;
            
            // Enable comparisons between nil and chanDir struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(chanDir value, NilType nil) => value.Equals(default(chanDir));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(chanDir value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, chanDir value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, chanDir value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator chanDir(NilType nil) => default(chanDir);
        }
    }
}}
