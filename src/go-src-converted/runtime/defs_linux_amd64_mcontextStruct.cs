//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2020 October 08 03:19:34 UTC
// </auto-generated>
//---------------------------------------------------------
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;


namespace go
{
    public static partial class runtime_package
    {
        [GeneratedCode("go2cs", "0.1.0.0")]
        private partial struct mcontext
        {
            // Constructors
            public mcontext(NilType _)
            {
                this.gregs = default;
                this.fpregs = default;
                this.__reserved1 = default;
            }

            public mcontext(array<ulong> gregs = default, ref ptr<fpstate> fpregs = default, array<ulong> __reserved1 = default)
            {
                this.gregs = gregs;
                this.fpregs = fpregs;
                this.__reserved1 = __reserved1;
            }

            // Enable comparisons between nil and mcontext struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(mcontext value, NilType nil) => value.Equals(default(mcontext));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(mcontext value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, mcontext value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, mcontext value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator mcontext(NilType nil) => default(mcontext);
        }

        [GeneratedCode("go2cs", "0.1.0.0")]
        private static mcontext mcontext_cast(dynamic value)
        {
            return new mcontext(value.gregs, ref value.fpregs, value.__reserved1);
        }
    }
}