//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 05:01:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
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
        private partial struct binaryLittleEndian
        {
            // Constructors
            public binaryLittleEndian(NilType _)
            {
            }
            // Enable comparisons between nil and binaryLittleEndian struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(binaryLittleEndian value, NilType nil) => value.Equals(default(binaryLittleEndian));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(binaryLittleEndian value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, binaryLittleEndian value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, binaryLittleEndian value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator binaryLittleEndian(NilType nil) => default(binaryLittleEndian);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static binaryLittleEndian binaryLittleEndian_cast(dynamic value)
        {
            return new binaryLittleEndian();
        }
    }
}}}}}