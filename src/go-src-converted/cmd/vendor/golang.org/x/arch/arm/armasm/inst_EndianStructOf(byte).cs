//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:44:10 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace arch {
namespace arm
{
    public static partial class armasm_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Endian
        {
            // Value of the Endian struct
            private readonly byte m_value;

            public Endian(byte value) => m_value = value;

            // Enable implicit conversions between byte and Endian struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Endian(byte value) => new Endian(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(Endian value) => value.m_value;
            
            // Enable comparisons between nil and Endian struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Endian value, NilType nil) => value.Equals(default(Endian));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Endian value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Endian value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Endian value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Endian(NilType nil) => default(Endian);
        }
    }
}}}}}}}
