//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:53:25 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys
{
    public static partial class unix_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Timex
        {
            // Constructors
            public Timex(NilType _)
            {
            }
            // Enable comparisons between nil and Timex struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Timex value, NilType nil) => value.Equals(default(Timex));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Timex value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Timex value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Timex value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Timex(NilType nil) => default(Timex);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Timex Timex_cast(dynamic value)
        {
            return new Timex();
        }
    }
}}}}}}