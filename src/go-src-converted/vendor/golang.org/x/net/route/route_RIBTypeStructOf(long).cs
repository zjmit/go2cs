//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 05:01:39 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using go;

namespace go {
namespace vendor {
namespace golang.org {
namespace x {
namespace net
{
    public static partial class route_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct RIBType
        {
            // Value of the RIBType struct
            private readonly long m_value;

            public RIBType(long value) => m_value = value;

            // Enable implicit conversions between long and RIBType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RIBType(long value) => new RIBType(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator long(RIBType value) => value.m_value;
            
            // Enable comparisons between nil and RIBType struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(RIBType value, NilType nil) => value.Equals(default(RIBType));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(RIBType value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, RIBType value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, RIBType value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator RIBType(NilType nil) => default(RIBType);
        }
    }
}}}}}
