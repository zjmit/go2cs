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
        [PromotedStruct(typeof(common))]
        public partial struct B
        {
            // common structure promotion - sourced from value copy
            private readonly ptr<common> m_commonRef;

            private ref common common_val => ref m_commonRef.Value;

            public ref long i => ref m_commonRef.Value.i;

            // Constructors
            public B(NilType _)
            {
                this.m_commonRef = new ptr<common>(new common(nil));
            }

            public B(common common = default)
            {
                this.m_commonRef = new ptr<common>(common);
            }

            // Enable comparisons between nil and B struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(B value, NilType nil) => value.Equals(default(B));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(B value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, B value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, B value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator B(NilType nil) => default(B);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static B B_cast(dynamic value)
        {
            return new B(value.common);
        }
    }
}}}}}}