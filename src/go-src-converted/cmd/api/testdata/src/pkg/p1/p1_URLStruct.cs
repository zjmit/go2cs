//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:04:26 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using ptwo = go.p2_package;
using go;

namespace go {
namespace cmd {
namespace api {
namespace testdata {
namespace src {
namespace pkg
{
    public static partial class p1_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct URL
        {
            // Constructors
            public URL(NilType _)
            {
            }
            // Enable comparisons between nil and URL struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(URL value, NilType nil) => value.Equals(default(URL));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(URL value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, URL value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, URL value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator URL(NilType nil) => default(URL);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static URL URL_cast(dynamic value)
        {
            return new URL();
        }
    }
}}}}}}