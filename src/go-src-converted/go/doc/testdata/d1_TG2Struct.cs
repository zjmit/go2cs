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
    public static partial class d_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct TG2
        {
            // Constructors
            public TG2(NilType _)
            {
            }
            // Enable comparisons between nil and TG2 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(TG2 value, NilType nil) => value.Equals(default(TG2));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(TG2 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, TG2 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, TG2 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator TG2(NilType nil) => default(TG2);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static TG2 TG2_cast(dynamic value)
        {
            return new TG2();
        }
    }
}}