//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:46:07 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;
using go;

namespace go {
namespace cmd {
namespace vendor {
namespace golang.org {
namespace x {
namespace sys {
namespace @internal
{
    public static partial class unsafeheader_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct String
        {
            // Constructors
            public String(NilType _)
            {
                this.Data = default;
                this.Len = default;
            }

            public String(unsafe.Pointer Data = default, long Len = default)
            {
                this.Data = Data;
                this.Len = Len;
            }

            // Enable comparisons between nil and String struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(String value, NilType nil) => value.Equals(default(String));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(String value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, String value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, String value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator String(NilType nil) => default(String);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static String String_cast(dynamic value)
        {
            return new String(value.Data, value.Len);
        }
    }
}}}}}}}