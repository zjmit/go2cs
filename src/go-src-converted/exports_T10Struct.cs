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
using ast = go.go.ast_package;
using go;

namespace go {
namespace golang.org {
namespace x {
namespace tools {
namespace go {
namespace @internal
{
    public static partial class exports_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        [PromotedStruct(typeof(T8))]
        [PromotedStruct(typeof(T9))]
        public partial struct T10
        {
            // T8 structure promotion - sourced from value copy
            private readonly ptr<T8> m_T8Ref;

            private ref T8 T8_val => ref m_T8Ref.Value;

            // T9 structure promotion - sourced from value copy
            private readonly ptr<T9> m_T9Ref;

            private ref T9 T9_val => ref m_T9Ref.Value;

            public ref long a => ref m_T9Ref.Value.a;

            public ref float b => ref m_T9Ref.Value.b;

            public ref float c => ref m_T9Ref.Value.c;

            public ref slice<@string> d => ref m_T9Ref.Value.d;

            // Constructors
            public T10(NilType _)
            {
                this.m_T8Ref = new ptr<T8>(new T8(nil));
                this.m_T9Ref = new ptr<T9>(new T9(nil));
                this._ = default;
            }

            public T10(T8 T8 = default, T9 T9 = default, ref ptr<T10> _ = default)
            {
                this.m_T8Ref = new ptr<T8>(T8);
                this.m_T9Ref = new ptr<T9>(T9);
                this._ = _;
            }

            // Enable comparisons between nil and T10 struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(T10 value, NilType nil) => value.Equals(default(T10));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(T10 value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, T10 value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, T10 value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator T10(NilType nil) => default(T10);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        public static T10 T10_cast(dynamic value)
        {
            return new T10(value.T8, value.T9, ref value._);
        }
    }
}}}}}}