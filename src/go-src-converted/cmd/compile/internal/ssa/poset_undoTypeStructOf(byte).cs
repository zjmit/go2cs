//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:11:28 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace compile {
namespace @internal
{
    public static partial class ssa_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct undoType
        {
            // Value of the undoType struct
            private readonly byte m_value;

            public undoType(byte value) => m_value = value;

            // Enable implicit conversions between byte and undoType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator undoType(byte value) => new undoType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(undoType value) => value.m_value;
            
            // Enable comparisons between nil and undoType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(undoType value, NilType nil) => value.Equals(default(undoType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(undoType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, undoType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, undoType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator undoType(NilType nil) => default(undoType);
        }
    }
}}}}
