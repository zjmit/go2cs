//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:36 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using static go.builtin;
using @unsafe = go.@unsafe_package;

namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct tforkt
        {
            // Constructors
            public tforkt(NilType _)
            {
                this.tf_tcb = default;
                this.tf_tid = default;
                this.tf_stack = default;
            }

            public tforkt(unsafe.Pointer tf_tcb = default, ref ptr<int> tf_tid = default, System.UIntPtr tf_stack = default)
            {
                this.tf_tcb = tf_tcb;
                this.tf_tid = tf_tid;
                this.tf_stack = tf_stack;
            }

            // Enable comparisons between nil and tforkt struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(tforkt value, NilType nil) => value.Equals(default(tforkt));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(tforkt value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, tforkt value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, tforkt value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator tforkt(NilType nil) => default(tforkt);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static tforkt tforkt_cast(dynamic value)
        {
            return new tforkt(value.tf_tcb, ref value.tf_tid, value.tf_stack);
        }
    }
}