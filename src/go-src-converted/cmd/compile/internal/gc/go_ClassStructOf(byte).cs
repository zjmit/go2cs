//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:28:59 UTC
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
    public static partial class gc_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Class
        {
            // Value of the Class struct
            private readonly byte m_value;

            public Class(byte value) => m_value = value;

            // Enable implicit conversions between byte and Class struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Class(byte value) => new Class(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator byte(Class value) => value.m_value;
            
            // Enable comparisons between nil and Class struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Class value, NilType nil) => value.Equals(default(Class));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Class value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Class value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Class value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Class(NilType nil) => default(Class);
        }
    }
}}}}
