//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:34:21 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal {
namespace lockedfile {
namespace @internal
{
    public static partial class filelock_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct lockType
        {
            // Value of the lockType struct
            private readonly uint m_value;

            public lockType(uint value) => m_value = value;

            // Enable implicit conversions between uint and lockType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lockType(uint value) => new lockType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator uint(lockType value) => value.m_value;
            
            // Enable comparisons between nil and lockType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(lockType value, NilType nil) => value.Equals(default(lockType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(lockType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, lockType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, lockType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator lockType(NilType nil) => default(lockType);
        }
    }
}}}}}}
