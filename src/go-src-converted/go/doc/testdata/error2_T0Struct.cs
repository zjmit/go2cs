//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:02:53 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace go
{
    public static partial class error2_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct T0
        {
            // Constructors
            public T0(NilType _)
            {
            }
            // Enable comparisons between nil and T0 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T0 value, NilType nil) => value.Equals(default(T0));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T0 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T0 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T0 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T0(NilType nil) => default(T0);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static T0 T0_cast(dynamic value)
        {
            return new T0();
        }
    }
}}