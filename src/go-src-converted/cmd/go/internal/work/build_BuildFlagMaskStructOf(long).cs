//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:34:42 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace cmd {
namespace go {
namespace @internal
{
    public static partial class work_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct BuildFlagMask
        {
            // Value of the BuildFlagMask struct
            private readonly long m_value;

            public BuildFlagMask(long value) => m_value = value;

            // Enable implicit conversions between long and BuildFlagMask struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BuildFlagMask(long value) => new BuildFlagMask(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(BuildFlagMask value) => value.m_value;
            
            // Enable comparisons between nil and BuildFlagMask struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(BuildFlagMask value, NilType nil) => value.Equals(default(BuildFlagMask));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(BuildFlagMask value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, BuildFlagMask value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, BuildFlagMask value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator BuildFlagMask(NilType nil) => default(BuildFlagMask);
        }
    }
}}}}
