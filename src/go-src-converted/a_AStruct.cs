//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 04:55:37 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using json = go.encoding.json_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace @internal
{
    public static partial class a_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        public partial struct A
        {
            // Constructors
            public A(NilType _)
            {
                this.a = default;
                this.json = default;
            }

            public A(ref ptr<A> a = default, json.RawMessage json = default)
            {
                this.a = a;
                this.json = json;
            }

            // Enable comparisons between nil and A struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(A value, NilType nil) => value.Equals(default(A));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(A value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, A value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, A value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator A(NilType nil) => default(A);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static A A_cast(dynamic value)
        {
            return new A(ref value.a, value.json);
        }
    }
}}}}}}