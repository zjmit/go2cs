//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:36:23 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using context = go.context_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace mod {
namespace sumdb
{
    public static partial class storage_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct Write
        {
            // Constructors
            public Write(NilType _)
            {
                this.Key = default;
                this.Value = default;
            }

            public Write(@string Key = default, @string Value = default)
            {
                this.Key = Key;
                this.Value = Value;
            }

            // Enable comparisons between nil and Write struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Write value, NilType nil) => value.Equals(default(Write));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Write value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Write value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Write value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Write(NilType nil) => default(Write);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static Write Write_cast(dynamic value)
        {
            return new Write(value.Key, value.Value);
        }
    }
}}}}}